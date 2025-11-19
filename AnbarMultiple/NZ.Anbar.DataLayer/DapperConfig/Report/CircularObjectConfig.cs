using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class CircularObjectConfig : DapperEntityConfiguration<CircularObject>
    {
        public CircularObjectConfig()
        {
            SetList($@"
SELECT
tar.ID,
tat.ID AS IDTitle,
tat.tarikh,
dd.PersianStr,
tat.Serial,
tat.kind,
tat.NoRemainEffect,
tar.nerkh,
tat.FK_Anbar_Az,
tat.FK_Anbar_Be,
(CASE WHEN (tat.kind>=11 AND tat.kind < 50 ) OR (tat.kind = 55 AND tat.FK_Anbar_Be = @Anbars)  THEN tar.meqdar 
      ELSE -tar.meqdar   
 END ) AS meqdar,
tar.mablaq,
LTRIM(RTRIM(ta.title)) AS CustomerTitle,
LTRIM(RTRIM(tv.title)) AS UnitTitle,
LTRIM(RTRIM(AnbarAz.Title)) AS AnbarAzTitle,
LTRIM(RTRIM(AnbarBe.Title)) AS AnbarBeTitle,
tar.radif,
LTRIM(RTRIM(tbl.Title)) AS LocationTitle,
LTRIM(RTRIM(ta_tahil.title)) AS Tahvil_Girande

FROM				Anbar.tbl_Amaliat_Riz		AS tar
INNER JOIN			Anbar.tbl_Amaliat_Title		AS tat	        ON tat.ID       = tar.FK_Title
INNER JOIN          Base.tbl_Kala_Xadamat		AS tkx	        ON tkx.Code     = tar.FK_Kala
INNER JOIN          Base.tbl_Vahed				AS tv	        ON tv.ID        = tkx.FK_Vahed
LEFT OUTER JOIN		Base.tbl_Ashxas				AS ta	        ON ta.ID        = tat.FK_AshXas_ID
LEFT OUTER JOIN		General.DimDate				AS dd	        ON tat.tarikh   = dd.GregorianDate
LEFT OUTER JOIN     Base.tbl_Base_Anbar         AS AnbarAz      ON AnbarAz.ID   = tat.FK_Anbar_Az
LEFT OUTER JOIN     Base.tbl_Base_Anbar         AS AnbarBe      ON AnbarBe.ID   = tat.FK_Anbar_Be
LEFT OUTER JOIN     Base.tbl_Base_Location	    AS tbl          ON tbl.ID       = tat.FK_Location
LEFT OUTER JOIN     Base.tbl_Ashxas             AS ta_tahil     ON ta_tahil.ID  = tat.FK_Tahvil_Girande

WHERE tar.FK_Salmali    = @Year 
AND tar.FK_Kala         = @Code
AND tat.kind>=11 AND tat.kind<=100
AND(tat.tarikh >=@DateFrom	OR @DateFrom IS NULL) 
AND(tat.tarikh <=@DateTo	OR @DateTo	 IS NULL) 
AND ((tat.{nameof(FactorHead.FK_Anbar_Az)} = @Anbars ) OR (tat.{nameof(FactorHead.FK_Anbar_Be)} = @Anbars ))
");
        }
    }
}
