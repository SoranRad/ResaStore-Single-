using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class AnalyzeChequeDetailConfig : DapperEntityConfiguration<AnalyzeChequeDetail>
    {
        public AnalyzeChequeDetailConfig()
        {
            SetList(@"
SELECT 

tac.ID ,
tac.mablaq,
tad.serial,
tad.ID							AS IDMain,
ddDP.PersianStr					AS DpDate,
ddSarResid.PersianStr			AS UsentDate,
ddVaziat.PersianStr				AS StateDate,
LTRIM(RTRIM(ta.title))			AS People,
LTRIM(RTRIM(taVagozari.title))	AS AssignPeople,
LTRIM(RTRIM(tac.babat))			AS Sharh,
LTRIM(RTRIM(tac.Sharh_Vaziat))	AS SharhVaziat,
LTRIM(RTRIM(tb.title))			AS BankTitle,
LTRIM(RTRIM(thxAmel.title))		AS DPAccount,
LTRIM(RTRIM(thxVosul.title))	AS StateAccount,
tad.kind						AS Kind,
tac.Kind_Vaziat

FROM				Xazane.tbl_Amaliat_Check		AS tac 
INNER JOIN			Xazane.tbl_Amaliat_DP			AS tad			ON tad.ID					= tac.FK_DP
INNER JOIN			Base.tbl_Ashxas					AS ta			ON tad.FK_ShaXs				= ta.ID
LEFT OUTER JOIN		Base.tbl_Ashxas					AS taVagozari	ON tac.FK_Shaxs_Vaziat		= taVagozari.ID 
LEFT OUTER JOIN		General.DimDate					AS ddDP			ON tad.tarikh				= ddDP.GregorianDate
LEFT OUTER JOIN		General.DimDate					AS ddSarResid	ON tac.tarikh_sar_resid		= ddSarResid.GregorianDate
LEFT OUTER JOIN		General.DimDate					AS ddVaziat		ON tac.Tarix_Vaziat			= ddVaziat.GregorianDate
LEFT OUTER JOIN		Xazane.tbl_Hesab_Xazaneh		AS thxAmel		ON thxAmel.ID				= tac.FK_Hesab_Pardaxtani
LEFT OUTER JOIN		Xazane.tbl_Hesab_Xazaneh		AS thxVosul		ON thxVosul.ID				= tac.FK_Xazaneh_Vaziat
LEFT OUTER JOIN		Base.tbl_Bank					AS tb			ON tb.ID					= tac.FK_Bank

WHERE 


");
        }
    }
}
