using Nz.Anbar.Model.Report;
using NZ.Anbar.Model;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig
{
	public class FactorDetailsConfig : DapperEntityConfiguration<FactorDetails>
	{
		private static string Item          = $@"
SELECT  
tu.title        AS UserCreate,
tu_Edit.title   AS UserEdit,
tat.tarikh_add,
tatd.tarikh_edit

FROM                    Anbar.tbl_Amaliat_Title         AS tat
LEFT OUTER JOIN         Anbar.tbl_Amaliat_Title_Detail  AS tatd         ON tat.ID = tatd.ID
LEFT OUTER JOIN         General.tbl_User                AS tu           ON tu.ID= tat.FK_User_Add
LEFT OUTER JOIN         General.tbl_User                AS tu_Edit      ON tu_Edit.ID= tatd.FK_User_Edit

where tat.ID =@ID
";
		public FactorDetailsConfig()
		{
			this.SetItem(Item);
		}
	}
}
