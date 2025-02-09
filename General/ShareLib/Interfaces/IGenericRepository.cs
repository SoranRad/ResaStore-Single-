using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
    public interface IGenericRepository<T> 
    {
        void                Save                    (T entity);
        void                Delete                  (T entity);
        T                   GetItem                 (object Param = null, IDbTransaction Trans = null);
        IEnumerable<T>      GetList                 (object Param = null, IDbTransaction Trans = null);
        V                   GenCode<V>              (V Default, object Param = null, IDbTransaction Trans = null);//where V : ICodeEntity;
        bool                IsCodeUnique            (object Param = null, IDbTransaction Trans = null);//where V : ICodeEntity;
        bool                HaveEntityCircular      (object Param = null, IDbTransaction Trans = null);//where V : IEntityUsage;

    }
}
