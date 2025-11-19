using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;
using ShareLib.Utils;
using System.Data;
using NZ.Anbar.DataLayer.Context;
using NZ.Anbar.DataLayer.UnitOfWork;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace NZ.Anbar.Business
{
    public class Manager
    {
        #region Fields
        private         DbConnection    _Connection;
        private         IUnitOfWork     _UnitOfWork;
        #endregion
        #region Constructor
        public          Manager     ()
        {
            _Connection     = ConnectionManager.Create();
            _UnitOfWork     = new UnitOfWork        (_Connection);
        }
        public          Manager     (DbConnection Connection)
        {
            _Connection     = Connection;
            _UnitOfWork     = new UnitOfWork(_Connection);
        }
        #endregion
        #region Connection
        public DbConnection Connection
        {
            get => _Connection;
            set => _Connection = value;
        }
        #endregion
        #region Methods
        public void             Save    <T>         (T Entity) where T : class
        {
            var repo = _UnitOfWork.Repository<T>();
            repo.Save(Entity);
            _UnitOfWork.SaveChanges();
        }
        public void             Delete  <T>         (T Entity) where T : class
        {
            var repo = _UnitOfWork.Repository<T>();
            repo.Delete(Entity);
            _UnitOfWork.SaveChanges();
        }
        public IEnumerable<T>   GetList <T>         (object Param = null, IDbTransaction Trans = null) where T : class
        {

            return _UnitOfWork.Repository<T>().GetList(Param, Trans);
        }
        public T                GetItem <T>         (object Param = null, IDbTransaction Trans = null) where T : class
        {
            return _UnitOfWork.Repository<T>().GetItem(Param, Trans);
        }
        public bool             HaveCircular<T>     (object Param = null, IDbTransaction Trans = null)
            where T : class, IEntityUsage
        {
            return _UnitOfWork.Repository<T>().HaveEntityCircular(Param, Trans) ;
        }
        public V                GenerateCode<T, V>  (V Default, object Param = null, IDbTransaction Trans = null) where T : class,ICodeEntity
        {
            return _UnitOfWork.Repository<T>().GenCode<V>(Default,Param,Trans);
        }
        public bool             IsCodeUnique<T>     (object Param = null, IDbTransaction Trans = null) where T : class, ICodeEntity
        {
            return _UnitOfWork.Repository<T>().IsCodeUnique(Param, Trans);
        }

        #endregion

    }
}
