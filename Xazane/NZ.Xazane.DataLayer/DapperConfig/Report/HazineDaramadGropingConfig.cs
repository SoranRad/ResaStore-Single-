using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class HazineDaramadGropingConfig : DapperEntityConfiguration<HazineDaramadGroping>
    {
        public HazineDaramadGropingConfig()
        {
            SetList(@"


WITH  sub  AS (
	SELECT 
	   tax.mablaq AS Mablaq,
	   
	   (CASE WHEN @kind = 4 
	    THEN  RTRIM(Ltrim(thx_Bad.title)) 
		ELSE  RTRIM(Ltrim(thx_Bas.title ))
		END) AS HesabTitle

		  FROM Xazane.tbl_Amaliat_Xazaneh as tax
            left outer join Xazane.tbl_Hesab_Xazaneh as thx_Bad on tax.FK_Xazaneh_Bad = thx_Bad.ID
            left outer join Xazane.tbl_Hesab_Xazaneh as thx_Bas on tax.FK_Xazaneh_Bas = thx_Bas.ID

		  WHERE tax.FK_Salmali=@Year and tax.kind=@Kind 
)
SELECT 
	sub.HesabTitle as Title,
	SUM(sub.Mablaq) as Mablaq
FROM sub
GROUP BY
sub.HesabTitle

");
        }
    }
}
