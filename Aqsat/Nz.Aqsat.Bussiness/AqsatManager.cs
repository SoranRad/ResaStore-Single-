using System.Data.Common;
using Nz.Aqsat.Model.Interface;
using Nz.Aqsat.Model.Models;

using NZ.Aqsat.DataLayer.Repo;
using ShareLib.Utils;

namespace NZ.Aqsat.Business
{
    public class AqsatManager
    {
        #region Fields

        private IAqsatRepository    _Repo;
        private DbConnection        _Connection;
        #endregion

        #region Constructor
        public      AqsatManager()
        {
            _Connection = ConnectionManager.Create();
            _Repo       = new AqsatRepository();
        }
        #endregion
        #region Methods

        public void Save(Aqsat_Main aqsat, bool AutoSerial = true)
        {
            _Repo.Save(aqsat, AutoSerial);
        }
        public void                     Delete          (long ID)
        {
            _Repo.Delete(ID);
        }
        public Aqsat_Main               GetItem         (long ID)
        {
            return _Repo.GetItem(ID);
        }
        public int                      GetMaxSerial    (object param)
        {
            return _Repo.GetMaxSerial(param);
        }
        public bool                     IsCodeUnique    (object param)
        {
            return _Repo.IsCodeUnique(param);
        }
         
        #endregion
    }
}
