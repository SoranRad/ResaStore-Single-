using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class ChequeListConfig : DapperEntityConfiguration<ChequeList>
    {
        public ChequeListConfig()
        {
            this.SetList(@"
SELECT 
tac.ID,
tad.ID  AS ID_DP,
tac.Kind_Vaziat,
LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
tac.mablaq,
ddSarResid.PersianStr AS PersianUsanceStr,
LTRIM(RTRIM(tac.babat)) AS babat,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianDayInMonth,
tac.tarikh_sar_resid,

ddState.PersianStr AS StateDate,
LTRIM(RTRIM(ta.title)) AS CustomerTitle,
LTRIM(RTRIM(tb.title)) AS BankTitle,
LTRIM(RTRIM(thx.title)) AS PayAccountTitle

FROM Xazane.tbl_Amaliat_Check AS tac

INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID = tac.FK_DP
INNER JOIN		Base.tbl_Ashxas				AS ta			ON tad.FK_ShaXs = ta.ID
INNER JOIN		General.DimDate				AS dd			ON dd.GregorianDate = tad.tarikh
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank = tb.ID
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID = tac.FK_Hesab_Pardaxtani 
LEFT OUTER JOIN General.DimDate				AS ddState		ON tac.Tarix_Vaziat = ddState.GregorianDate

where 
");
        }
    }
}
