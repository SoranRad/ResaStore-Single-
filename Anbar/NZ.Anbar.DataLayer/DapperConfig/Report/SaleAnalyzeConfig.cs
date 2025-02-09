using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class SaleAnalyzeConfig : DapperEntityConfiguration<SaleAnalyze>
    {
        public SaleAnalyzeConfig()
        {
            SetList(@"
SELECT 
dd.PersianStr , 
tat.kind					AS KindHead,
tkx.Code ,
LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
LTRIM(RTRIM(tv.title))		AS UnitTitle,
(CASE WHEN tat.kind = @KindFrosh THEN  tar.meqdar ELSE -tar.meqdar END ) AS meqdar ,
tar.nerkh ,
tar.nerkh_2 ,
tar.takhfif ,
tar.takhfif_darsad ,
(CASE WHEN tat.kind = @KindFrosh THEN tar.mablaq ELSE -tar.mablaq END ) AS mablaq,

(CASE WHEN ROW_NUMBER() OVER(PARTITION BY tat.ID ORDER BY tat.Serial)=1 THEN ISNULL(tatd.Ezafat,0) ELSE 0 END ) AS Ezafat,
(CASE WHEN ROW_NUMBER() OVER(PARTITION BY tat.ID ORDER BY tat.Serial)=1 THEN ISNULL(tatd.mablaq_takhfif,0) ELSE 0 END ) AS Takhfif_Kol,

tar.ID						AS IDItem,
tat.ID						AS IDHead,
tar.radif ,
tat.Serial ,
tat.tarikh ,
LTRIM(RTRIM(tat.sharh ))	AS sharh,
tkx.kind					AS KindObject,
LTRIM(RTRIM(ta.title))		AS People,
LTRIM(RTRIM(tbl.Title))     AS LocationTitle,
LTRIM(RTRIM(tar.CostDescriptor))     AS CostDescriptor



FROM				Anbar.tbl_Amaliat_Riz			AS tar
INNER JOIN			Anbar.tbl_Amaliat_Title			AS tat	ON tat.ID   = tar.FK_Title
LEFT OUTER JOIN		Anbar.tbl_Amaliat_Title_Detail	AS tatd ON tatd.ID = tat.ID
INNER JOIN			Base.tbl_Kala_Xadamat			AS tkx	ON tkx.Code = tar.FK_Kala
LEFT OUTER JOIN		Base.tbl_Vahed					AS tv	ON tv.ID    = tkx.FK_Vahed
LEFT OUTER JOIN		General.DimDate					AS dd	ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN		Base.tbl_Ashxas					AS ta	ON ta.ID    = tat.FK_AshXas_ID
LEFT OUTER JOIN		Base.tbl_Base_Location			AS tbl  ON tbl.ID   = tat.FK_Location

WHERE       (tat.FK_Salmali = @Year OR @Year IS NULL) 
        AND (tat.kind = @KindFrosh  OR tat.kind = @KindBargashtFrosh)

");
        }
    }
}
