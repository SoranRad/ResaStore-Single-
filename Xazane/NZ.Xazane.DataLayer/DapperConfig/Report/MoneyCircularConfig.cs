using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class MoneyCircularConfig : DapperEntityConfiguration<MoneyCircular>
    {
        public MoneyCircularConfig()
        {
            SetList(@"
SELECT 
        tax.FK_DP ,
        tax.serialPeygiri ,
        tad.serial ,
        tax.mablaq ,
        tax.kind,
        tad.FK_ShaXs ,
        tad.tarikh ,
        tax.kind					AS SubKind ,
        tad.kind					AS MainKind,
        tax.ID						AS IDSub ,
        LTRIM(RTRIM(tax.sharh ))	AS SubDesc ,
        LTRIM(RTRIM(tad.sharh ))	AS MainDesc,
        LTRIM(RTRIM(thxBad.title )) AS DebitTitle,
        LTRIM(RTRIM(thxBas.title )) AS CreditTitle,
        dd.PersianStr
 

FROM				Xazane.tbl_Amaliat_Xazaneh		AS tax
INNER JOIN			Xazane.tbl_Amaliat_DP			AS tad		ON tad.ID		= tax.FK_DP
LEFT OUTER JOIN		Xazane.tbl_Hesab_Xazaneh		AS thxBad	ON thxBad.ID	= tax.FK_Xazaneh_Bad
LEFT OUTER JOIN		Xazane.tbl_Hesab_Xazaneh		AS thxBas	ON thxBas.ID	= tax.FK_Xazaneh_Bas
LEFT OUTER JOIN		General.DimDate					AS dd		ON tad.tarikh	= dd.GregorianDate

WHERE 

    tad.FK_ShaXs  = @People 
AND tad.FK_Salmali= @Year
AND (tad.tarikh >=  @DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh <=  @DateTo   OR @DateTo   IS NULL);
---==============================================================مانده حساب قبلی

SELECT 

ta.code,
LTRIM(RTRIM(ta.title)) AS title,
LTRIM(RTRIM(ta.codeMeli)) AS codeMeli,
LTRIM(RTRIM(ta.namePedar)) AS namePedar,

tad.takhfif,
tad.kind,
LTRIM(RTRIM(tad.sharh)) AS Sharh

FROM				Base.tbl_Ashxas			AS ta
LEFT OUTER JOIN		Xazane.tbl_Amaliat_DP	AS tad  ON 	tad.FK_ShaXs = @People 
														AND tad.FK_Salmali	= @Year 
														AND (tad.kind=@CRemain OR tad.kind=@DRemain)
														AND (tad.tarikh>=@DateFrom OR @DateFrom IS NULL)
														AND (tad.tarikh<=@DateTo   OR @DateTo   IS NULL)
WHERE 	 ta.ID			= @People;

---==============================================================چک های شخص

SELECT 

tac.ID,
tac.mablaq,
tad.kind,
tac.mablaq,
dd.PersianStr,
tad.ID								AS ID_DP,
ddSarResid.PersianStr				AS PersianUsanceStr,
LTRIM(RTRIM(tac.shomare_check))		AS shomare_check,
LTRIM(RTRIM(tac.babat))				AS babat,
LTRIM(RTRIM(tb.title))				AS BankTitle,
LTRIM(RTRIM(thx.title))				AS PayAccountTitle

FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
INNER JOIN		General.DimDate				AS dd			ON dd.GregorianDate			= tad.tarikh
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank				= tb.ID
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID					= tac.FK_Hesab_Pardaxtani 

WHERE 
    tad.FK_ShaXs    = @People 
AND tad.FK_Salmali  = @Year
AND (tad.tarikh >=  @DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh <=  @DateTo   OR @DateTo   IS NULL);

--================================================================چک برگشتی

SELECT 

tac.ID,
tac.mablaq,
tad.kind,
tac.mablaq,
tad.ID								AS ID_DP,
ddSarResid.PersianStr				AS PersianUsanceStr,
LTRIM(RTRIM(tac.shomare_check))		AS shomare_check,
LTRIM(RTRIM(tb.title))				AS BankTitle,
LTRIM(RTRIM(thx.title))				AS PayAccountTitle,
LTRIM(RTRIM(tac.Sharh_Vaziat))		AS SharhVaziat,
ddVaziat.PersianStr					AS VaziatPersianStr


FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank				= tb.ID
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID					= tac.FK_Hesab_Pardaxtani 
LEFT OUTER JOIN General.DimDate				AS ddVaziat		ON tac.Tarix_Vaziat			= ddVaziat.GregorianDate

WHERE 
	tad.FK_ShaXs	    =  @People
AND tad.FK_Salmali	    =  @Year
AND tac.Kind_Vaziat     =  @KindBack
AND (tac.Tarix_Vaziat	>= @DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat	<= @DateTo   OR @DateTo   IS NULL);

--========================================================واگداری چک

SELECT 

tac.ID,
tac.mablaq,
tad.kind,
tac.mablaq,
tad.ID								        AS ID_DP,
ddSarResid.PersianStr				        AS PersianUsanceStr,
LTRIM(RTRIM(tac.shomare_check))		        AS shomare_check,
LTRIM(RTRIM(tb.title))				        AS BankTitle,
LTRIM(RTRIM(tac.Sharh_Vaziat))		        AS SharhVaziat,
ddVaziat.PersianStr					        AS VaziatPersianStr,
LTRIM(RTRIM(ta.title))				        AS PeopleTitle

FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tac.FK_Bank				= tb.ID
LEFT OUTER JOIN General.DimDate				AS ddVaziat		ON tac.Tarix_Vaziat			= ddVaziat.GregorianDate
LEFT OUTER JOIN Base.tbl_Ashxas				AS ta			ON tad.FK_ShaXs				= ta.ID

WHERE
	 tac.FK_Salmali_Vaziat	=   @Year
AND  tac.FK_Shaxs_Vaziat	=   @People
AND	 tac.Kind_Vaziat		=   @KindAssign
AND (tac.Tarix_Vaziat	    >=  @DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat	    <=  @DateTo   OR @DateTo   IS NULL);

--=========================================================  حساب های تنخواه گردان
SELECT 

tax.ID,
(
CASE 
    WHEN tax.kind = 5 AND DebitAccount.FK_People = @People  THEN N'انتقال وجه به ' 
    WHEN tax.kind = 5 AND CreditAccount.FK_People = @People  THEN N'انتقال وجه از ' 
    WHEN tax.kind = 4 THEN N'پرداخت هزینه' 
    WHEN tax.kind = 3 THEN N'واریز درآمد' 
    ELSE N'تراکنش نامعلوم' END 
) AS Title,
(
    CASE 
        WHEN (tax.kind = 5 AND DebitAccount.FK_People = @People)  OR (tax.kind = 3) THEN  tax.mablaq 
        WHEN (tax.kind = 5 AND CreditAccount.FK_People = @People) OR (tax.kind = 4) THEN -tax.mablaq 
        ELSE 0
    END        
) AS mablaq,
LTRIM(RTRIM(tax.sharh))		        AS sharh, 
tarix.PersianStr,
(CASE 
    WHEN tax.kind = 5 AND DebitAccount.FK_People = @People  THEN LTRIM(RTRIM(CreditAccount.title)) 
    WHEN tax.kind = 5 AND CreditAccount.FK_People = @People  THEN LTRIM(RTRIM(DebitAccount.title)) 
    WHEN tax.kind = 4 THEN LTRIM(RTRIM(DebitAccount.title)) 
    WHEN tax.kind = 3 THEN LTRIM(RTRIM(CreditAccount.title)) 
    ELSE N'تراکنش نامعلوم' END 
)AS Hesab, 
tax.serial AS Serial,
tax.tarikh
 
FROM				Xazane.tbl_Amaliat_Xazaneh		AS tax
 
LEFT OUTER JOIN		xazane.tbl_Hesab_Xazaneh		AS DebitAccount			ON DebitAccount.ID          = tax.FK_Xazaneh_Bad
LEFT OUTER JOIN		xazane.tbl_Hesab_Xazaneh		AS CreditAccount		ON CreditAccount.ID         = tax.FK_Xazaneh_Bas
LEFT OUTER JOIN		General.DimDate				    AS tarix	            ON tarix.GregorianDate      = tax.tarikh
 

WHERE 
        tax.FK_Salmali = @Year 
    AND (tax.kind = 5 OR tax.kind = 4 OR tax.kind = 3 )
    AND (DebitAccount.Kind = 6 OR CreditAccount.Kind = 6) 
    AND (DebitAccount.FK_People = @People OR CreditAccount.FK_People = @People)   
    AND (tax.tarikh >= @DateFrom OR @DateFrom IS NULL)
    AND (tax.tarikh <= @DateTo   OR @DateTo   IS NULL)
   

");
        }
    }
}
