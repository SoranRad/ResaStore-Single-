using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.General.DataLayer.DapperConfig
{
    public class ActiveConfig: DapperEntityConfiguration<Activation>
    {
        public ActiveConfig()
        {
            SetList(@"
SELECT 
		tc.ID ,
       LTRIM(RTRIM(tc.ActiveString )) as ActiveString,
       LTRIM(RTRIM(tc.LastVersion  )) as LastVersion,
       LTRIM(RTRIM(tc.ModuleList  )) as ModuleList
	   
	   
	   FROM General.tbl_Config AS tc

");
        }
    }
}
