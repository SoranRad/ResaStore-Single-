using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models.Report;

namespace NZ.General.DataLayer.DapperConfig
{
	public class HazineDapperConfig : DapperEntityConfiguration<Hazine>
	{
		public HazineDapperConfig()
		{
			SetList(@"
	SELECT  
        thx.ID ,
        thx.Code ,
        Ltrim(Rtrim(thx.title))		AS title

    FROM Xazane.tbl_Hesab_Xazaneh	AS thx
    WHERE thx.Kind = @Kind 

");
		}
	}
}
