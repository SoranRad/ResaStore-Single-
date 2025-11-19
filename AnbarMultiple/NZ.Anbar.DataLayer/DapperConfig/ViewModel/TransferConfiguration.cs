using NZ.Anbar.Model;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class TransferConfiguration:DapperEntityConfiguration<TransferFactor>
    {
        public TransferConfiguration()
        {
            this.SetList($@"
SELECT 
tat.ID,
tat.Serial,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianDayInMonth,
LTRIM(RTRIM(tba_az.Title))	AS AnbarAz,
LTRIM(RTRIM(tba_be.Title))	AS AnbarBe,
LTRIM(RTRIM(ta.Title))	AS Tahvil_Girande,
Riz.ItemCount
 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN Base.tbl_Base_Anbar AS tba_az  ON tat.FK_Anbar_Az = tba_az.ID
LEFT OUTER JOIN Base.tbl_Base_Anbar AS tba_be  ON tat.FK_Anbar_Be = tba_be.ID
LEFT OUTER JOIN Base.tbl_Ashxas AS ta ON tat.FK_Tahvil_Girande = ta.ID
INNER JOIN (
SELECT tar.FK_Title, COUNT(tar.ID) AS ItemCount FROM Anbar.tbl_Amaliat_Riz AS tar
GROUP BY tar.FK_Title
) AS Riz ON Riz.FK_Title = tat.ID

WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year AND (dd.PersianMonthNo=@Month OR @Month=13) AND tat.{nameof(FactorHead.FK_Anbar_Az)}=@Anbar
");
        }
    }
}
