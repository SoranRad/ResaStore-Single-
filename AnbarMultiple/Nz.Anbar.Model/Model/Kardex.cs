namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Anbar.tbl_Amaliat_Kardex")]
    public partial class Kardex
    {
        public Kardex()
        {
            SubKardex = new HashSet<Kardex>();
        }

        public long         ID                          { get; set; }
        public short        FK_Salmali                  { get; set; }
        public long         FK_Riz                      { get; set; }
        public int          FK_Kala                     { get; set; }
        public long?        FK_Parent_Varede            { get; set; }
        public byte         FK_Anbar                    { get; set; }
        public byte         kind                        { get; set; }
        public byte?        kind_enteqal                { get; set; }
        [Column(TypeName = "date")]
        public DateTime     tarikh                      { get; set; }
        public decimal?     nerkh                       { get; set; }
        public decimal?     nerkh_mande_miangin         { get; set; }
        public decimal?     meqdar                      { get; set; }
        public decimal?     meqdar_mande_miangin        { get; set; }
        public decimal?     meqdar_mande_miani_Fari     { get; set; }
        public decimal?     meqdar_mande_varede         { get; set; }
        public decimal?     meqdar_mandeh_radif         { get; set; }
        public decimal?     meqdar_mande_varede_fari    { get; set; }
        public decimal?     meqdar_mandeh_radif_fari    { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[]               rowversion              { get; set; }
        public FactorItem           FactorItem              { get; set; }
        public ICollection<Kardex>  SubKardex               { get; set; }
        public Kardex               ParentKardex            { get; set; }
    }
}
