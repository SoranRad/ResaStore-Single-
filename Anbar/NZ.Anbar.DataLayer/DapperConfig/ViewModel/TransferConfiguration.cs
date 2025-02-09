using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class TransferConfiguration:DapperEntityConfiguration<TransferFactor>
    {
        public TransferConfiguration()
        {
            this.SetList(@"
SELECT 
tat.ID,
tat.Serial,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianDayInMonth,
Riz.ItemCount
 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN (
SELECT tar.FK_Title, COUNT(tar.ID) AS ItemCount FROM Anbar.tbl_Amaliat_Riz AS tar
GROUP BY tar.FK_Title
) AS Riz ON Riz.FK_Title = tat.ID

WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year AND 
(dd.PersianMonthNo=@Month OR @Month=13)
");
        }
    }
}
