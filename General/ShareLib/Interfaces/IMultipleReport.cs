using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
    public interface IMultipleReport
    {
        Tuple<T1, T2>                   Multiple    <T1, T2>                   (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend=null);
        Tuple<T1, T2, T3>               Multiple    <T1, T2 ,T3>               (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend=null);
        Tuple<T1, T2, T3, T4>           Multiple    <T1, T2 ,T3,T4>            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend=null);
        Tuple<T1, T2, T3, T4, T5>       Multiple    <T1, T2 ,T3,T4,T5>         (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend=null);
        Tuple<T1, T2, T3, T4, T5,T6>    Multiple    <T1, T2 ,T3,T4,T5,T6>      (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend =null);


        Tuple<IEnumerable<T1>, IEnumerable<T2>>                                                                         MultipleList    <T1, T2>                    (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>>                                                        MultipleList    <T1, T2, T3>                (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>>                                       MultipleList    <T1, T2, T3, T4>            (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>>                      MultipleList    <T1, T2, T3, T4,T5>         (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null);
        Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>>     MultipleList    <T1, T2, T3, T4,T5,T6>      (Enums.NzMultipleReportKind FetchSQL, object Params, string WhereClauseAppend = null);

    }
}
