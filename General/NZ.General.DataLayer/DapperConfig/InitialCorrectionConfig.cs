using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models.Report;

namespace NZ.General.DataLayer.DapperConfig
{
	public class InitialCorrectionConfig :  DapperEntityConfiguration<InitialCorrection>
	{
		public InitialCorrectionConfig()
		{
			SetItem(@"


UPDATE Anbar.tbl_Amaliat_Title 

SET mablaq = (Riz.RizSum - ISNULL(tad.mablaq_takhfif,0)+ ISNULL(tad.mablaq_Maliat,0)+ ISNULL(tad.Ezafat,0))

FROM Anbar.tbl_Amaliat_Title AS tat
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail  as tad on tad.ID = tat.ID
LEFT OUTER JOIN 
(
    SELECT SUM(tar.mablaq) AS RizSum ,FK_Title
    FROM Anbar.tbl_Amaliat_Riz AS tar
    WHERE FK_Salmali =@Salmali
    GROUP BY FK_Title

) AS Riz ON Riz.FK_Title = tat.ID

WHERE 
	(Riz.RizSum - ISNULL(tad.mablaq_takhfif,0)+ ISNULL(tad.mablaq_Maliat,0)+ ISNULL(tad.Ezafat,0)) <> tat.mablaq 
AND tat.FK_Salmali = @Salmali 
AND (tat.kind = 0 OR tat.kind = 12 OR tat.kind = 13 OR tat.kind = 50 OR tat.kind = 51)

");
		}
	}
}
