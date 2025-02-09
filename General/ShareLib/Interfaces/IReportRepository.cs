using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
    public interface IReportRepository
    {
        IEnumerable<T>  List        <T>     (object Params, string WhereClauseAppend);
        T               Item        <T>     (object Params, string WhereClauseAppend);

    }
}
