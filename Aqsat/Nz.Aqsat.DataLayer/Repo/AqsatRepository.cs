using Dapper;
using Nz.Aqsat.DataLayer.Context;
using Nz.Aqsat.Model.Interface;
using Nz.Aqsat.Model.Models;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;

namespace NZ.Aqsat.DataLayer.Repo
{
    public class AqsatRepository : IAqsatRepository
    {
        #region Fields
        private static readonly log4net.ILog log =
                             log4net
                             .LogManager
                             .GetLogger
                             (MethodBase.GetCurrentMethod().DeclaringType);
        
        #endregion
        #region Constructor
        public                          AqsatRepository()
        {
            //_Connection     = Connection;
            //_Context        = new StorageContext(_Connection,false);
        }
        #endregion
        #region Methods
        public void                     Delete          (long ID)
        {
            using (var context= new AqsatContext(ConnectionManager.Create(), false))
            {
                var Item = context.AqsatMains.Find(ID);
                if (Item != null)
                {
                    context.Entry(Item).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }
        

        public Aqsat_Main               GetItem         (long ID)
        {

	        using (var context= new AqsatContext(ConnectionManager.Create(), false))
	        {
		        var item = context.AqsatMains.Find(ID);

                foreach (var riz in item.AqsatRizs)
                {
	                if (riz.isPardaxt)
		                riz.PersianTarixPardaxt = riz.tarixPardaxt?.ToPersianDate();
                    
	                riz.PersianTarixQest = riz.tarixQest.ToPersianDate();
                }

                return item;
	        }
        }
        public IEnumerable<Aqsat_Main>  GetList         (object Param)
        {
	        return null;
        }
        public int                      GetMaxSerial    (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<Aqsat_Main>));
            var instance        = (DapperEntityConfiguration<Aqsat_Main>)Activator.CreateInstance(t);
            var SelectSingle    = instance.GetMaxSerial;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int?>
                    (SelectSingle, Param);
                return max ?? 0;
            }
        }

        public bool                     IsCodeUnique    (object Param)
        {
            Assembly asm        = Assembly.Load(this.GetType().Assembly.GetName());
            var t               = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<Aqsat_Main>));
            var instance        = (DapperEntityConfiguration<Aqsat_Main>)Activator.CreateInstance(t);
            var SelectSingle    = instance.IsCodeUnique;

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int>
                    (SelectSingle, Param);
                return max == 0;
            }

            
        }
        public void                     Save            (Aqsat_Main Aqsat,bool AutoSerial=true)
        {
            byte repeate    = 0;
            bool saved      = false;
            do
            {
                try
                {
                    using (var db = new AqsatContext(ConnectionManager.Create(), false))
                    {
                        if (Aqsat.ID == 0 && AutoSerial)
                        {
                            Aqsat.Serial = GetMaxSerial(null) + 1;
                        }

                        if (Aqsat.ID == 0)
                        {
							//foreach (Aqsat_Riz item in Aqsat.AqsatRizs.Where(x => x.ID == 0))
							//	db.Entry(item).State = System.Data.Entity.EntityState.Added;

							db.AqsatMains.Add(Aqsat);
                        }
                        else
                        {
                            //===Add
                            if (Aqsat.AqsatRizs.Any(x => x.ID == 0))
                                foreach (Aqsat_Riz item in Aqsat.AqsatRizs.Where(x => x.ID == 0))
                                    if (item.State == Enums.NzItemState.AddedNew)
                                        db.Entry(item).State = System.Data.Entity.EntityState.Added;

                            
                            db.Entry(Aqsat).State = System.Data.Entity.EntityState.Modified;

                            foreach (Aqsat_Riz item in Aqsat.AqsatRizs.Where(x => x.ID > 0).ToList()) 
                            {
                                if (item.State == Enums.NzItemState.Deleted)
                                    db.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                                else if (item.State == Enums.NzItemState.Modified)
                                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                                else if (item.ID > 0)
                                    db.AqsatRizes.Attach(item);
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
                    log.Info("\n=======ذخیره برای اقساط " + repeate + "\n=====");
                    log.Error(ex);
                    log.Info("\n==============================================\n");

                    throw ex;
                }
            } while (saved && repeate > 3);

        }
        #endregion
         
    }
}
