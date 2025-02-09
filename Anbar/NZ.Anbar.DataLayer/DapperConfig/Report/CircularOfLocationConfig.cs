using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class CircularOfLocationConfig : DapperEntityConfiguration<CircularOfLocation>
    {
        public CircularOfLocationConfig()
        {
            SetList(@"
SELECT  
        tat.Serial,
        dd.PersianStr,
        tat.ID AS IDTitle,
        tar.ID,
        tar.FK_Kala,
        LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
        LTRIM(RTRIM(tv.title))  AS UnitTitle,
        tar.meqdar,
        tar.nerkh,
        tar.takhfif_darsad,
        tar.takhfif,
        tar.mablaq,
        LTRIM(RTRIM(tbl.Title)) AS LocationTitle,
        LTRIM(RTRIM(ta.title))  AS CustomerTitle


FROM			Anbar.tbl_Amaliat_Riz	    AS  tar
INNER JOIN		Anbar.tbl_Amaliat_Title	    AS  tat	    ON tat.ID	    = tar.FK_Title
INNER JOIN		Base.tbl_Kala_Xadamat	    AS  tkx	    ON tkx.Code     = tar.FK_Kala
INNER JOIN		Base.tbl_Vahed			    AS  tv	    ON tv.ID	    = tkx.FK_Vahed
LEFT OUTER JOIN General.DimDate			    AS  dd	    ON tat.tarikh   = dd.GregorianDate
LEFT OUTER JOIN Base.tbl_Base_Location	    AS  tbl	    ON tbl.ID	    = tat.FK_Location
LEFT OUTER JOIN Base.tbl_Ashxas			    AS  ta	    ON tat.FK_AshXas_ID = ta.ID


WHERE 

	tat.FK_Salmali  = @Year
	AND tat.kind    = @Kind
AND (tat.tarikh >= @TarixAz         OR      @TarixAz IS NULL)
AND (tat.tarikh <= @TarixTa         OR      @TarixTa IS NULL)
AND (tat.FK_Location = @Location    OR      @Location IS NULL)


");
        }
    }
}
