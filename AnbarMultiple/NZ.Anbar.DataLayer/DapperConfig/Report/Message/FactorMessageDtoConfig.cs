using Nz.Anbar.Model.Report.Sms;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Message
{
	internal class FactorMessageDtoConfig : DapperEntityConfiguration<FactorMessageDto>
	{
		public FactorMessageDtoConfig()
		{
			SetList(@"

SELECT tat.ID,
       tat.Serial,
       tat.mablaq				AS Price,
       dd.PersianStr			AS Date,
       LTRIM(RTRIM(ta.title))	AS Customer,
	   LTRIM(RTRIM(ta.mobile))	AS Mobile,
       dd.PersianStr			AS Tasvieh
 

FROM 
Anbar.tbl_Amaliat_Title                         AS tat  
LEFT OUTER JOIN General.DimDate                 AS dd           ON dd.GregorianDate             = tat.tarikh
LEFT OUTER JOIN Base.tbl_Ashxas                 AS ta           ON ta.ID                        = tat.FK_AshXas_ID
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail  AS tatd         ON tatd.ID                      = tat.ID
LEFT OUTER JOIN General.DimDate                 AS ddTasvieh    ON ddTasvieh.GregorianDate      = tatd.tarikh_etebar  

");
		}
	}
}
