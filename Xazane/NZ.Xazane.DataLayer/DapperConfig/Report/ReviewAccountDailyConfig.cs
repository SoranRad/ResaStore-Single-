using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class ReviewAccountDailyConfig : DapperEntityConfiguration<ReviewAccountDaily>
    {
        public ReviewAccountDailyConfig()
        {
            SetList(@"

SELECT 
	   Sub.ID ,
       LTRIM(RTRIM(Sub.title )) AS Title,
       Sub.mojudi_avalie ,
       Sub.Kind ,
       Sub.Code ,
       Sub.Day ,
       Sub.Date,
       Sub.DayOfWeekInt ,
       Sub.WeekName ,
       SUM(Sub.DebitCircular ) AS DebitCircular,
       SUM(Sub.CreditCircular ) AS CreditCircular

FROM 
(
        SELECT 

                thx.ID,
                thx.title,
                thx.mojudi_avalie,
                thx.Kind,
                thx.Code,
                (CASE WHEN tax.tarikh IS NULL 
	                  THEN dd2.PersianStr 
	                  ELSE dd.PersianStr 
                END) AS Day,
                (CASE WHEN tax.tarikh IS NULL 
				                  THEN tad.tarikh
				                  ELSE tax.tarikh 
                END) AS Date,
                (CASE WHEN tax.tarikh IS NULL 
				                  THEN dd2.PersianDayOfWeekInt
				                  ELSE dd.PersianDayOfWeekInt 
                END) AS DayOfWeekInt ,
                (CASE WHEN tax.tarikh IS NULL 
				                  THEN dd2.PersianDayOfWeekName
				                  ELSE dd.PersianDayOfWeekName 
                END) AS WeekName,
                SUM(CASE WHEN thx.ID=tax.FK_Xazaneh_Bad 
		                 THEN tax.mablaq 
		                 ELSE 0
                END) AS DebitCircular,
                SUM(CASE WHEN thx.ID=tax.FK_Xazaneh_Bad 
		                 THEN  0
		                 ELSE tax.mablaq
                END) AS CreditCircular

        FROM Xazane.tbl_Hesab_Xazaneh				AS thx
        LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh	AS tax	ON tax.FK_Xazaneh_Bad = thx.ID OR tax.FK_Xazaneh_Bas = thx.ID
        LEFT OUTER JOIN Xazane.tbl_Amaliat_DP		AS tad	ON tad.ID = tax.FK_DP
        LEFT OUTER JOIN General.DimDate				AS dd	ON dd.GregorianDate = tax.tarikh
        LEFT OUTER JOIN General.DimDate				AS dd2	ON tad.tarikh = dd2.GregorianDate

        WHERE 
	        tax.FK_Salmali = @Year
        AND thx.ID = @ID
        AND (dd2.PersianMonthNo = @Month OR dd.PersianMonthNo = @Month OR @Month IS NULL)

        GROUP BY	thx.ID,
			        thx.title,
			        thx.Code,
			        thx.mojudi_avalie,
			        thx.Kind,
			        (CASE WHEN tax.tarikh IS NULL 
				          THEN dd2.PersianDayOfWeekInt
				          ELSE dd.PersianDayOfWeekInt 
			        END),
			        (CASE WHEN tax.tarikh IS NULL 
				          THEN tad.tarikh
				          ELSE tax.tarikh 
			        END),
			        (CASE WHEN tax.tarikh IS NULL 
				          THEN dd2.PersianDayOfWeekName
				          ELSE dd.PersianDayOfWeekName 
			        END),
			        (CASE WHEN tax.tarikh IS NULL 
				          THEN dd2.PersianStr
				          ELSE dd.PersianStr 
			        END)

        UNION ALL 
        SELECT 

                thx.ID,
                thx.title,
                thx.mojudi_avalie,
                thx.Kind,
                thx.Code,
                dd.PersianStr				AS Day,
                tac.Tarix_Vaziat			AS Date,
                dd.PersianDayOfWeekInt		AS DayOfWeekInt,
                dd.PersianDayOfWeekName		AS DayOfWeekName, 
                SUM(CASE WHEN thx.ID = tac.FK_Xazaneh_Vaziat
		                 THEN tac.mablaq
		                 ELSE 0
                END)						AS DebitCircular,
                SUM(CASE WHEN thx.ID = tac.FK_Hesab_Pardaxtani
		                 THEN  tac.mablaq
		                 ELSE 0
                END)						AS CreditCircular

        FROM Xazane.tbl_Hesab_Xazaneh				AS thx

        LEFT OUTER JOIN Xazane.tbl_Amaliat_Check	AS tac	ON tac.FK_Hesab_Pardaxtani = thx.ID OR tac.FK_Xazaneh_Vaziat = thx.ID
        LEFT OUTER JOIN General.DimDate				AS dd	ON tac.Tarix_Vaziat = dd.GregorianDate

        WHERE 
	        tac.FK_Salmali_Vaziat	=@Year 
        AND (dd.PersianMonthNo		=@Month OR @Month IS NULL)
        AND tac.Kind_Vaziat			=@Kind
        AND thx.ID					=@ID

        GROUP BY	thx.ID,
			        thx.title,
			        thx.Code,
			        thx.mojudi_avalie,
			        thx.Kind,
			        tac.Tarix_Vaziat,
			        dd.PersianDayOfWeekInt,
			        dd.PersianDayOfWeekName, 
			        dd.PersianStr 
        ) AS Sub

        GROUP BY Sub.ID ,
                 Sub.title ,
                 Sub.mojudi_avalie ,
                 Sub.Kind ,
                 Sub.Code ,
                 Sub.Day ,
                 Sub.Date,
                 Sub.DayOfWeekInt ,
                 Sub.WeekName
			
");
        }
    }
}
