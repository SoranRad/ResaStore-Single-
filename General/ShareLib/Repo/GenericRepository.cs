using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Utils;
using System.Data.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Migrations;
using Dapper;
using MS_Control;

namespace ShareLib.Models
{
    public class GenericRepository <T> : IGenericRepository<T> where T : class
    {
        #region Fields
        private     DbContext           _Context;
        private     DbSet<T>            _Table;
        private     DbConnection        _Connection;
        #endregion
        #region Fields
        public      GenericRepository   (DbContext Context)
        {
            _Connection     = ConnectionManager.Create();
            _Context        = Context;
            _Table          = _Context.Set<T>(); 
        }
        public      GenericRepository   (DbConnection Connection, DbContext Context)
        {
            _Connection = Connection;
            _Context    = Context;
            _Table      = _Context.Set<T>();
        }
        #endregion
        #region Methods

        public void             Delete              (T Entity)
        {
            if (Entity != null  )
            {
                //_Context
                //_Context.ChangeTracker.Entries().MSZ_ForEach(x =>
                //{
                //    _Context.Entry(x).State = EntityState.Detached;
                //});
                var s = _Context.Entry(Entity).State;


                _Context.Entry(Entity).State = EntityState.Deleted;
                _Context.SaveChanges();
            }
        }
        public void             Save                (T Entity)
        {
            _Table.AddOrUpdate(Entity);
            _Context.SaveChanges();
        }

        public T                GetItem             (object Param = null, IDbTransaction Trans = null)
        {
            if (typeof(T).GetInterface("ISqlQueryMaker") == null)
                return default(T);

            var SqlMaker = (ISqlQueryMaker) Activator.CreateInstance<T>();


            using (var con = ConnectionManager.Create())
            {
                return
                        con
                            .QuerySingleOrDefault<T>
                                (SqlMaker?.GetItem(), Param, Trans);
            }
        }
        public IEnumerable<T>   GetList             (object Param = null, IDbTransaction Trans = null)
        {
            if (typeof(T).GetInterface("ISqlQueryMaker") == null)
                return null;

            var SqlMaker = (ISqlQueryMaker) Activator.CreateInstance<T>();

            using (var con = ConnectionManager.Create())
            {
                return
                    con
                        .Query<T>
                            (SqlMaker.GetList(), Param, Trans);
            }
        }


        public V                GenCode<V>          (V Default, object Param = null, IDbTransaction Trans = null) //where V : ICodeEntity
        {
            if (typeof(T).GetInterface("ICodeEntity") == null) 
                throw new Exception("کد قابل شناسایی نیست");

            var SqlMaker = (ICodeEntity)Activator.CreateInstance<T>();

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<V>
                    (SqlMaker.GenerateCode(), Param, Trans);
                return max == null ? Default : max;
            }

            
        }
        public bool             IsCodeUnique        (object Param = null, IDbTransaction Trans = null) //where V : ICodeEntity
        {
            if (typeof(T).GetInterface("ICodeEntity") == null)
                throw new Exception("کد قابل شناسایی نیست");

            var SqlMaker = (ICodeEntity)Activator.CreateInstance<T>();

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .ExecuteScalar<int>
                    (SqlMaker.UniqueCode(), Param, Trans);
                return max == 0;
            }

            

        }

        public bool             HaveEntityCircular  (object Param = null, IDbTransaction Trans = null) 
        {
            if (typeof(T).GetInterface("IEntityUsage") == null)
                throw new Exception("کد قابل شناسایی نیست");

            var SqlMaker = (IEntityUsage)Activator.CreateInstance<T>();

            if (_Connection.State == ConnectionState.Closed)
                _Connection.Open();

            using (var con = ConnectionManager.Create())
            {
                var max = con
                    .QueryFirstOrDefault<T>
                        (SqlMaker.CircularQuery(), Param, Trans);
                return max != null;
            }
        }
        #endregion
    }
}
