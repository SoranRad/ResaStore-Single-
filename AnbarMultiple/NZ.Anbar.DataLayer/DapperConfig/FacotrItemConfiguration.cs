using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig
{
    public class FacotrItemConfiguration : DapperEntityConfiguration<FactorItem>
    {
        public FacotrItemConfiguration()
        {
            this.SetList(@"
SELECT tar.ID ,
       tar.FK_Kala ,
       tar.radif ,
       tar.meqdar ,
       tar.nerkh ,
       tar.takhfif ,
       tar.takhfif_darsad ,
       tar.mablaq ,
       RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
	   RTRIM(LTRIM(tv.title)) AS UnitTitle,
	   tar.Remain,
	   tar.nerkh_2,
	   RTRIM(LTRIM(tar.CostDescriptor)) AS CostDescriptor

	   
FROM Anbar.tbl_Amaliat_Riz AS tar
INNER JOIN Base.tbl_Kala_Xadamat AS tkx ON tkx.Code = tar.FK_Kala
INNER JOIN Base.tbl_Vahed AS tv ON tv.ID = tkx.FK_Vahed

WHERE tar.FK_Title=@ID
");
        }
    }
}
