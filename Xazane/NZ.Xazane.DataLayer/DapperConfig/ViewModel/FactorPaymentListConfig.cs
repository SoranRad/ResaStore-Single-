using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class FactorPaymentListConfig :DapperEntityConfiguration<FactorPaymentList>
    {
        public FactorPaymentListConfig()
        {
            this.SetList(@"

SELECT tad.ID ,
       tad.serial ,
       tad.takhfif ,
       LTRIM(RTRIM(tad.sharh)) AS sharh,
	   dd.PersianMonthNo,
	   dd.PersianDayInMonth,
	   dd.PersianStr,
	   LTRIM(RTRIM(ta.title)) AS CustomerTitle,
	   PosCache.Cache,
	   PosCache.Pos,
	   Cheque.Cheque,
	   Cheque.CountCheque

FROM			Xazane.tbl_Amaliat_DP		AS tad
INNER JOIN		General.DimDate				AS dd  ON dd.GregorianDate = tad.tarikh
INNER JOIN		Base.tbl_Ashxas				AS ta  ON tad.FK_ShaXs = ta.ID
LEFT OUTER JOIN (
SELECT 
tax.FK_DP, 
SUM(CASE WHEN tax.kind = 9 THEN tax.mablaq ELSE 0 END)  AS Cache,
SUM(CASE WHEN tax.kind = 10 THEN tax.mablaq ELSE 0 END) AS Pos
FROM Xazane.tbl_Amaliat_Xazaneh	AS tax 
GROUP BY tax.FK_DP

) AS PosCache ON PosCache.FK_DP = tad.ID

LEFT OUTER JOIN
(
SELECT 
tac.FK_DP,
SUM(tac.mablaq) AS  Cheque,
COUNT(tac.ID)	AS CountCheque

FROM  Xazane.tbl_Amaliat_Check	AS tac 

GROUP BY tac.FK_DP
 ) AS Cheque ON Cheque.FK_DP = tad.ID



WHERE tad.FK_Faktor = @IdFactor


");

            this.SetItem(@"
SELECT COUNT(DISTINCT tad.ID) AS  CountCheque
FROM Xazane.tbl_Amaliat_DP		AS tad
WHERE tad.FK_Faktor = @IdFactor

");


        }
    }
}
