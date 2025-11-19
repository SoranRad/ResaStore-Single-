using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class RemaindPeopleConfig: DapperEntityConfiguration<RemaindPeople>
    {
        public RemaindPeopleConfig()
        {
            SetList(@"
SELECT 

ta.ID,
ta.code,
LTRIM(RTRIM(ta.title ))		AS Title,
LTRIM(RTRIM(tga.Title))		AS GroupTitle,
ta.FK_Group ,
ta.kind ,
RTRIM(LTRIM(ta.namePedar))	AS  namePedar,
RTRIM(LTRIM(ta.codeMeli))	AS  codeMeli,
RTRIM(LTRIM(ta.tel))		AS tel ,
RTRIM(LTRIM(ta.mobile))		AS mobile,
Storage.Balance


FROM Base.tbl_Ashxas AS ta
LEFT OUTER JOIN Base.tbl_Group_Ashxas AS tga ON tga.ID = ta.FK_Group

LEFT OUTER JOIN(
SELECT 
tat.FK_AshXas_ID,
SUM((CASE WHEN tat.kind >=12 AND tat.kind<50 THEN -tat.mablaq ELSE tat.mablaq END)) AS Balance

FROM  Anbar.tbl_Amaliat_Title	AS tat 
WHERE tat.FK_Salmali = @Year
AND  (tat.kind>=12 AND tat.kind<=100)
AND  (tat.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
AND  (tat.tarikh <=@TaTarikh OR @TaTarikh IS NULL)


GROUP BY tat.FK_AshXas_ID
) AS Storage ON Storage.FK_AshXas_ID = ta.ID

");
        }
    }
}
