using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.DataLayer.Repo;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Anbar.Business
{
    public class ReportManager
    {
        #region Fields
        private DbConnection        _Connection;
        private IReportRepository   _Repo;
        #endregion
        #region Property
        public DbConnection Connection { get; set; }
        #endregion
        #region Constructor

        public ReportManager    ()
        {
            _Connection = ConnectionManager.Create();
            _Repo       = new ReportRepository(_Connection);
        }
        public ReportManager    (DbConnection Connection)
        {
            _Connection = Connection;
            _Repo       = new ReportRepository(_Connection);
        }
        #endregion
        #region Methods
        public IEnumerable<T>   GetReport<T>    (object Params, string WhereClause)
        {
            return _Repo.List<T>(Params, WhereClause);
        }
        public T                GetItem<T>      (object Params, string WhereClause)
        {
            return _Repo.Item<T>(Params, WhereClause);
        }

        #endregion
    }
}
