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
using NZ.Xazane.Model.ViewModel;
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
        public void                         Delete                  (long ID)
        {
            var Item = _Context.tbl_Amaliat_DP.Find(ID);
            var ItemDp = GetItem(ID);
            if (Item != null)
            {
                if (ItemDp != null)
                {
	                foreach (var chequePayment in ItemDp.PeopleCheques)
	                {
						var cheque = _Context.tbl_Amaliat_Check.SingleOrDefault(x => x.ID == chequePayment.ID);
						if (cheque != null)
						{
							cheque.DpHead_Vagozari = null;
							cheque.FK_DP_Vagozari = null;
							cheque.FK_Salmali_Vaziat = null;
							cheque.Kind_Vaziat = null;
							cheque.Tarix_Vaziat = null;
							cheque.FK_Xazaneh_Vaziat = null;
							cheque.FK_User_Edit_Vaziat = cheque.FK_User_Add_Vaziat == null ? null : (short?)SystemConstant.ActiveUser.ID;
							cheque.FK_User_Add_Vaziat = cheque.FK_User_Add_Vaziat ?? SystemConstant.ActiveUser.ID;
							cheque.Tarix_Edit_Vaziat = cheque.Tarix_Add_Vaziat == null ? null : (DateTime?)DateTime.Now;
							cheque.Tarix_Add_Vaziat = cheque.Tarix_Add_Vaziat ?? DateTime.Now;
							cheque.Sharh_Vaziat = null;
							cheque.FK_Shaxs_Vaziat = null;
						}
	                }
                }
                _Context.Entry(Item).State = EntityState.Deleted;
				_Context.SaveChanges();
            }
        }
        public DPOperation                  GetItem                 (long ID)
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

                    Head.PayBoxOP           = mul.Read<PayBoxOperation>()?.ToList();
                    Head.ChequeOP           = mul.Read<ChequeOperation>()?.ToList();
                    Head.PeopleCheques      = mul.Read<PeopleChequePayment>()?.ToList();
				}

                return Head;
            }

            
        }

        public DPOperation                  GetItemByFactorID       (long IdFactor)
        {
            var dp = _Context.tbl_Amaliat_DP.FirstOrDefault(x=>x.FK_Faktor==IdFactor);
            if (dp == null)
                return null;

            return GetItem(dp.ID);
        }
        public IEnumerable<DPOperation>     GetList                 (object Param)
        {
            throw new NotImplementedException();
        }
        public int                          GetMaxSerial            (object Param )
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
        public bool                         IsCodeUnique            (object Param)
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
        public void                         Save                    (DPOperation DPItem)
        {
            if (DPItem.ID == 0)
            {
                _Context.tbl_Amaliat_DP.Add(DPItem);

                foreach (var chequePayment in DPItem.PeopleCheques.Where(x=>x.State == Enums.NzItemState.AddedNew))
                {
	                var cheque = _Context.tbl_Amaliat_Check.SingleOrDefault(x => x.ID == chequePayment.ID);
	                if (cheque != null)
	                {
		                cheque.DpHead_Vagozari      = DPItem;
		                cheque.FK_Salmali_Vaziat    = SystemConstant.ActiveYear.Salmali;
		                cheque.Kind_Vaziat          = (byte)Enums.NzChequeStateFlag.Vagozari;
		                cheque.Tarix_Vaziat         = DateTime.Now.Date;
		                cheque.FK_Xazaneh_Vaziat    = null;
		                cheque.FK_User_Edit_Vaziat  = cheque.FK_User_Add_Vaziat ==null ? null : (short?)SystemConstant.ActiveUser.ID;
						cheque.FK_User_Add_Vaziat   = cheque.FK_User_Add_Vaziat ?? SystemConstant.ActiveUser.ID;
						cheque.Tarix_Edit_Vaziat    = cheque.Tarix_Add_Vaziat == null ? null : (DateTime?)DateTime.Now;
						cheque.Tarix_Add_Vaziat     = cheque.Tarix_Add_Vaziat ?? DateTime.Now;
						cheque.Sharh_Vaziat         = chequePayment.Sharh_Vaziat ;
						cheque.FK_Shaxs_Vaziat      = DPItem.FK_ShaXs;
	                }
                }

                _Context.SaveChanges();
            }
            else
            {
                foreach (var item in DPItem.PayBoxOP.Where(x=>x.ID==0))
                    _Context.Entry(item).State= EntityState.Added;

                foreach (var item in DPItem.ChequeOP.Where(x=>x.ID==0))
                    _Context.Entry(item).State = EntityState.Added;

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

                //============== واگذاری چک
				foreach (var chequePayment in DPItem.PeopleCheques.Where(x => x.State == Enums.NzItemState.AddedNew))
				{
					var cheque = _Context.tbl_Amaliat_Check.SingleOrDefault(x => x.ID == chequePayment.ID);
					if (cheque != null)
					{
						cheque.DpHead_Vagozari = DPItem;
						cheque.FK_Salmali_Vaziat = SystemConstant.ActiveYear.Salmali;
						cheque.Kind_Vaziat = (byte)Enums.NzChequeStateFlag.Vagozari;
						cheque.Tarix_Vaziat = DateTime.Now.Date;
						cheque.FK_Xazaneh_Vaziat = null;
						cheque.FK_User_Edit_Vaziat = cheque.FK_User_Add_Vaziat == null ? null : (short?)SystemConstant.ActiveUser.ID;
						cheque.FK_User_Add_Vaziat = cheque.FK_User_Add_Vaziat ?? SystemConstant.ActiveUser.ID;
						cheque.Tarix_Edit_Vaziat = cheque.Tarix_Add_Vaziat == null ? null : (DateTime?)DateTime.Now;
						cheque.Tarix_Add_Vaziat = cheque.Tarix_Add_Vaziat ?? DateTime.Now;
						cheque.Sharh_Vaziat = chequePayment.Sharh_Vaziat;
						cheque.FK_Shaxs_Vaziat = DPItem.FK_ShaXs;
					}
				}

				//============= ویرایش چک واگذاری 
				foreach (var chequePayment in DPItem.PeopleCheques.Where(x => x.State == Enums.NzItemState.NotChanged))
				{
					var cheque = _Context.tbl_Amaliat_Check.SingleOrDefault(x => x.ID == chequePayment.ID);
					if (cheque != null)
					{
						if(cheque.FK_Shaxs_Vaziat != DPItem.FK_ShaXs)
						    cheque.FK_Shaxs_Vaziat = DPItem.FK_ShaXs;
					}
				}
				
				//============= حذف چک واگذاری
				foreach (var chequePayment in DPItem.PeopleCheques.Where(x => x.State == Enums.NzItemState.Deleted))
				{
					var cheque = _Context.tbl_Amaliat_Check.SingleOrDefault(x => x.ID == chequePayment.ID);
					if (cheque != null)
					{
						cheque.DpHead_Vagozari          = null;
						cheque.FK_Salmali_Vaziat        = null;
						cheque.Kind_Vaziat              = (byte)Enums.NzChequeStateFlag.Nazd_Sanduq;
						cheque.Tarix_Vaziat             = DateTime.Now;
						cheque.FK_Xazaneh_Vaziat        = null;
						cheque.FK_User_Edit_Vaziat      = cheque.FK_User_Add_Vaziat == null ? null : (short?)SystemConstant.ActiveUser.ID;
						cheque.FK_User_Add_Vaziat       = cheque.FK_User_Add_Vaziat ?? SystemConstant.ActiveUser.ID;
						cheque.Tarix_Edit_Vaziat        = cheque.Tarix_Add_Vaziat == null ? null : (DateTime?)DateTime.Now;
						cheque.Tarix_Add_Vaziat         = cheque.Tarix_Add_Vaziat ?? DateTime.Now;
						cheque.Sharh_Vaziat             = null;
						cheque.FK_Shaxs_Vaziat          = null;
					}
				}

				_Context.SaveChanges();
            }
        }
        public IEnumerable<T>               GetView<T>              (object Param)
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
