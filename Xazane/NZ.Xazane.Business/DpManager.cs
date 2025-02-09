using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.DataLayer;
using NZ.Xazane.DataLayer.Repo;
using NZ.Xazane.Model.Interfaces;
using NZ.Xazane.Model.Models;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.Business
{
    public class DpManager
    {
        #region Fields
        private DbConnection    _Connection;
        private IDpRepository   _Repo;
        #endregion
        #region Constractor
        public DpManager()
        {
            _Connection = ConnectionManager.Create();
            _Repo       = new DpRepository(_Connection);
        }
        public DpManager(DbConnection Connection)
        {
            _Connection = Connection;
            _Repo       = new DpRepository(_Connection);
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

        public void                         Save            (DPOperation Item)
        {
            _Repo.Save(Item);
        }
        public void                         Delete          (long ID) 
        {
            _Repo.Delete(ID);
        }

        public IEnumerable<DPOperation>     GetList         (object Param)
        {
            return _Repo.GetList(Param);
        }
        public DPOperation                  GetItem         (long ID)
        {
            return _Repo.GetItem(ID);
        }
        public DPOperation                  GetItemByFactor         (long IdFactor)
        {
            return _Repo.GetItemByFactorID(IdFactor);
        }

        public int                          GetMaxSerial    (object Param)
        {
            return _Repo.GetMaxSerial(Param);
        }
        public bool                         IsCodeUnique    (object Param)
        {
            return _Repo.IsCodeUnique(Param);
        }
        public IEnumerable<T>               GetView<T>      (object Param)
        {
            return _Repo.GetView<T>(Param);
        }

        #endregion

    }
}
