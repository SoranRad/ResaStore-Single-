using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.General.DataLayer;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.General.Business
{
    public class UnitOfWork
    {
        #region Fields
        private DbConnection    _Connection;
        private GeneralContext  _Context;

        private Dictionary<Type, object> _Repositories = new Dictionary<Type, object>();
        #endregion
        #region Constructor
        public UnitOfWork(DbConnection Connection)
        {
            _Connection = Connection;
            _Context = new GeneralContext(Connection, false);
        }
        #endregion
        #region Methods
        public IGenericRepository<T>    Repository<T>   ()where T : class
        {
            if (_Repositories.Keys.Contains(typeof(T)))
            {
                return _Repositories[typeof(T)] as IGenericRepository<T>;
            }
            IGenericRepository<T> repo = new GenericRepository<T>(_Context);
            _Repositories.Add(typeof(T), repo);
            return repo;
        }
        public void                     SaveChanges     ()
        {
            _Context.SaveChanges();
        }
        public void                     Dispose         ()
        {
            _Connection.Dispose();
            _Context.Dispose();
        }
        #endregion

    }
}
