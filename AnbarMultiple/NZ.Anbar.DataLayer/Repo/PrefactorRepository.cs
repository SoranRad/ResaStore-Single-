using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MS_Control;
using NZ.Anbar.DataLayer.Context;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Anbar.DataLayer.Repo
{
    public class PrefactorRepository 
    {
        #region Fields
        private static readonly log4net.ILog log =
                             log4net
                             .LogManager
                             .GetLogger
                             (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Methods
        public void                     Delete          (long ID)
        {
            using (var context= new StorageContext(ConnectionManager.Create(), false))
            {
                var Item = context.PreFactors.Find(ID);
                if (Item != null)
                {
                    context.Entry(Item).State = EntityState.Deleted;
                    var listDelete =
                        Item
                            .Items
                            .Where(x => x.ID > 0 && x.State == Enums.NzItemState.Deleted)
                            .Select(x => x.ID)
                            .ToList();
                    context.SaveChanges();
                }
            }
        }
        public PreFactor                GetItem         (long ID)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<PreFactor>));
            var instance        = (DapperEntityConfiguration<PreFactor>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetItem;

            var Head            = new PreFactor();

            using (var con = ConnectionManager.Create())
            {
                using (var mul = con.QueryMultiple(SelectSingle, new {ID}))
                {
                    Head = mul.ReadSingleOrDefault<PreFactor>();
                    if (Head == null)
                        return null;

                    Head.Items    = mul.Read<PreFactorItems>().ToList();
                    foreach (var item in Head.Items)
                        item.PreFactor = Head;
                }

                return Head;
            }
        }
        public IEnumerable<PreFactor>   GetList         (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<PreFactor>));
            var instance        = (DapperEntityConfiguration<PreFactor>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetList;

            using (var con = ConnectionManager.Create())
            {
                return
                        con
                        .Query<PreFactor>
                            (SelectSingle, Param);
            }
           
        }
        public void                     Save            (PreFactor Factor)
        {
            byte repeate    = 0;
            bool saved      = false;
            do
            {
                try
                {
                    using (var db = new StorageContext(ConnectionManager.Create(), false))
                    {
                        
                        if (Factor.ID == 0)
                        {
                            db.PreFactors.Add(Factor);
                        }
                        else
                        {
                            //===Add
                            if (Factor.Items.Any(x => x.ID == 0))
                                foreach (var item in Factor.Items.Where(x => x.ID == 0))
                                    if (item.State == Enums.NzItemState.AddedNew)
                                        db.Entry(item).State = EntityState.Added;
                            db.Entry(Factor).State = EntityState.Modified;

                            foreach (var item in Factor.Items.Where(x=>x.ID>0).ToList())
                            {
                                if (item.State == Enums.NzItemState.Deleted)
                                    db.Entry(item).State = EntityState.Deleted;
                                else if (item.State == Enums.NzItemState.Modified)
                                    db.Entry(item).State = EntityState.Modified;
                                else if (item.ID > 0)
                                    db.PreFactorItems.Attach(item);
                            }
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
        #endregion
    }
}
