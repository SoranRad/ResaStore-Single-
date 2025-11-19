using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class DecreasePercentConfig : DapperEntityConfiguration<DecreasePrice>
    {
        public DecreasePercentConfig()
        {
            //===%
            this.SetList(@"

UPDATE Base.tbl_Kala_Xadamat
 SET nerkh_frosh = (CASE WHEN nerkh_frosh IS NULL	THEN NULL
					WHEN @nerx = 0					THEN nerkh_frosh
					ELSE (nerkh_frosh - nerkh_frosh * @Percent)-((nerkh_frosh - nerkh_frosh * @Percent)%1000)
					END),

     nerkh_frosh1 = (CASE WHEN nerkh_frosh1 IS NULL	THEN NULL
					WHEN @nerx1 = 0					THEN nerkh_frosh1
					ELSE (nerkh_frosh1 - nerkh_frosh1 * @Percent)-((nerkh_frosh1 - nerkh_frosh1 * @Percent)%1000)
					END)
WHERE ");
            //===$
            this.SetItem(@"

UPDATE Base.tbl_Kala_Xadamat
  SET nerkh_frosh = (CASE WHEN nerkh_frosh IS NULL	THEN NULL
					WHEN @nerx = 0					THEN nerkh_frosh
					ELSE (nerkh_frosh -  @Percent )-((nerkh_frosh -  @Percent)%1000)
					END),

	  nerkh_frosh1 = (CASE WHEN nerkh_frosh1 IS NULL	THEN NULL
					WHEN @nerx1 = 0					    THEN nerkh_frosh1
					ELSE ROUND(nerkh_frosh1 -  @Percent )-((nerkh_frosh1 -  @Percent)%1000)
					END)
WHERE  ");
        }
    }
    public class IncreasePercentConfig : DapperEntityConfiguration<IncreasePrice>
    {
        public IncreasePercentConfig()
        {
            //===%
            this.SetList(@"
UPDATE Base.tbl_Kala_Xadamat
 SET nerkh_frosh = (CASE WHEN nerkh_frosh IS NULL	THEN NULL
					WHEN @nerx = 0					THEN nerkh_frosh
					ELSE (nerkh_frosh + nerkh_frosh * @Percent )-((nerkh_frosh + nerkh_frosh * @Percent )%1000)
                    END),

     nerkh_frosh1 = (CASE WHEN nerkh_frosh1 IS NULL	THEN NULL
					WHEN @nerx1 = 0					THEN nerkh_frosh1
					ELSE (nerkh_frosh1 + nerkh_frosh1 * @Percent)-((nerkh_frosh1 + nerkh_frosh1 * @Percent)%1000)
					END)
WHERE ");
            //===$
            this.SetItem(@"
UPDATE Base.tbl_Kala_Xadamat
 SET nerkh_frosh =  (CASE WHEN nerkh_frosh IS NULL	THEN NULL
					WHEN @nerx = 0					THEN nerkh_frosh
					ELSE (nerkh_frosh +  @Percent )-((nerkh_frosh +  @Percent)%1000)
                    END),

	  nerkh_frosh1 = (CASE WHEN nerkh_frosh1 IS NULL	THEN NULL
					WHEN @nerx1 = 0					    THEN nerkh_frosh1
					ELSE  (nerkh_frosh1 +  @Percent )-((nerkh_frosh1 +  @Percent)%1000)
					END)
WHERE ");
        }
    }
}
