using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.PishFrosh
{
	internal class FactorVaHavalePishFroshYekShaxsConfig : DapperEntityConfiguration<FactorVaHavalePishFroshYekShaxs>
	{
		public FactorVaHavalePishFroshYekShaxsConfig()
		{
			SetList(@"

SELECT 

tat.ID,
tat.Serial,
dd.PersianStr,
tat.kind,
LTRIM(RTRIM(tat.sharh)) AS sharh,
tat.mablaq


FROM Anbar.tbl_Amaliat_Title     AS tat
LEFT OUTER JOIN General.DimDate AS dd ON  dd.GregorianDate = tat.tarikh

WHERE (tat.kind = 50 AND tat.NoRemainEffect = 1)
AND (tat.FK_Salmali = @Year OR @Year IS NULL)
AND tat.FK_Anbar_Az = @Anbar
AND tat.FK_AshXas_ID =@People


UNION ALL

SELECT 

tat.ID,
tat.Serial,
dd.PersianStr,
tat.kind,
LTRIM(RTRIM(tat.sharh)) AS sharh,
tat.mablaq


FROM Anbar.tbl_Amaliat_Title                AS tat
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title     AS tat_pish_frosh   ON tat.FK_Mabna = tat_pish_frosh.ID
LEFT OUTER JOIN General.DimDate             AS dd               ON  dd.GregorianDate = tat.tarikh

WHERE (tat.kind = 56 )
AND (tat.FK_Salmali = @Year OR @Year IS NULL)
AND tat.FK_Anbar_Az = @Anbar
AND (tat_pish_frosh.FK_AshXas_ID =@People OR tat.FK_Tahvil_Girande = @People )

");
		}
	}
}
