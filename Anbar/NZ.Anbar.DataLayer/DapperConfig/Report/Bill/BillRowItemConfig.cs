using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class BillRowItemConfig : DapperEntityConfiguration<BillRowItem>
    {
        public BillRowItemConfig()
        {
            this.SetList(@"
SELECT 

(1)						AS Subsystem,
tat.kind				AS Kind ,
N'انبار(خریدو فروش)'	AS SubsystemTitle,
(CASE WHEN @Group=1 THEN tgk.Code ELSE  tkx.Code END) AS Code,
LTRIM(RTRIM((CASE WHEN @Group=1 THEN tgk.title ELSE  tkx.title END)))AS Title ,
--LTRIM(RTRIM(tkx.title)) AS Title,
SUM(tar.meqdar)			AS Count,

SUM((CASE WHEN tat.kind >=12 AND tat.kind<50 THEN 0 ELSE tar.mablaq END)) AS Debit,
SUM((CASE WHEN tat.kind >=12 AND tat.kind<50 THEN tar.mablaq ELSE 0 END)) AS Credit

FROM Anbar.tbl_Amaliat_Riz			AS tar
INNER JOIN Anbar.tbl_Amaliat_Title	AS tat ON tat.ID   = tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx ON tkx.Code = tar.FK_Kala
INNER JOIN Base.tbl_GroupKala_2th	AS tgk ON tgk.Code = tkx.FK_GroupKala_2th

WHERE 
	(tat.FK_Salmali = @Year OR @Year IS NULL)
AND tat.FK_AshXas_ID = @People 
AND (tat.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tat.tarikh<=@DateTo   OR @DateTo   IS NULL)
AND (tat.kind>=12 AND tat.kind<=100)

GROUP BY (CASE WHEN @Group=1 THEN tgk.Code ELSE  tkx.Code END),
(CASE WHEN @Group=1 THEN tgk.title ELSE  tkx.title END),
tat.kind

UNION ALL

SELECT 

(1)			AS Subsystem,
tat.kind	AS Kind ,
N'انبار(خریدو فروش)' AS SubsystemTitle,
NULL AS Code ,
N'تخفیفات' AS Title,
NUll        AS Count,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN tatd.mablaq_takhfif
ELSE 0  END)
) AS Debit,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN 0
ELSE tatd.mablaq_takhfif END)
) AS Credit


FROM        Anbar.tbl_Amaliat_Title_Detail AS tatd
INNER JOIN  Anbar.tbl_Amaliat_Title	AS tat ON tat.ID = tatd.ID

WHERE 
    (tat.FK_Salmali = @Year  OR @Year IS NULL)
AND tat.FK_AshXas_ID =@People 
AND (tat.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tat.tarikh<=@DateTo   OR @DateTo   IS NULL)
AND (tat.kind>=12 AND tat.kind<=100)

GROUP BY tat.kind

UNION ALL

SELECT 

(1)			AS Subsystem,
tat.kind	AS Kind ,
N'انبار(خریدو فروش)' AS SubsystemTitle,
NULL AS Code ,
N'اضـافات' AS Title,
NULL        AS Count,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN 0
ELSE tatd.Ezafat END)
) AS Debit,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN tatd.Ezafat
ELSE 0 END)
) AS Credit


FROM Anbar.tbl_Amaliat_Title_Detail AS tatd
INNER JOIN Anbar.tbl_Amaliat_Title	AS tat ON tat.ID = tatd.ID

WHERE 
    (tat.FK_Salmali = @Year OR @Year IS NULL)
AND tat.FK_AshXas_ID =@People 
AND (tat.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tat.tarikh<=@DateTo   OR @DateTo   IS NULL)
AND (tat.kind>=12 AND tat.kind<=100)
GROUP BY tat.kind

UNION ALL

SELECT 

(1)			AS Subsystem,
tat.kind	AS Kind ,
N'انبار(خریدو فروش)' AS SubsystemTitle,
NULL AS Code ,
N'مالیات' AS Title,
NULL  AS Count,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN 0
ELSE tatd.mablaq_Maliat END)
) AS Debit,

SUM(
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN tatd.mablaq_Maliat
ELSE 0 END)
) AS Credit


FROM Anbar.tbl_Amaliat_Title_Detail AS tatd
INNER JOIN Anbar.tbl_Amaliat_Title	AS tat ON tat.ID = tatd.ID

WHERE 
    (tat.FK_Salmali = @Year OR @Year IS NULL)
AND  tat.FK_AshXas_ID = @People 
AND (tat.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tat.tarikh<=@DateTo   OR @DateTo   IS NULL)
AND (tat.kind>=12 AND tat.kind<=100)
GROUP BY tat.kind

");

        }
    }
}
