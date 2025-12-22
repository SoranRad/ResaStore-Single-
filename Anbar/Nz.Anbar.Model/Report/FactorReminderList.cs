using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class FactorReminderList
    {
	    public long ID { get; set; }
	    public int Serial { get; set; }
	    public short kind { get; set; }
	    public string PersianStr { get; set; }
	    public string MohlatPersianStr { get; set; }

	    public long? FK_AshXas_ID { get; set; }
	    public string Customer { get; set; }
	    public decimal mablaq { get; set; }

	    public decimal? Cheque { get; set; }
	    public decimal? Cache { get; set; }
	    public decimal? Pos { get; set; }
	    public decimal? Takhfif { get; set; }


	    public string KindTitle => ((Enums.NzFactorKind)this.kind).NzToString();
	    public decimal Remaind => mablaq - (Cheque ?? 0) - (Cache ?? 0) - (Pos ?? 0);
	}
}
