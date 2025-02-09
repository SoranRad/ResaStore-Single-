using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class PreFactorConfiguration : DapperEntityConfiguration<PreSaleFactor>
    {
        public PreFactorConfiguration()
        {
            SetList(@"
SELECT 
tat.ID,
tat.Serial,
tat.mablaq				,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianDayInMonth,

tatd.mablaq_takhfif ,
tatd.Darsad_Takhfif,
tatd.mablaq_Maliat ,
tatd.Darsad_Maliat ,
tatd.Ezafat,
Ltrim(Rtrim(ta.title)) AS Customer

 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN Base.tbl_Ashxas		AS ta	ON ta.ID			= tat.FK_AshXas_ID 
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd ON tatd.ID = tat.ID


WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year AND 
(dd.PersianMonthNo=@Month OR @Month=13)

");
        }
    }
}
