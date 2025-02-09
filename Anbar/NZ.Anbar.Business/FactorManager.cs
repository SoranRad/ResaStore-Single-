using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Interface;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.DataLayer.Repo;
using NZ.Anbar.Model;
using ShareLib.Utils;

namespace NZ.Anbar.Business
{
    public class FactorManager
    {
        #region Fields

        private IFactorRepository   _Repo;
        private DbConnection        _Connection;
        #endregion

        #region Constructor
        public      FactorManager()
        {
            _Connection = ConnectionManager.Create();
            _Repo       = new FactorRepository();
        }
        public      FactorManager(DbConnection Connection)
        {
            _Connection = Connection;
            _Repo       = new FactorRepository();
        }
        #endregion
        #region Property
        public DbConnection Connection
        {
            get => _Connection;
            set => _Connection = value;
        }
        #endregion
        #region Methods

        public void Save(FactorHead Factor, bool AutoSerial = true)
        {
            _Repo.Save(Factor,AutoSerial);
        }
        public void                     Delete          (long ID)
        {
            _Repo.Delete(ID);
        }
        public FactorHead               GetItem         (long ID)
        {
            return _Repo.GetItem(ID);
        }
        public IEnumerable<FactorHead>  GetList         (object param)
        {
            return _Repo.GetList(param);
        }
        public int                      GetMaxSerial    (object param)
        {
            return _Repo.GetMaxSerial(param);
        }
        public bool                     IsCodeUnique    (object param)
        {
            return _Repo.IsCodeUnique(param);
        }
        public IEnumerable<PrintFactor> GetPrintFactor  (long ID)
        {
            var list = new List<long>() {ID};

            return _Repo.GetAllPrint(list);
        }
        public IEnumerable<PrintFactor> GetPrintFactor(List<long> List)
        {
            return _Repo.GetAllPrint(List);
        }

        public void FixFifo()
        {
            _Repo.FixFifoKardex();
        }
        public void FixRemain()
        {
            _Repo.FixRemain();
        }
        #endregion
    }
}
