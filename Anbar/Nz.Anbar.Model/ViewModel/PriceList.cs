using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.ViewModel
{
    public class PriceList
    {
        public long         ID                  { get; set; }
        public byte         kind                { get; set; }
        public int          Code                { get; set; }
        public decimal      nerkh_frosh         { get; set; }
        public decimal      nerkh_frosh1        { get; set; }
        public decimal      nerkh_frosh2        { get; set; }
        public decimal      nerkh_frosh3        { get; set; }
        public decimal      LastPrice           { get; set; }
        public string       title               { get; set; }
        public string       barcode             { get; set; }

        public string       UnitTitle           { get; set; }
        public string       MainGroupTitle      { get; set; }
        public string       SubGroupTitle       { get; set; }
        public string       KindTitle           => ((Enums.NzObjectKind)this.kind).NzTostring();

        public int          RCode                =>this.Code;
        public decimal      RLastPrice           =>this.LastPrice;
        public string       Rtitle               =>this.title;
        public string       RUnitTitle           =>this.UnitTitle;
        public string       RMainGroupTitle      =>this.MainGroupTitle;
        public string       RSubGroupTitle       =>this.SubGroupTitle;
        public string       RKindTitle           =>this.KindTitle;
        public string       Rbarcode             =>this.barcode;
    }
}
