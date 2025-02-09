using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class ReviewAccoutnSumarryConfig : DapperEntityConfiguration<ReviewAccoutnSumarry>
    {
        public ReviewAccoutnSumarryConfig()
        {
            SetList(@"

SELECT

thx.ID,
LTRIM(RTRIM(thx.title)) AS Title,
thx.mojudi_avalie,
thx.Kind,
thx.Code,

Xazaneh.DebitCircular,
Xazaneh.CreditCircular,

Cheque.PayAccount,
Cheque.ArriveAccount

FROM				Xazane.tbl_Hesab_Xazaneh	AS thx 
LEFT OUTER JOIN 
(
	SELECT 
	thx.ID,
	SUM(CASE WHEN tax.FK_Xazaneh_Bad = thx.ID THEN tax.mablaq ELSE  0 END)	AS DebitCircular,
	SUM(CASE WHEN tax.FK_Xazaneh_Bas = thx.ID THEN tax.mablaq ELSE  0 END)	AS CreditCircular--,
	
	FROM Xazane.tbl_Hesab_Xazaneh					AS thx 
	LEFT OUTER JOIN		Xazane.tbl_Amaliat_Xazaneh	AS tax ON 
	(
			tax.FK_Xazaneh_Bad = thx.ID 
		OR  tax.FK_Xazaneh_Bas = thx.ID
	) 
	AND tax.FK_Salmali	= @Year
	
	GROUP BY 
	thx.ID
		
) AS Xazaneh ON Xazaneh.ID = thx.ID

LEFT OUTER JOIN 
(
SELECT 

thx.ID,
	SUM(
		CASE WHEN tac.FK_Hesab_Pardaxtani	= thx.ID  
		AND  tac.Kind_Vaziat				= @KindVosul 
		AND  tac.FK_Salmali_Vaziat			= @Year 
		THEN tac.mablaq ELSE  0 END

		)AS PayAccount,

	SUM(
		CASE WHEN tac.FK_Xazaneh_Vaziat		= thx.ID  
		AND tac.Kind_Vaziat					= @KindVosul 
		AND tac.FK_Salmali_Vaziat			= @Year
		THEN tac.mablaq ELSE  0 END

		) AS ArriveAccount
 
 
FROM				Xazane.tbl_Hesab_Xazaneh	AS thx 
LEFT OUTER JOIN		Xazane.tbl_Amaliat_Check	AS tac ON
(
--  وصول چک پرداختی
		 tac.FK_Hesab_Pardaxtani	= thx.ID  
	AND  tac.Kind_Vaziat			= @KindVosul 
	AND  tac.FK_Salmali_Vaziat		= @Year
)
OR
(
--  وصول چک دریافتی
		tac.FK_Xazaneh_Vaziat	= thx.ID  
	AND tac.Kind_Vaziat			= @KindVosul 
	AND tac.FK_Salmali_Vaziat	= @Year
)
 														 
GROUP BY	thx.ID

) AS Cheque ON Cheque.ID = thx.ID

");
        }
    }
}
