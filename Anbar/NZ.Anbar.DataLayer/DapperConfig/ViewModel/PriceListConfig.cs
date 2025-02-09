using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class PriceListConfig: DapperEntityConfiguration<PriceList>
    {
        public PriceListConfig()
        {
            SetList(@"
WITH z AS 
(
SELECT 
FK_Kala,
nerkh AS LastPrice,
ROW_NUMBER() OVER (PARTITION BY FK_Kala ORDER BY tat.tarikh DESC,tat.kind) AS RowNumber 

FROM Anbar.tbl_Amaliat_Riz 
INNER JOIN Anbar.tbl_Amaliat_Title AS tat ON tat.ID = tbl_Amaliat_Riz.FK_Title
WHERE tat.FK_Salmali=@Year AND (tat.kind >=@Kind1 AND tat.kind<=@Kind2) 
) 
SELECT 
tkx.ID,
tkx.Code,
tkx.nerkh_frosh,
tkx.nerkh_frosh1,
tkx.nerkh_frosh2,
tkx.nerkh_frosh3,
tkx.kind,
z.LastPrice,
RTRIM(LTRIM(tkx.title	))	AS title,
RTRIM(LTRIM(tv.title	))	AS UnitTitle,
RTRIM(LTRIM(tgk2.title	))	AS MainGroupTitle,
RTRIM(LTRIM(tgk.title	))	AS SubGroupTitle,
Rtrim(Ltrim(tkx.barcode	))  AS barcode

FROM			Base.tbl_Kala_Xadamat	AS tkx 
LEFT OUTER JOIN	z									ON z.FK_Kala	= tkx.Code AND z.RowNumber=1
INNER JOIN Base.tbl_Vahed               AS tv       ON tv.ID        = tkx.FK_Vahed
INNER JOIN Base.tbl_GroupKala_2th       AS tgk      ON tgk.Code     = tkx.FK_GroupKala_2th
LEFT OUTER JOIN Base.tbl_GroupKala_1th  AS tgk2     ON tgk2.Code	= tgk.FK_GroupKala_1th


");

//------------------------------------------------------------
//------------------------------------------------------------

            SetItem(@"

WITH z AS 
(
SELECT 
FK_Kala,
nerkh AS LastPrice,
ROW_NUMBER() OVER (PARTITION BY FK_Kala ORDER BY tat.tarikh DESC,tat.kind) AS RowNumber 

FROM Anbar.tbl_Amaliat_Riz 
INNER JOIN Anbar.tbl_Amaliat_Title AS tat ON tat.ID = tbl_Amaliat_Riz.FK_Title
WHERE 
    tat.FK_Salmali=@Year 
    AND nerkh >0 
    AND FK_Kala =@FK_Kala
    AND (tat.kind >=@Kind1 AND tat.kind<=@Kind2) 
) 
SELECT z.FK_Kala as Code,
       z.LastPrice
	   FROM z
	   WHERE z.RowNumber=1
");

        }

    }
}
