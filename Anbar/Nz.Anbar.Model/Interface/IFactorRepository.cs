using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Model;

namespace Nz.Anbar.Model.Interface
{
    public interface IFactorRepository
    {
        void                        Save            (FactorHead Factor,bool AutoSerial=true);
        void                        Delete          (long       ID);
        IEnumerable<FactorHead>     GetList         (object     Param);
        FactorHead                  GetItem         (long       ID);
        int                         GetMaxSerial    (object     Param);
        bool                        IsCodeUnique    (object     Param);
        PrintFactor                 GetPrint        (long       ID);
        IEnumerable<PrintFactor>    GetAllPrint     (List<long> List);
        void                        FixFifoKardex   ();
        void FixRemain();
    }
}
