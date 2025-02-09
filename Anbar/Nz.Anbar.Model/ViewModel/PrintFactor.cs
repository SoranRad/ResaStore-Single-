using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace Nz.Anbar.Model.ViewModel
{
    public class PrintFactor
    {
        public long         ID                  { get; set; }
        public string       title               { get; set; }
        public string       codeMeli            { get; set; }
        public string       codePosti           { get; set; }
        public string       codeEqtesadi        { get; set; }
        public string       tel                 { get; set; }
        public string       mobile              { get; set; }
        public string       fax                 { get; set; }
        public string       addressHome         { get; set; }
        public string       telDowom            { get; set; }
        public string       mobDowom            { get; set; }
        public string       addresswork         { get; set; }

        public int          Serial              { get; set; }
        public byte         kind                { get; set; }
        public string       PersianTarix        { get; set; }
        public decimal      mablaq_KOl          { get; set; }
        public string       sharh               { get; set; }

        public int          radif               { get; set; }
        public int          FK_Kala             { get; set; }
        public decimal      meqdar              { get; set; }
        public decimal      nerkh               { get; set; }
        public decimal      takhfif             { get; set; }
        public decimal      takhfif_darsad      { get; set; }
        public decimal      mablaq              { get; set; }
        public string       ObjectTitle         { get; set; }
        public string       UnitTitle           { get; set; }

        public decimal      nerkh_frosh         { get; set; }
        public decimal?     nerkh_frosh1        { get; set; }
        public decimal?     nerkh_frosh2        { get; set; }
        public decimal?     nerkh_frosh3        { get; set; }


        public decimal?     Cheque              { get; set; }
        public decimal?     Cache               { get; set; }
        public decimal?     Pos                 { get; set; }

        public decimal?     mablaq_takhfif      { get; set; }
        public decimal?     Darsad_Takhfif      { get; set; }
        public decimal?     mablaq_Maliat       { get; set; }
        public decimal?     Darsad_Maliat       { get; set; }
        public decimal?     Ezafat              { get; set; }

        public decimal Remaind => mablaq_KOl - (Cheque ?? 0) - (Cache ?? 0) - (Pos ?? 0);

    }
}
