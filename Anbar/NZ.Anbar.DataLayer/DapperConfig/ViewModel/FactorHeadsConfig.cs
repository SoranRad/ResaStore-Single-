using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class FactorHeadsConfig : DapperEntityConfiguration<FactorHeads>
    {
        public FactorHeadsConfig()
        {
            SetList(@"
    SELECT 
	   tat.ID,
       tat.Serial,
       tat.mablaq,
       LTRIM(RTRIM(tat.sharh)) AS sharh,
       dd.PersianStr,
       LTRIM(RTRIM(ta.title)) AS Customer,
       tat.kind

    FROM Anbar.tbl_Amaliat_Title AS tat
    INNER JOIN General.DimDate AS dd
        ON dd.GregorianDate = tat.tarikh 
    LEFT OUTER JOIN Base.tbl_Ashxas AS ta
        ON ta.ID = tat.FK_AshXas_ID

WHERE tat.kind >= 11 AND tat.kind < 50 AND tat.FK_Salmali = @Year

");
        }
    }
}
