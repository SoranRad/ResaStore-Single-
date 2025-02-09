using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class PrintTranferConfiguration : DapperEntityConfiguration<PrintTransfer>
    {
        public PrintTranferConfiguration()
        {
            this.SetList(@"
SELECT 
tat.ID,
tat.Serial,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianDayInMonth,
tar.FK_Kala,
tar.meqdar,
LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
LTRIM(RTRIM(tv.title))  AS UnitTitle

 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN Anbar.tbl_Amaliat_Riz	AS tar	ON tar.FK_Title		= tat.ID
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tkx.Code			= tar.FK_Kala
INNER JOIN Base.tbl_Vahed			AS tv	ON tv.ID			= tkx.FK_Vahed



");
        }
    }
}
