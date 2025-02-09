using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.DataLayer.Repo;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Xazane.Business
{
    public class ReportManager
    {
        #region Fields
        private DbConnection        _Connection;
        private IReportRepository   _Repo;
        private IMultipleReport     _MRepo;
        #endregion
        #region Property
        public DbConnection Connection
        {
            get => _Connection;
            set => _Connection = value;
        }
        #endregion
        #region Constructor
        public      ReportManager   ()
        {
            _Connection     = ConnectionManager.Create();
            _Repo           = new ReportRepository(_Connection);
        }
        public      ReportManager   (DbConnection Connection)
        {
            _Connection     = Connection;
            _Repo           = new ReportRepository(_Connection);
        }
        #endregion
        #region Methods
        public IEnumerable<T> GetReport<T>  (object Params, string WhereClause)
        {
            return _Repo.List<T>(Params, WhereClause);
        }
        public T GetItem<T>(object Params, string WhereClause)
        {
            return _Repo.Item<T>(Params, WhereClause);
        }
        #endregion
        #region Multiple Items
        public Tuple<T1, T2>                Multiple<T1, T2>                (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.Multiple<T1, T2>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<T1, T2, T3>            Multiple<T1, T2,T3 >            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.Multiple<T1, T2, T3>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<T1, T2, T3 ,T4>        Multiple<T1, T2, T3, T4>        (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.Multiple<T1, T2, T3,T4>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<T1, T2, T3, T4,T5>     Multiple<T1, T2, T3, T4,T5>     (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.Multiple<T1, T2, T3, T4,T5>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<T1, T2, T3, T4, T5,T6> Multiple<T1, T2, T3, T4, T5,T6> (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.Multiple<T1, T2, T3, T4, T5,T6>(FetchSQL, Params, WhereClauseAppend);
        }
        #endregion
        #region Multiple List

        public Tuple<IEnumerable<T1>, IEnumerable<T2>>                                                                      MultipleList<T1, T2>                    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.MultipleList<T1, T2 >(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>>                                                     MultipleList<T1, T2, T3>                (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.MultipleList<T1, T2, T3 >(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>>                                    MultipleList<T1, T2, T3, T4>            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.MultipleList<T1, T2, T3,T4>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>>                   MultipleList<T1, T2, T3, T4, T5>        (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.MultipleList<T1, T2, T3, T4,T5>(FetchSQL, Params, WhereClauseAppend);
        }
        public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>>  MultipleList<T1, T2, T3, T4, T5, T6>    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null)
        {
            _MRepo = _MRepo ?? new MultipleReport();
            return _MRepo.MultipleList<T1, T2, T3, T4, T5,T6>(FetchSQL, Params, WhereClauseAppend);
        }
        #endregion
    }
}
