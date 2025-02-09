using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class SarResidCheque:DapperEntityConfiguration<SarResidCheque>
    {
        public SarResidCheque()
        {
            SetList(@"
SELECT 

tac.ID,
tad.ID  AS ID_DP,
tac.Kind_Vaziat,
LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
tac.mablaq,
ddSarResid.PersianStr AS PersianUsanceStr,
ddSarResid.PersianMonthNo,
ddSarResid.PersianDayInMonth,
LTRIM(RTRIM(tac.babat)) AS babat,
tac.tarikh_sar_resid,


LTRIM(RTRIM(ta.title)) AS CustomerTitle,
LTRIM(RTRIM(tb.title)) AS BankTitle,
LTRIM(RTRIM(thx.title)) AS PayAccountTitle ,

(CASE WHEN tac.tarikh_sar_resid IS NULL THEN NULL 
ELSE 
CAST((DATEDIFF(DAY,GETDATE(), tac.tarikh_sar_resid)) AS INT)
End) DayRemaind


FROM Xazane.tbl_Amaliat_Check AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP
LEFT OUTER JOIN General.DimDate AS ddDP ON ddDP.GregorianDate = tad.tarikh
LEFT OUTER JOIN General.DimDate AS ddSarResid ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
INNER JOIN Base.tbl_Ashxas AS ta ON tad.FK_ShaXs = ta.ID
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank = tb.ID
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID = tac.FK_Hesab_Pardaxtani  
");
        }
    }
}
