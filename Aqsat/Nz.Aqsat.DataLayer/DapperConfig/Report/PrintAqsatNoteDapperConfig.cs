using Nz.Aqsat.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Report
{
    public class PrintAqsatNoteDapperConfig : DapperEntityConfiguration<PrintAqsatNote>
	{
		public PrintAqsatNoteDapperConfig()
		{
			SetList(@"
SELECT 
 
tam.ID,
tam.FK_Salmali,
LTRIM(RTRIM(ttShaxs.title))     As ShaxsTitle,
LTRIM(RTRIM(ttShaxs.mobile))    As ShaxsMobile,
LTRIM(RTRIM(ttZamen.title))     As ZamenTitle,
LTRIM(RTRIM(ttZamen.mobile))    As ZamenMobile,
LTRIM(RTRIM(tak.Title))         As NohTitle,
tam.Serial,
ttSodur.PersianStr              AS PersianTarixSodur,
ttStart.PersianStr              AS PersianStartDate,
tam.DoreQest,
tam.RoundMablaq,
tam.MablaqAqsat,
tam.MablaqPishpardaxt,
tam.MablaqMandeAqsat,
tam.DarsadSoud,
tam.MablaqSoud,
tam.MablaqFinalAqsat,
tam.StartDate,
tam.TedadAqsat,
LTRIM(RTRIM(tam.Sharh))         AS Sharh,
tar.ID                          AS Id_Radif,
tar.Radif, 
tar.MablaqQest,
ddSarResid.PersianStr           AS PersianTarixQest

FROM                Aqsat.tbl_Aqsat_Riz     tar
INNER JOIN          General.DimDate         ddSarResid  ON     tar.tarixQest    = ddSarResid.GregorianDate
INNER JOIN          Aqsat.tbl_Aqsat_Main    tam         ON     tar.FK_Main      = tam.ID
INNER JOIN          Base.tbl_Ashxas         ttShaxs     ON     tam.FK_Shaxs     = ttShaxs.ID
LEFT OUTER JOIN     Base.tbl_Ashxas         ttZamen     ON     tam.FK_Zamen     = ttZamen.ID
INNER JOIN          Aqsat.tbl_Aqsat_Kind    tak         ON     tak.ID           = tam.FK_Noh
INNER JOIN          General.DimDate         ttSodur     ON     ttSodur.GregorianDate = tam.Tarikh
INNER JOIN          General.DimDate         ttStart     ON     ttStart.GregorianDate = tam.StartDate

WHERE

");
		}
    }
}
