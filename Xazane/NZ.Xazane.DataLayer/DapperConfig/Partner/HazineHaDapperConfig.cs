using ShareLib.Interfaces;
using ShareLib.Models.Report;

namespace NZ.Xazane.DataLayer.DapperConfig.Partner
{
	public class HazineHaDapperConfig : DapperEntityConfiguration<HazineHa>
	{
		public HazineHaDapperConfig()
		{
			SetItem(@"

DECLARE @SumHazineHa DECIMAL = 0;

SELECT  SUM(tax.mablaq) as SumHazineHa

FROM    Xazane.tbl_Amaliat_Xazaneh AS tax 

WHERE
    tax.FK_Salmali  = @Year 
AND tax.kind        = 4
AND (tax.tarikh >= @Start   OR @Start   IS NULL)
AND (tax.tarikh <= @End     OR @End     IS NULL)

");
		}
	}
}
