using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.Model.Interfaces
{
    public interface IDpRepository
    {
        void                        Save                (DPOperation Item);
        void                        Delete              (long ID);
        IEnumerable<DPOperation>    GetList             (object Param);
        DPOperation                 GetItem             (long ID);
        int                         GetMaxSerial        (object Param);
        bool                        IsCodeUnique        (object Param);
        IEnumerable<T>              GetView<T>          (object Param);
        DPOperation                 GetItemByFactorID   (long IdFactor);

        //IEnumerable<T>              GetView<T>      (object Param, string WhereClause);
        //IEnumerable<T>              GetSingleView<T>(object Param,string WhereClause);
    }
}
