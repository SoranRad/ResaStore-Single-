using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.DataLayer;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.Business
{
    public class Manager
    {
        #region Fields
        private DbConnection    _Connection;
        private XazaneContext    _XazaneContext;
        #endregion 
        #region Constructor
        public                  Manager      ()
        {
            _Connection     = ConnectionManager.Create();
            _XazaneContext  = new XazaneContext(_Connection, false);
        }
        public                  Manager      (DbConnection Connection)
        {
            _Connection     = Connection;
            _XazaneContext  = new XazaneContext(_Connection, false);
        }
        #endregion
        #region Property

        public DbConnection Connection { get { return _Connection; } set { _Connection = value; } }
        #endregion
        #region Methods

        public void             Save<T>             (T Entity) where T : class
        {
            var Repo = new GenericRepository<T>(_Connection, _XazaneContext);
            Repo.Save(Entity);
        }
        public void             Delete<T>           (T Entity) where T : class
        {
            _XazaneContext      = new XazaneContext(_Connection, false);
            var Repo            = new GenericRepository<T>(_Connection, _XazaneContext);
            Repo.Delete(Entity);
        }

        public IEnumerable<T>   GetList<T>          (object Param = null, IDbTransaction Trans = null) where T : class
        {
            return new GenericRepository<T>(_Connection, _XazaneContext).GetList(Param, Trans);
        }
        public T                GetItem<T>          (object Param = null, IDbTransaction Trans = null) where T : class
        {
            return new GenericRepository<T>(_Connection, _XazaneContext).GetItem(Param, Trans);
        }

        public bool             HaveCircular<T>     (object Param = null, IDbTransaction Trans = null)
            where T : class, IEntityUsage
        {
            var repo = new GenericRepository<T>(_Connection, _XazaneContext);
            return repo.HaveEntityCircular(Param, Trans);
        }
        public V                GenerateCode<T, V>  (V Default, object Param = null, IDbTransaction Trans = null) where T : class, ICodeEntity
        {
            return new GenericRepository<T>(_Connection, _XazaneContext).GenCode<V>(Default, Param, Trans);
        }
        public bool             IsCodeUnique<T>     (object Param = null, IDbTransaction Trans = null) where T : class, ICodeEntity
        {
            return new GenericRepository<T>(_Connection, _XazaneContext).IsCodeUnique(Param, Trans);
        }

        #endregion
    }
}
