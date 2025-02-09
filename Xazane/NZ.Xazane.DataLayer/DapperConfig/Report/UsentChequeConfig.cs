using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class UsentChequeConfig : DapperEntityConfiguration<UsentCheque>
    {
        public UsentChequeConfig()
        {
            SetList(@"
SELECT 
tac.ID,
tad.kind,
tac.mablaq,
tad.serial,
dd.PersianStr,
tac.tarikh_sar_resid,
tad.ID							AS ID_DP,
ddSarResid.PersianStr			AS PersianUsanceStr,
LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
LTRIM(RTRIM(tac.babat))			AS babat,
LTRIM(RTRIM(ta.title))			AS CustomerTitle,
LTRIM(RTRIM(tb.title))			AS BankTitle,
LTRIM(RTRIM(thx.title))			AS PayAccountTitle


FROM            Xazane.tbl_Amaliat_Check    AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID = tac.FK_DP
INNER JOIN		Base.tbl_Ashxas				AS ta			ON tad.FK_ShaXs = ta.ID
INNER JOIN		General.DimDate				AS dd			ON dd.GregorianDate = tad.tarikh
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank = tb.ID
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID = tac.FK_Hesab_Pardaxtani 

where tac.Kind_Vaziat IS NULL AND DATEDIFF(DAY,GETDATE(),tac.tarikh_sar_resid) ");
        }
    }

}
