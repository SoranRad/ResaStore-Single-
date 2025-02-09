using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class RemaindBalanceConfig : DapperEntityConfiguration<RemaindBalance>
    {
        public RemaindBalanceConfig()
        {
            SetItem(@"
DECLARE @DP DECIMAL,@Deficit DECIMAL,@Assign DECIMAL,@Back DECIMAL,@Remaind DECIMAL


SET @DP =(
	SELECT 
	SUM
	(
		CASE WHEN tad.kind = 1 
			 THEN -(ISNULL(Cheque.mablaq,0)+ISNULL(CashPos.mablaq,0)-ISNULL(tad.takhfif,0)) 
		ELSE		ISNULL(Cheque.mablaq,0)+ISNULL(CashPos.mablaq,0)-ISNULL(tad.takhfif,0) 
		END
	)AS Balance
	FROM 
	Xazane.tbl_Amaliat_DP AS tad
	LEFT OUTER JOIN 
	(
			SELECT 
				tax2.FK_DP,
				SUM(tax2.mablaq) AS mablaq 
			FROM Xazane.tbl_Amaliat_Xazaneh AS tax2
			GROUP BY tax2.FK_DP

	) AS CashPos ON CashPos.FK_DP = tad.ID

	LEFT OUTER JOIN 
	(
			SELECT 
				tac2.FK_DP,
				SUM(tac2.mablaq)AS mablaq 
			FROM Xazane.tbl_Amaliat_Check AS tac2
			GROUP BY tac2.FK_DP

	) AS Cheque ON Cheque.FK_DP = tad.ID

	WHERE 
		 tad.FK_Salmali	= @Year
	AND  tad.FK_ShaXs	= @ID
	AND (tad.kind = 1	OR tad.kind = 2)
)

SET @Deficit=
(
	SELECT 
			SUM(CASE WHEN tax.kind = 7 THEN -tax.mablaq ELSE tax.mablaq END )  AS Balance

	FROM 
	Xazane.tbl_Amaliat_Xazaneh  AS tax
	LEFT OUTER JOIN Xazane.tbl_Amaliat_DP AS tad ON tax.FK_DP = tad.ID
	WHERE 
		 tad.FK_Salmali	= @Year
	AND  tad.FK_ShaXs	= @ID
	AND (tax.kind = 6	OR tax.kind = 7)
)


SET @Assign=(
		SELECT
		SUM(tac.mablaq)AS Balance
		FROM  Xazane.tbl_Amaliat_Check		AS tac
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tac.FK_DP
		WHERE
			 tac.FK_Salmali_Vaziat	= @Year
		AND  tac.FK_Shaxs_Vaziat	= @ID
		AND  tac.Kind_Vaziat		= 2
)

SET @Back = 
(
	SELECT
		SUM(CASE WHEN tac.kind = 2 THEN -tac.mablaq ELSE tac.mablaq END) AS Balance

	FROM  Xazane.tbl_Amaliat_Check		AS tac
	INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tac.FK_DP
	LEFT OUTER JOIN General.DimDate		AS dd  ON dd.GregorianDate = tad.tarikh 
	WHERE
		 tac.FK_Salmali_Vaziat	= @Year
	AND  tad.FK_ShaXs			= @ID
	AND  tac.Kind_Vaziat		= 3
)

SET @Remaind = 
(
		SELECT 
				SUM(
					CASE WHEN tad.kind = 11 
						 THEN ISNULL(tad.takhfif,0) 
					ELSE -ISNULL(tad.takhfif,0) 
					END
					)AS Balance
		FROM 
		Xazane.tbl_Amaliat_DP AS tad
		LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh  AS tax ON tax.FK_DP = tad.ID
		INNER JOIN General.DimDate					AS dd  ON dd.GregorianDate = tad.tarikh
		WHERE 
			 tad.FK_Salmali	= @Year
		AND  tad.FK_ShaXs	= @ID
		AND (tad.kind = 11	OR tad.kind = 12)
)

SELECT ISNULL(@DP,0)+ISNULL(@Deficit,0)+ISNULL(@Assign,0)+ISNULL(@Back,0)+ISNULL(@Remaind,0) as Balance;

");
        }
    }
}
