using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class StorageConfig : DapperEntityConfiguration<Storage>
    {
        public StorageConfig()
        {
            SetList(@"
SELECT 
	   tba.ID ,
       tba.Code ,
       LTRIM(RTRIM(tba.Title)) AS Title ,
       tba.Kind ,
       tba.Is_Disable 
	   
FROM Base.tbl_Base_Anbar AS tba
");
        }
    }
}
