using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Bill
{
	public class BillRowConfig :  DapperEntityConfiguration<BillRow>
	{
		public BillRowConfig()
		{
			SetList(@"

SELECT tar.ID ,
       tar.meqdar ,
       tat.Serial,
       tar.nerkh ,
       tar.mablaq ,
       RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
       dd.PersianStr,
       tat.tarikh,
       tat.kind

	   
FROM Anbar.tbl_Amaliat_Riz          AS tar
INNER JOIN Base.tbl_Kala_Xadamat    AS tkx  ON tkx.Code     = tar.FK_Kala 
INNER JOIN Anbar.tbl_Amaliat_Title  AS tat  ON tat.ID       = tar.FK_Title
LEFT OUTER JOIN General.DimDate     AS dd   ON dd.GregorianDate = tat.tarikh 


WHERE tat.FK_Salmali=@Year and tat.FK_AshXas_ID =@People

UNION ALL

SELECT tat.ID ,
       (1)AS meqdar ,
       tat.Serial,
       (0)AS nerkh ,
       tatd.mablaq_takhfif AS mablaq ,
       N'تخفیفات' AS ObjectTitle,
       dd.PersianStr,
       tat.tarikh,
       tat.kind

	     
FROM Anbar.tbl_Amaliat_Title                AS tat  
INNER JOIN Anbar.tbl_Amaliat_Title_Detail   AS tatd ON  tat.ID = tatd.ID
LEFT OUTER JOIN General.DimDate     AS dd   ON dd.GregorianDate = tat.tarikh 

WHERE tat.FK_Salmali=@Year and tat.FK_AshXas_ID =@People

UNION ALL

SELECT tat.ID ,
       (1)AS meqdar ,
       tat.Serial,
       (0)AS nerkh ,
       tatd.Ezafat AS mablaq ,
       N'اضـافات' AS ObjectTitle,
       dd.PersianStr,
       tat.tarikh,
       tat.kind

	     
FROM Anbar.tbl_Amaliat_Title                AS tat  
INNER JOIN Anbar.tbl_Amaliat_Title_Detail   AS tatd ON  tat.ID = tatd.ID
LEFT OUTER JOIN General.DimDate     AS dd   ON dd.GregorianDate = tat.tarikh 

WHERE tat.FK_Salmali=@Year and tat.FK_AshXas_ID =@People

UNION ALL

SELECT tat.ID ,
       (1)AS meqdar ,
       tat.Serial,
       (0)AS nerkh ,
       tatd.mablaq_Maliat AS mablaq ,
       N'مالیات' AS ObjectTitle,
       dd.PersianStr,
       tat.tarikh,
       tat.kind

	     
FROM Anbar.tbl_Amaliat_Title                AS tat  
INNER JOIN Anbar.tbl_Amaliat_Title_Detail   AS tatd ON  tat.ID = tatd.ID
LEFT OUTER JOIN General.DimDate     AS dd   ON dd.GregorianDate = tat.tarikh 

WHERE tat.FK_Salmali=@Year and tat.FK_AshXas_ID =@People


");
		}
	}
}
