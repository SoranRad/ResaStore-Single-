using Nz.Site.Model.Models;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.DataLayer.DapperConfig.Report
{
	public class SyncOrdersInFactorsConfig : DapperEntityConfiguration<SyncOrdersInFactors>
	{
		public SyncOrdersInFactorsConfig()
		{
			SetList(@"
SELECT 

	tat.Serial,
	tatd.ID,
	tat.tarikh ,
	tatd.WebSiteId

FROM        Anbar.tbl_Amaliat_Title_Detail  AS tatd 
INNER JOIN  Anbar.tbl_Amaliat_Title         AS tat  on tat.ID = tatd.ID
WHERE tatd.WebSiteId IS NOT NULL AND tatd.WebSiteId IN ");
		}

	}
}
