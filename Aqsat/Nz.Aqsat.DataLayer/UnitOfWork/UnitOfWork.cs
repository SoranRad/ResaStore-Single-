using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Aqsat.DataLayer.Context;
using Nz.Bar.DataLayer.Context;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace Nz.Aqsat.DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private DbConnection                _Connection;
        private AqsatContext                _Context;
        private Dictionary<Type, object>    _Repositories = new Dictionary<Type, object>();
        #endregion
        #region Constructor
        public UnitOfWork(DbConnection Connection)
        {
            _Connection     = Connection;
            _Context        = new AqsatContext(Connection,false);
        }
        #endregion
        #region Methods
        public IGenericRepository<T>    Repository<T>   () where T : class
        {
            if (_Repositories.Keys.Contains(typeof(T)) == true)
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
            _Connection .Dispose();
            _Context    .Dispose();
        }
        #endregion
    }
}
