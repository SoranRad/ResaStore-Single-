using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.Configure.ViewModel
{
    public class DeficitAdditionDapperConfig: DapperEntityConfiguration<DeficitAdditionList>
    {
        public DeficitAdditionDapperConfig()
        {
            this.SetList(@"
SELECT tad.ID ,
       tad.serial ,
       LTRIM(RTRIM(tad.sharh )) AS sharh,
       tax.mablaq ,
	   dd.PersianMonthNo,
	   dd.PersianDayInMonth,
	   dd.PersianStr,
	   LTRIM( RTRIM(thxBad.title)) AS DebitTitle,
	   LTRIM(RTRIM(thxBas.title)) AS CreditTitle,
	   LTRIM(RTRIM(ta.title)) AS CustomerTitle

FROM Xazane.tbl_Amaliat_DP					AS tad
INNER JOIN Xazane.tbl_Amaliat_Xazaneh		AS tax		ON tax.FK_DP		= tad.ID
INNER JOIN General.DimDate					AS dd		ON dd.GregorianDate = tad.tarikh
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxBad	ON thxBad.ID		= tax.FK_Xazaneh_Bad
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxBas	ON thxBas.ID		= tax.FK_Xazaneh_Bas
INNER JOIN Base.tbl_Ashxas					AS ta		ON tad.FK_ShaXs		= ta.ID

WHERE tad.kind=@Kind AND tad.FK_Salmali=@Year  AND (dd.PersianMonthNo = @Month OR @Month=13)

");
        }
    }
}
