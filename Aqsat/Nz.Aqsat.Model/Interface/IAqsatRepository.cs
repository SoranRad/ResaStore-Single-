using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Aqsat.Model.Models;

namespace Nz.Aqsat.Model.Interface
{
    public interface IAqsatRepository
    {
        void                        Save            (Aqsat_Main Factor,bool AutoSerial=true);
        void                        Delete          (long       ID);
        IEnumerable<Aqsat_Main>     GetList         (object     Param);
        Aqsat_Main                  GetItem         (long       ID);
        int                         GetMaxSerial    (object     Param);
        bool                        IsCodeUnique    (object     Param);
        //PrintFactor                 GetPrint        (long       ID);
        //IEnumerable<PrintFactor>    GetAllPrint     (List<long> List);
         
    }
}
