using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class PurchaceAnalyzeConfig :  DapperEntityConfiguration<PurchaceAnalyze>
    {
        public PurchaceAnalyzeConfig()
        {
            SetList(@"

SELECT tar.ID ,
       tar.FK_Kala ,
       tar.radif ,
       tar.meqdar ,
       tar.nerkh ,
       tar.takhfif ,
       tar.takhfif_darsad ,
       tar.mablaq ,
	   tar.Remain,
       RTRIM(LTRIM(tar.CostDescriptor)) AS CostDescriptor,
       RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
	   RTRIM(LTRIM(tv.title)) AS UnitTitle

	   
FROM Anbar.tbl_Amaliat_Riz          AS tar
INNER JOIN Base.tbl_Kala_Xadamat    AS tkx  ON tkx.Code = tar.FK_Kala
INNER JOIN Base.tbl_Vahed           AS tv   ON tv.ID    = tkx.FK_Vahed

WHERE tar.FK_Title = @ID


");
        }
    }
}
