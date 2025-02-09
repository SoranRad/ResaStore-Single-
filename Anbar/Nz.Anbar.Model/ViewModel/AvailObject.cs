using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.ViewModel
{
    public class AvailObject 
    {
        public long         ID                  { get; set; }
        public short        FK_GroupKala_2th    { get; set; }
        public short        FK_Vahed            { get; set; }
        public byte         kind                { get; set; }
        public int          Code                { get; set; }
        public decimal?     point_bohrani       { get; set; }
        public bool         is_disabled         { get; set; }
        public decimal      nerkh_frosh         { get; set; }
        public decimal?     nerkh_frosh1        { get; set; }
        public decimal?     nerkh_frosh2        { get; set; }
        public decimal?     nerkh_frosh3        { get; set; }
        public decimal      remaind             { get; set; }
        public long?        FK_Image            { get; set; }

        public string       title               { get; set; }
        public string       barcode             { get; set; }
        public string       nameFani            { get; set; }
        public string       codeFani            { get; set; }
        public string       keshvarSazande      { get; set; }

        public string       UnitTitle           { get; set; }
        public string       MainGroupTitle      { get; set; }
        public string       SubGroupTitle       { get; set; }

        public decimal       Zarib              { get; set; }
        public short?        FK_Vahed_Fari      { get; set; }
        public string        Unit2Title         { get; set; }
       
    }
}
