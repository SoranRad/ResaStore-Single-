using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace Nz.Machine.DataLayer.Repo
{
    public class ReportRepository : IReportRepository
    {
        #region Fields
        private DbConnection _Connection;
        #endregion
        #region Constructor
        public ReportRepository(DbConnection Connection)
        {
            _Connection = Connection;
        }
        #endregion
        #region Methods
        public IEnumerable<T> List<T>(object Params, string WhereClauseAppend)
        {
            Assembly asm = Assembly.Load(this.GetType().Assembly.GetName());
            var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T>));
            var instance = (DapperEntityConfiguration<T>)Activator.CreateInstance(t);
            var SqlStr = instance.GetList;


            if (!string.IsNullOrEmpty(WhereClauseAppend))
                SqlStr += WhereClauseAppend;

            using (var con = ConnectionManager.Create())
            {
                return con
                    .Query<T>
                        (SqlStr, Params);
            }
        }

        public T Item<T>(object Params, string WhereClauseAppend)
        {
            Assembly asm = Assembly.Load(this.GetType().Assembly.GetName());
            var t = asm.GetTypes().FirstOrDefault(x => x.BaseType == typeof(DapperEntityConfiguration<T>));
            var instance = (DapperEntityConfiguration<T>)Activator.CreateInstance(t);
            var SqlStr = instance.GetItem;



            if (!string.IsNullOrEmpty(WhereClauseAppend))
                SqlStr += WhereClauseAppend;


            using (var con = ConnectionManager.Create())
            {
                return con
                    .QueryFirstOrDefault<T>
                        (SqlStr, Params);
            }
        }
        #endregion
    }
}
