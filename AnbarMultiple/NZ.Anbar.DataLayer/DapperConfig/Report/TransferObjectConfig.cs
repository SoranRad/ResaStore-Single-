using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class TransferObjectConfig : DapperEntityConfiguration<TransferObject>
    {
        public TransferObjectConfig()
        {
            SetList(@"
SELECT 
dd.PersianStr ,
tat.kind					AS KindHead,
tkx.Code ,
LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
LTRIM(RTRIM(tv.title))		AS UnitTitle,

( CASE WHEN   tat.kind  =  13	THEN tar.nerkh_2
        ELSE  tar.nerkh 
        END
) AS nerkh , 
tar.Remain,

tar.ID			AS IDItem,
tat.ID			AS IDHead,
tar.radif ,
tat.Serial ,
tat.tarikh , 
LTRIM(RTRIM(ta.title))		AS People


FROM Anbar.tbl_Amaliat_Riz			    AS tar
INNER JOIN Anbar.tbl_Amaliat_Title	    AS tat	ON tat.ID   = tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat	    AS tkx	ON tkx.Code = tar.FK_Kala
LEFT OUTER JOIN Base.tbl_Vahed		    AS tv	ON tv.ID    = tkx.FK_Vahed
LEFT OUTER JOIN General.DimDate		    AS dd	ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN Base.tbl_Ashxas		    AS ta	ON ta.ID    = tat.FK_AshXas_ID 

WHERE 
      tat.FK_Salmali = @Year
  AND tar.Remain > 0
  AND (
             (tat.kind >= 11 AND tat.kind < 50  AND tat.FK_Anbar_Az = @Anbar) 
          OR (tat.kind = 55  AND tat.FK_Anbar_Be = @Anbar)
      )  
");

            ///tat.FK_Salmali = @Year AND tat.kind>=@KindAvalDore AND tat.kind <@KindFrosh AND tar.Remain > 0
        }
    }
}
