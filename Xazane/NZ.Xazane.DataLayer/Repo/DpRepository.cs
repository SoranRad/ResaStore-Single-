using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using NZ.Xazane.Model.Interfaces;
using NZ.Xazane.Model.Models;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Xazane.DataLayer.Repo
{
    public class DpRepository : IDpRepository
    {
        #region Fields
        private DbConnection    _Connection;
        private XazaneContext   _Context;
        #endregion
        #region Property

        public DbConnection Connection => _Connection;
        #endregion
        #region Constructor
        public      DpRepository     ()
        {
            _Connection     = ConnectionManager.Create();
            _Context        = new XazaneContext(_Connection , false);

        }
        public      DpRepository     (DbConnection Connection)
        {
            _Connection     = Connection;
            _Context        = new XazaneContext(_Connection , false);
        }
        #endregion
        #region Methods
        public void                         Delete          (long ID)
        {
            var Item = _Context.tbl_Amaliat_DP.Find(ID);
            if (Item != null)
            {
                _Context.Entry(Item).State = EntityState.Deleted;
                _Context.SaveChanges();
            }
        }
        public DPOperation                  GetItem         (long ID)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<DPOperation>));
            var instance        = (DapperEntityConfiguration<DPOperation>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetItem;

            using (var con = ConnectionManager.Create())
            {
                DPOperation Head = new DPOperation();

                using (var mul = con.QueryMultiple(SelectSingle, new { ID }))
                {
                    Head = mul.ReadSingleOrDefault<DPOperation>();
                    if (Head == null)
                        return null;
                    Head.PayBoxOP = mul.Read<PayBoxOperation>()?.ToList();
                    Head.ChequeOP = mul.Read<ChequeOperation>()?.ToList();
                }

                return Head;
            }

            
        }

        public DPOperation                  GetItemByFactorID(long IdFactor)
        {
            var dp = _Context.tbl_Amaliat_DP.FirstOrDefault(x=>x.FK_Faktor==IdFactor);
            if (dp == null)
                return null;

            return GetItem(dp.ID);
        }
        public IEnumerable<DPOperation>     GetList         (object Param)
        {
            throw new NotImplementedException();
        }
        public int                          GetMaxSerial    (object Param )
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<DPOperation>));
            var instance        = (DapperEntityConfiguration<DPOperation>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetMaxSerial;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int?>
                    (SelectSingle, Param);
                return max ?? 0;
            }

            
        }
        public bool                         IsCodeUnique    (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<DPOperation>));
            var instance        = (DapperEntityConfiguration<DPOperation>)Activator.CreateInstance(t);
            var SelectSingle    = instance.IsCodeUnique;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int>
                    (SelectSingle, Param);
                return max == 0;
            }

           
        }
        public void                         Save            (DPOperation DPItem)
        {
            if (DPItem.ID == 0)
            {
                _Context.tbl_Amaliat_DP.Add(DPItem);
                _Context.SaveChanges();
            }
            else
            {
                foreach (var item in DPItem.PayBoxOP.Where(x=>x.ID==0))
                    _Context.Entry(item).State= EntityState.Added;

                foreach (var item in DPItem.ChequeOP.Where(x=>x.ID==0))
                    _Context.Entry(item).State = EntityState.Added;

                //var r = _Context.tbl_Amaliat_DP.Local.SingleOrDefault(x => x.ID == DPItem.ID);
                //if (r != null)
                //{
                //    foreach (var entity in _Context.ChangeTracker.Entries())
                //        _Context.Entry(entity.Entity).State = EntityState.Detached;
                //}

                _Context.Entry(DPItem).State = EntityState.Modified;

                foreach (var item in DPItem.PayBoxOP.Where(x=>x.State != Enums.NzItemState.AddedNew).ToList())
                    if(item.State==Enums.NzItemState.Deleted)
                        _Context.Entry(item).State =  EntityState.Deleted;
                    else if (item.State == Enums.NzItemState.Modified)
                        _Context.Entry(item).State = EntityState.Modified;
                    else
                        _Context.Entry(item).State = EntityState.Unchanged;

                foreach (var item in DPItem.ChequeOP.Where(x => x.State != Enums.NzItemState.AddedNew).ToList())
                    if (item.State == Enums.NzItemState.Deleted)
                        _Context.Entry(item).State = EntityState.Deleted;
                    else if (item.State == Enums.NzItemState.Modified)
                        _Context.Entry(item).State = EntityState.Modified;
                    else
                        _Context.Entry(item).State = EntityState.Unchanged;

                _Context.SaveChanges();
            }
        }
        public IEnumerable<T>               GetView<T>      (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T>));
            var instance        = (DapperEntityConfiguration<T>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetList;

            using (var con = ConnectionManager.Create())
            {
                return con
                        .Query<T>
                            (SelectSingle, Param);
            }
        }   
        #endregion

    }
}
