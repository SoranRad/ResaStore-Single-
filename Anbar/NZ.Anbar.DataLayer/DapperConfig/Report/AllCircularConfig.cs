using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class AllCircularConfig : DapperEntityConfiguration<AllCircular>
    {
        public AllCircularConfig()
        {
            SetList(@"
SELECT 
dd.PersianStr ,
dd.PersianMonthNo,
dd.PersianDayInMonth,
tat.kind					AS KindHead,
tkx.Code ,
LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
LTRIM(RTRIM(tv.title))		AS UnitTitle,
tar.meqdar ,
tar.nerkh ,
tar.takhfif ,
tar.takhfif_darsad ,
tar.mablaq ,

tar.ID			AS IDItem,
tat.ID			AS IDHead,
tar.radif ,
tat.Serial ,
tat.tarikh ,
LTRIM(RTRIM(tat.sharh ))	AS sharh,
tkx.kind					AS KindObject,
LTRIM(RTRIM(ta.title))		AS People,
LTRIM(RTRIM(tbl.Title))     AS LocationTitle


FROM Anbar.tbl_Amaliat_Riz			    AS tar
INNER JOIN Anbar.tbl_Amaliat_Title	    AS tat	ON tat.ID   = tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat	    AS tkx	ON tkx.Code = tar.FK_Kala
LEFT OUTER JOIN Base.tbl_Vahed		    AS tv	ON tv.ID    = tkx.FK_Vahed
LEFT OUTER JOIN General.DimDate		    AS dd	ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN Base.tbl_Ashxas		    AS ta	ON ta.ID    = tat.FK_AshXas_ID
LEFT OUTER JOIN Base.tbl_Base_Location	AS tbl  ON tbl.ID   = tat.FK_Location

WHERE tat.FK_Salmali = @Year 

");
        }

    }
}
