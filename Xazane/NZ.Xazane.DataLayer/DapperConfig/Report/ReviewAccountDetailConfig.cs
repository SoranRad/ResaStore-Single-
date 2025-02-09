using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    class ReviewAccountDetailConfig : DapperEntityConfiguration<ReviewAccountDetail>
    {
        public ReviewAccountDetailConfig()
        {
            SetList(@"

SELECT 

(CASE WHEN tax.FK_Xazaneh_Bad = @ID 
THEN tax.mablaq
ELSE -tax.mablaq 
END)  AS mablaq,
tax.ID,
tad.ID		AS MainID,
(1)			AS RowKind,
tax.kind	AS SubKind,
tad.kind	AS MainKind,

LTRIM(RTRIM(tax.sharh))		AS SubText,
LTRIM(RTRIM(tad.sharh))		AS MainText,
(CASE WHEN tax.FK_Xazaneh_Bad = @ID 
THEN LTRIM(RTRIM(thxBas.title))
ELSE RTRIM(LTRIM(thxBad.title)) 
END )						AS AccountTitle,
LTRIM(RTRIM(ta.title))		AS People,
(CASE WHEN tax.FK_DP IS NULL 
THEN tax.serial 
ELSE tad.serial END)		AS Serial,
CAST(ISNULL(tax.serialPeygiri,0) AS NCHAR(50))			AS Serial2,
(CASE WHEN tax.tarikh IS NULL 
THEN ddMain.PersianStr 
ELSE ddSub.PersianStr 
END )						AS PersianStr


FROM Xazane.tbl_Amaliat_Xazaneh				AS tax
LEFT OUTER JOIN Xazane.tbl_Amaliat_DP		AS tad		ON tad.ID			= tax.FK_DP
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxBad	ON thxBad.ID		= tax.FK_Xazaneh_Bad
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxBas	ON thxBas.ID		= tax.FK_Xazaneh_Bas
LEFT OUTER JOIN Base.tbl_Ashxas				AS ta		ON tad.FK_ShaXs		= ta.ID
LEFT OUTER JOIN General.DimDate				AS ddMain	ON tad.tarikh		= ddMain.GregorianDate
LEFT OUTER JOIN General.DimDate				AS ddSub	ON tax.tarikh		= ddSub.GregorianDate

WHERE 
	tax.FK_Salmali = @Year
AND (tax.FK_Xazaneh_Bad = @ID OR tax.FK_Xazaneh_Bas = @ID)
AND (tax.tarikh=@Date OR tad.tarikh =@Date OR @Date IS NULL)


UNION ALL

SELECT 

(CASE WHEN tac.FK_Hesab_Pardaxtani = @ID 
THEN -tac.mablaq
ELSE tac.mablaq 
END)						AS mablaq,
tac.ID,
tad.ID						AS MainID,
(2)							AS RowKind,
tac.Kind_Vaziat				AS SubKind,
tad.kind					AS MainKind,

LTRIM(RTRIM(tac.babat))		AS SubText,
LTRIM(RTRIM(tad.sharh))		AS MainText,
N''							AS AccountTitle,
LTRIM(RTRIM(ta.title))		AS People,
tad.serial					AS Serial,
tac.shomare_check			AS Serial2,
dd.PersianStr


FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad	ON tad.ID	= tac.FK_DP
LEFT OUTER JOIN Base.tbl_Ashxas				AS ta	ON ta.ID	= tad.FK_ShaXs
LEFT OUTER JOIN General.DimDate				AS dd	ON tac.Tarix_Vaziat = dd.GregorianDate

WHERE 
	(tac.FK_Hesab_Pardaxtani =@ID OR tac.FK_Xazaneh_Vaziat =@ID)
AND	tac.FK_Salmali_Vaziat	=@Year
AND tac.Kind_Vaziat			=@Kind
AND (tac.Tarix_Vaziat		=@Date  OR @Date IS NULL)
");
        }
    }
}
