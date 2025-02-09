using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.General.DataLayer;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.Business
{
    public class Manager
    {
        #region Fields
        private     DbConnection    _Connection;
        private     GeneralContext _GeneralContext;
        #endregion
        #region Constructor
        public  Manager  ()
        {
            _Connection         = ConnectionManager.Create();
            _GeneralContext     = new GeneralContext(_Connection,false);
        }
        public  Manager  (DbConnection Connection)
        {
            _Connection         = Connection;
            _GeneralContext     = new GeneralContext(_Connection, false);
        }
        #endregion
        #region Property

        public DbConnection Connection { get { return _Connection; } set { _Connection = value; } }
        #endregion
        #region Methods

        public void             Save    <T>         (T Entity) where T : class
        {
            var Repo            = new GenericRepository<T>(_Connection,_GeneralContext);
            Repo.Save(Entity);
        }
        public void             Delete  <T>         (T Entity) where T : class
        {
            _GeneralContext     = new GeneralContext(_Connection, false);
            var Repo            = new GenericRepository<T>(_Connection, _GeneralContext);
            Repo.Delete(Entity);
        }

        public IEnumerable<T>   GetList <T>         (object Param = null, IDbTransaction Trans = null) where T : class
        {
            return new GenericRepository<T>(_Connection,_GeneralContext).GetList(Param,Trans);
        }
        public T                GetItem <T>         (object Param = null, IDbTransaction Trans = null) where T : class
        {
            return new GenericRepository<T>(_Connection, _GeneralContext).GetItem(Param,Trans);
        }

        public bool             HaveCircular<T>     (object Param = null, IDbTransaction Trans = null)
            where T : class, IEntityUsage
        {
            var repo = new GenericRepository<T>(_Connection, _GeneralContext);
            return repo.HaveEntityCircular(Param, Trans) ;
        }
        public V                GenerateCode<T, V>  (V Default, object Param = null, IDbTransaction Trans = null) where T : class,ICodeEntity
        {
            return new GenericRepository<T>(_Connection, _GeneralContext).GenCode<V>(Default,Param,Trans);
        }

        public bool             IsCodeUnique<T>     (object Param = null, IDbTransaction Trans = null) where T : class, ICodeEntity
        {
            return new GenericRepository<T>(_Connection, _GeneralContext).IsCodeUnique(Param, Trans);
        }

        #endregion
    }
}
