using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig
{
    public class FactorDapperConfig :DapperEntityConfiguration<FactorHead>
    {
        private static string List          = @"";


        private static string Item          = @"

SELECT tat.ID ,
       tat.FK_Salmali ,
       tat.FK_User_Add ,
       tat.FK_AshXas_ID ,
       tat.FK_Kind_Frosh ,
       tat.Serial ,
       tat.kind ,
       tat.tarikh ,
       tat.tarikh_add ,
       tat.mablaq ,
       LTRIM(RTRIM(tat.sharh )) AS sharh ,
       tat.is_ok,
       tat.FK_Location,
       tat.FK_Mabna

FROM Anbar.tbl_Amaliat_Title AS tat
WHERE tat.ID = @ID;

SELECT tar.ID ,
       tar.FK_Title ,
       tar.FK_Salmali ,
       tar.FK_Kala ,
       tar.FK_Vahed ,
       tar.FK_Anbar_Az ,
       tar.FK_Anbar_Be ,
       tar.kind ,
       tar.radif ,
       tar.meqdar ,
       tar.nerkh ,
       tar.nerkh_2 ,
       tar.takhfif ,
       tar.takhfif_darsad ,
       tar.mablaq ,

       tar.rowversion,
	   RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
	   RTRIM(LTRIM(tv.title)) AS UnitTitle,
	   tar.Remain,
	   tar.nerkh_2,
	   RTRIM(LTRIM(tar.CostDescriptor)) AS CostDescriptor




FROM Anbar.tbl_Amaliat_Riz AS tar
INNER JOIN Base.tbl_Kala_Xadamat AS tkx ON  tkx.Code = tar.FK_Kala
INNER JOIN Base.tbl_Vahed AS tv ON tv.ID = tkx.FK_Vahed
WHERE tar.FK_Title =@ID;

SELECT tatd.ID ,
       tatd.FK_User_Edit ,
       tatd.tarikh_edit ,
       tatd.tarikh_etebar ,
       tatd.mablaq_takhfif ,
       tatd.mablaq_Maliat ,
       tatd.Darsad_Maliat ,
       tatd.Darsad_Takhfif ,
       tatd.FK_Vaset ,
       tatd.Ezafat,
       tatd.Darsad_Porsant 
	   
FROM Anbar.tbl_Amaliat_Title_Detail AS tatd
WHERE tatd.ID=@ID ;
";

        private static string MaxSerial     = @"
SELECT MAX(tat.Serial) FROM Anbar.tbl_Amaliat_Title AS tat
WHERE tat.FK_Salmali=@Year AND tat.kind=@Kind
";

        private static string CodeUnique    = @"
SELECT COUNT(tat.Serial) FROM Anbar.tbl_Amaliat_Title AS tat
WHERE tat.FK_Salmali=@Year AND tat.kind=@Kind AND tat.Serial=@Serial
";

        public FactorDapperConfig()
        {
            this.SetList        (List)
                .SetItem        (Item)
                .SetCodeUnique  (CodeUnique)
                .SetMaxSerial   (MaxSerial);
        }
    }
}
