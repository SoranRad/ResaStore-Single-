using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Utils;
using System.Data.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using Dapper;
using Nz.Anbar.Model.Interface;
using NZ.Anbar.DataLayer.Context;
using NZ.Anbar.Model;
using System.Reflection;
using System.Threading;
using MS_Control;
using ShareLib;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Models;

namespace NZ.Anbar.DataLayer.Repo
{
    public class FactorRepository : IFactorRepository
    {
        #region Fields
        private static readonly log4net.ILog log =
                             log4net
                             .LogManager
                             .GetLogger
                             (MethodBase.GetCurrentMethod().DeclaringType);
        
        #endregion
        #region Constructor
        public                          FactorRepository()
        {
            //_Connection     = Connection;
            //_Context        = new StorageContext(_Connection,false);
        }
        #endregion
        #region Methods
        public void                     Delete          (long ID)
        {
            using (var context= new StorageContext(ConnectionManager.Create(), false))
            {
                var Item = context.FactorHeads.Find(ID);
                if (Item != null)
                {
                    context.Entry(Item).State = EntityState.Deleted;
                    var listDelete =
                        Item
                            .FactorItems
                            .Where(x => x.ID > 0 && x.State == Enums.NzItemState.Deleted)
                            .Select(x => x.ID)
                            .ToList();

                    foreach (var riz in Item.FactorItems)
                        KardexProcess.Delete(context, Item, riz, listDelete);

                    context.SaveChanges();
                }
            }
        }
        

        public FactorHead               GetItem         (long ID)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<FactorHead>));
            var instance        = (DapperEntityConfiguration<FactorHead>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetItem;

            FactorHead Head     = new FactorHead();

            using (var con = ConnectionManager.Create())
            {
                using (var mul = con.QueryMultiple(SelectSingle, new {ID}))
                {
                    Head = mul.ReadSingleOrDefault<FactorHead>();
                    if (Head == null)
                        return null;

                    Head.FactorItems    = mul.Read<FactorItem>().ToList();
                    foreach (var item in Head.FactorItems)
                        item.FactorHead = Head;

                    var detail          = mul.ReadSingleOrDefault<FactorDetail>();
                    if (detail != null)
                    {
                        Head.FactorDetail = detail;
                        detail.FactorHead = Head;
                    }
                }

                return Head;
            }
        }
        public IEnumerable<FactorHead>  GetList         (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<FactorHead>));
            var instance        = (DapperEntityConfiguration<FactorHead>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetList;

            using (var con = ConnectionManager.Create())
            {
                return
                        con
                        .Query<FactorHead>
                            (SelectSingle, Param);
            }
           
        }
        public int                      GetMaxSerial    (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<FactorHead>));
            var instance        = (DapperEntityConfiguration<FactorHead>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetMaxSerial;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int?>
                    (SelectSingle, Param);
                return max ?? 0;
            }

            
        }

        public void                     FixFifoKardex   ()
        {
            try
            {
                IList<FactorItem> Objects =new List<FactorItem>();
                using (var db = new StorageContext(ConnectionManager.Create(), false))
                {
                    Objects = 
                            db
                                .FactorItems
                                .Include(x =>   x.FactorHead)
                                .Where  (x => 
                                                x.FK_Salmali == SystemConstant.ActiveYear.Salmali
                                            &&  x.FactorHead.kind >= 11
                                            &&  x.FactorHead.kind < 100
                                        )
                                .GroupBy(x =>   new { x.FK_Kala , x.FK_Anbar_Az})
                                .Select
                                (x =>
                                    x.OrderBy   (y => y.FactorHead.tarikh)
                                     .ThenBy    (y => y.FactorHead.kind)
                                     .ThenBy    (y => y.FactorHead.Serial)
                                     .FirstOrDefault()
                                )
                                .ToList();
                }
                log.Info("\n======= شروع بروزرسانی کاردکس ===== \n");
                log.Info("\n======================================== \n");
                foreach (var item in Objects)
                {
                    var factor  = GetItem(item.FK_Title);

                    //var row     = factor?.FactorItems.SingleOrDefault(x => x.ID == item.ID);

                    //if (row != null)
                    //    row.State = Enums.NzItemState.Modified;

                    foreach (var riz in factor.FactorItems)
                    {
                        //riz.nerkh_2 = 0;
                        //riz.CostDescriptor = "";

                        if (riz.meqdar > 0 && riz.mablaq > 0 && riz.nerkh <= 0)
                            riz.nerkh = riz.mablaq / riz.meqdar;

                        riz.State = Enums.NzItemState.Modified;
                    }

                    Save(factor,false);
                }
                log.Info("\n======= پایان بروزرسانی کاردکس ===== \n");
                log.Info("\n======================================== \n");

            }
            catch (Exception ex)
            {
                
                log.Info("\n======= خطا در بروزرسانی کاردکس ===== \n");
                log.Error(ex);
                log.Info("\n======================================== \n");

            }
        }
        public void                     FixRemain       ()
        {
            try
            {
                log.Info("\n======= شروع بروزرسانی مانده کاردکس ===== \n");
                log.Info("\n======================================== \n");
                //IList<FactorItem> Objects =new List<FactorItem>();
                using (var db = new StorageContext(ConnectionManager.Create(), false))
                {
                    //var Objects =
                        var list =db
                            .NzObjects
                            .GroupBy(x => x.Code)
                            .ToList();
                        list
                            .MSZ_ForEach(x =>
                            {
                                var CountOfOut = db
                                    .FactorItems
                                    .Include(y => y.FactorHead)
                                    .Where( y =>
                                            y.FK_Salmali==SystemConstant.ActiveYear.Salmali
                                        &&  y.FK_Kala== x.Key 
                                        &&  y.FactorHead.kind >= 50 && y.FactorHead.kind < 100
                                    )
                                    .Select(y=>(decimal?)y.meqdar)
                                    .Sum()??0;

                                db
                                    .FactorItems
                                    .Include(y => y.FactorHead)
                                    .Where(y =>
                                        y.FK_Salmali == SystemConstant.ActiveYear.Salmali
                                        && y.FK_Kala == x.Key
                                        && y.FactorHead.kind >= 11 && y.FactorHead.kind < 50
                                    )
                                    .ToList()
                                    .OrderBy(y => y.FactorHead.tarikh.Date)
                                    .ThenBy(y => y.FactorHead.kind)
                                    .ThenBy(y => y.FactorHead.Serial)
                                    .MSZ_ForEach( y =>
                                    {
                                        if (CountOfOut > 0)
                                        {
                                            if (CountOfOut > y.meqdar)
                                            {
                                                y.Remain = 0;
                                                CountOfOut -= y.meqdar;
                                            }
                                            else
                                            {
                                                y.Remain = y.meqdar - CountOfOut;
                                                CountOfOut = 0;
                                            }
                                        }
                                        else
                                            y.Remain = y.meqdar;

                                        db.Entry(y).State = EntityState.Modified;
                                        db.SaveChanges();

                                    });

                            });

                       
                        log.Info("\n======= اتمام بروزرسانی مانده کاردکس ===== \n");
                }
            }
            catch (Exception ex)
            {
                log.Info("\n======= خطا در بروزرسانی مانده کاردکس ===== \n");
                log.Error(ex);
                log.Info("\n======================================== \n");
            }
        }

        public bool                     IsCodeUnique    (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<FactorHead>));
            var instance        = (DapperEntityConfiguration<FactorHead>)Activator.CreateInstance(t);
            var SelectSingle    = instance.IsCodeUnique;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int>
                    (SelectSingle, Param);
                return max == 0;
            }

            
        }
        public void                     Save            (FactorHead Factor,bool AutoSerial=true)
        {
            byte repeate    = 0;
            bool saved      = false;
            do
            {
                try
                {
                    using (var db = new StorageContext(ConnectionManager.Create(), false))
                    {
                        if (Factor.ID == 0 && AutoSerial)
                        {
                            Factor.Serial = GetMaxSerial(new
                            {
                                Kind = Factor.kind,
                                Year = SystemConstant.ActiveYear.Salmali
                            }) + 1;
                        }

                        if (Factor.ID == 0)
                        {
                            db.FactorHeads.Add(Factor);
                            foreach (FactorItem item in Factor.FactorItems.ToList())
                                KardexProcess.Add(db, Factor, item, new List<long>());
                        }
                        
                        else
                        {
                            //===Add
                            if (Factor.FactorItems.Any(x => x.ID == 0))
                                foreach (FactorItem item in Factor.FactorItems.Where(x => x.ID == 0))
                                    if (item.State == Enums.NzItemState.AddedNew)
                                        db.Entry(item).State = EntityState.Added;

                            //==== AddDetail
                            if (Factor.FactorDetail?.ID == 0)
                                db.Entry(Factor.FactorDetail).State = EntityState.Added;

                            db.Entry(Factor).State = EntityState.Modified;

                            var listDelete =
                                Factor
                                    .FactorItems
                                    .Where(x => x.ID > 0 && x.State == Enums.NzItemState.Deleted)
                                    .Select(x => x.ID)
                                    .ToList();

                            foreach (FactorItem item in Factor.FactorItems.Where(x=>x.ID>0).ToList())
                            {
                                if (item.State == Enums.NzItemState.Deleted)
                                    db.Entry(item).State = EntityState.Deleted;
                                else if (item.State == Enums.NzItemState.Modified)
                                    db.Entry(item).State = EntityState.Modified;
                                else if (item.ID > 0)
                                    db.FactorItems.Attach(item);
                            }

                            if (Factor?.FactorDetail?.State == Enums.NzItemState.Modified)
                                db.Entry(Factor.FactorDetail).State = EntityState.Modified;

                            foreach (FactorItem item in Factor.FactorItems.ToList())
                            {
                                if (item.State == Enums.NzItemState.Deleted)
                                   KardexProcess.Delete(db, Factor, item, listDelete);
                                else if (item.State == Enums.NzItemState.Modified )
                                   KardexProcess.Update(db, Factor, item, listDelete); 
                                else if (item.State == Enums.NzItemState.AddedNew)
                                   KardexProcess.Add(db, Factor, item, listDelete); 
                            }
                        }

                        if (
                                    Factor.kind == (int)Enums.NzFactorKind.HavaleZayeat
                                ||  Factor.kind == (int)Enums.NzFactorKind.HavaleMasrafi
                            )
                        {
                            Factor.mablaq = Factor
                                                .FactorItems
                                                .Where(x => x.State != Enums.NzItemState.Deleted)
                                                .Select(x =>(decimal?) x.nerkh_2)
                                                .Sum()??0;
                        }

                        db.SaveChanges();
                        saved = true;
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    repeate ++;
                   
                }
                catch (Exception ex)
                {
                    log.Info("\n=======ذهیره برای بار " + repeate + "\n=====");
                    log.Error(ex);
                    log.Info("\n==============================================\n");

                    throw ex;
                }
            } while (saved && repeate > 3);

        }
        #endregion
        #region Print Methods
        public PrintFactor              GetPrint        (long ID)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<PrintFactor>));
            var instance        = (DapperEntityConfiguration<PrintFactor>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetItem;

            using (var con = ConnectionManager.Create())
            {
                return con
                    .QuerySingleOrDefault<PrintFactor>
                    (SelectSingle, new { ID });
            }
        }
        public IEnumerable<PrintFactor> GetAllPrint     (List<long> List)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<PrintFactor>));
            var instance        = (DapperEntityConfiguration<PrintFactor>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetList;

            var str = SelectSingle+ " WHERE " + string.Join(" OR ", List.Select(x => " tat.ID= " + x.ToString()));

            str += @"


";
            using (var con = ConnectionManager.Create())
            {
                return con
                        .Query<PrintFactor>
                            (str);
            }
            
        }
        #endregion
    }
}
