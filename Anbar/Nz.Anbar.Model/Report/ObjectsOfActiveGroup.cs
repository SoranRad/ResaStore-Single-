using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
	public class ObjectsOfActiveGroup
	{
		

        public long         ID                  { get; set; }
        public short        FK_GroupKala_2th    { get; set; }
        public byte         kind                { get; set; }
        public int          Code                { get; set; }
        public bool         is_disabled         { get; set; }
        public decimal      nerkh_frosh         { get; set; }
        public decimal?     nerkh_frosh1        { get; set; }
        public decimal?     nerkh_frosh2        { get; set; }
        public decimal?     nerkh_frosh3        { get; set; }

        public string       title               { get; set; }

        public string       SubGroupTitle       { get; set; }

        public string       KindTitle           => ((Enums.NzObjectKind)this.kind).NzTostring();
        public string       StateTitle          => this.is_disabled ? "غیر فعال " : "فعال";
	}
}
