using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class AnalyzeStorage1Config : DapperEntityConfiguration<AnalyzeLevel1>
    {
        public AnalyzeStorage1Config()
        {
            SetList(@"
SELECT 

tgk2.Code,
LTRIM(RTRIM(tgk2.title )) AS title,
SUM(CASE WHEN tat.kind=11 THEN tar.meqdar ELSE 0 END) AS Init,
SUM(CASE WHEN tat.kind=12 THEN tar.meqdar ELSE 0 END) AS Purchase,
SUM(CASE WHEN tat.kind=13 THEN tar.meqdar ELSE 0 END) AS SaleBack,
SUM(CASE WHEN tat.kind=50 THEN tar.meqdar ELSE 0 END) AS Sale,
SUM(CASE WHEN tat.kind=51 THEN tar.meqdar ELSE 0 END) AS PurchaseBack,
SUM(CASE WHEN tat.kind=53 THEN tar.meqdar ELSE 0 END) AS Transfer,
SUM(CASE WHEN tat.kind=54 THEN tar.meqdar ELSE 0 END) AS Usage

FROM Anbar.tbl_Amaliat_Riz AS tar

INNER JOIN Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID		= tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat		AS tkx		ON tkx.Code		= tar.FK_Kala
LEFT OUTER JOIN Base.tbl_GroupKala_2th	AS tgk		ON tgk.Code		= tkx.FK_GroupKala_2th
LEFT OUTER JOIN Base.tbl_GroupKala_1th	AS tgk2		ON tgk2.Code	= tgk.FK_GroupKala_1th 

WHERE tar.FK_Anbar_Az = @Code AND tar.FK_Salmali = @Year
GROUP BY tgk2.Code,tgk2.title

");
        }
    }

    public class AnalyzeStorage2Config : DapperEntityConfiguration<AnalyzeLevel2>
    {
        public AnalyzeStorage2Config()
        {
            SetList(@"
SELECT 

tgk.Code,
LTRIM(RTRIM(tgk.title )) AS title,
SUM(CASE WHEN tat.kind=11 THEN tar.meqdar ELSE 0 END) AS Init,
SUM(CASE WHEN tat.kind=12 THEN tar.meqdar ELSE 0 END) AS Purchase,
SUM(CASE WHEN tat.kind=13 THEN tar.meqdar ELSE 0 END) AS SaleBack,
SUM(CASE WHEN tat.kind=50 THEN tar.meqdar ELSE 0 END) AS Sale,
SUM(CASE WHEN tat.kind=51 THEN tar.meqdar ELSE 0 END) AS PurchaseBack,
SUM(CASE WHEN tat.kind=53 THEN tar.meqdar ELSE 0 END) AS Transfer,
SUM(CASE WHEN tat.kind=54 THEN tar.meqdar ELSE 0 END) AS Usage

FROM       Anbar.tbl_Amaliat_Riz        AS tar
INNER JOIN Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID		= tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat		AS tkx		ON tkx.Code		= tar.FK_Kala
LEFT OUTER JOIN Base.tbl_GroupKala_2th	AS tgk		ON tgk.Code		= tkx.FK_GroupKala_2th

WHERE tgk.FK_GroupKala_1th = @Code AND tar.FK_Salmali = @Year

GROUP BY tgk.Code,tgk.title



");
        }
    }

    public class AnalyzeStorage3Config : DapperEntityConfiguration<AnalyzeLevel3>
    {
        public AnalyzeStorage3Config()
        {
            SetList(@"

SELECT 

tkx.Code,
LTRIM(RTRIM(tkx.title )) AS title,
SUM(CASE WHEN tat.kind=11 THEN tar.meqdar ELSE 0 END) AS Init,
SUM(CASE WHEN tat.kind=12 THEN tar.meqdar ELSE 0 END) AS Purchase,
SUM(CASE WHEN tat.kind=13 THEN tar.meqdar ELSE 0 END) AS SaleBack,
SUM(CASE WHEN tat.kind=50 THEN tar.meqdar ELSE 0 END) AS Sale,
SUM(CASE WHEN tat.kind=51 THEN tar.meqdar ELSE 0 END) AS PurchaseBack,
SUM(CASE WHEN tat.kind=53 THEN tar.meqdar ELSE 0 END) AS Transfer,
SUM(CASE WHEN tat.kind=54 THEN tar.meqdar ELSE 0 END) AS Usage

FROM Anbar.tbl_Amaliat_Riz AS tar

INNER JOIN Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID		= tar.FK_Title
INNER JOIN Base.tbl_Kala_Xadamat		AS tkx		ON tkx.Code		= tar.FK_Kala

WHERE tkx.FK_GroupKala_2th = @Code AND tar.FK_Salmali = @Year

GROUP BY tkx.Code,tkx.title



");
        }
    }
}
