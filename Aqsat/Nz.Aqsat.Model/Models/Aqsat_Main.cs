using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Models
{
	public class Aqsat_Main  
	{
		public Aqsat_Main()
		{
			AqsatRizs = new HashSet<Aqsat_Riz>();
		}
		public long					ID							{ get; set; }
		public short				FK_Salmali					{ get; set; }
		public long					FK_Shaxs					{ get; set; }
		public long?				FK_Zamen					{ get; set; }
		public long?				FK_Faktor					{ get; set; }
		public short				FK_Noh						{ get; set; }
		public long					Serial						{ get; set; }
		public DateTime				Tarikh						{ get; set; }
		public byte					DoreQest					{ get; set; }
		public byte					RoundMablaq					{ get; set; }
		public decimal				MablaqAqsat					{ get; set; }
		public decimal				MablaqPishpardaxt			{ get; set; }
		public decimal				MablaqMandeAqsat			{ get; set; }
		public decimal				DarsadSoud					{ get; set; }
		public decimal				MablaqSoud					{ get; set; }
		public decimal				MablaqFinalAqsat			{ get; set; }
		public DateTime				StartDate					{ get; set; }
		public byte					TedadAqsat					{ get; set; }
		public string				Sharh						{ get; set; }
		public bool					IsTasvie					{ get; set; }

		public virtual Aqsat_Kind AqsatKind				{ get; set; }
		public virtual ICollection<Aqsat_Riz>	AqsatRizs		{ get; set; }

	}
}
