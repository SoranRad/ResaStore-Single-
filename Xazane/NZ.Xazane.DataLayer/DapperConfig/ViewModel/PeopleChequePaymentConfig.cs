using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
	public class PeopleChequePaymentConfig : DapperEntityConfiguration<PeopleChequePayment>
	{
		public PeopleChequePaymentConfig()
		{
			SetList(@"
SELECT 

	tac.ID, 
	tac.Kind_Vaziat,
	LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
	tac.mablaq,
	ddSarResid.PersianStr AS PersianUsanceStr,
	LTRIM(RTRIM(tac.babat)) AS babat,
	dd.PersianStr,
	tac.tarikh_sar_resid,
	tac.Shenase_Sayadi, 
	LTRIM(RTRIM(ta.title)) AS CustomerTitle,
	LTRIM(RTRIM(tb.title)) AS BankTitle,
	LTRIM(RTRIM(tac.Sharh_Vaziat)) AS Sharh_Vaziat


FROM Xazane.tbl_Amaliat_Check AS tac

INNER JOIN		    Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID                       = tac.FK_DP
INNER JOIN		    Base.tbl_Ashxas				AS ta			ON tad.FK_ShaXs                 = ta.ID
INNER JOIN		    General.DimDate				AS dd			ON dd.GregorianDate             = tad.tarikh
LEFT OUTER JOIN     General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate     = tac.tarikh_sar_resid
LEFT OUTER JOIN     Base.tbl_Bank				AS tb			ON tac.FK_Bank                  = tb.ID 

WHERE ( tac.Kind_Vaziat = @KindVaziat OR tac.Kind_Vaziat IS NULL ) AND tad.kind = @KindDaryaft

");
		}
	}
}
