using System.ComponentModel;
using ShareLib;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    
    public class FactorItem
    {
        public FactorItem()
        {
            KardexItems  =   new HashSet<Kardex>();
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long         ID                   { get; set; }
        public long         FK_Title             { get; set; }
        public short        FK_Salmali           { get; set; }
        public int          FK_Kala              { get; set; }
        public short?       FK_Vahed             { get; set; }
        [DefaultValue(1)]
        public byte         FK_Anbar_Az          { get; set; }
        public byte?        FK_Anbar_Be          { get; set; }
        public byte?        kind                 { get; set; }
        public int          radif                { get; set; }
        public decimal      meqdar               { get; set; }
        public decimal      nerkh                { get; set; }
        public decimal      nerkh_2              { get; set; }
        public decimal      takhfif              { get; set; }
        public decimal      takhfif_darsad       { get; set; }
        public decimal      mablaq               { get; set; }
        public decimal      Remain               { get; set; }
        public string       CostDescriptor       { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[]               rowversion      { get; set; }

        public ICollection<Kardex>  KardexItems     { get; set; }
        public FactorHead           FactorHead      { get; set; }
        public Unit                 Unit            { get; set; }

        [NotMapped]
        public string               ObjectTitle     { get; set; }
        [NotMapped]
        public string               UnitTitle       { get; set; }
        [NotMapped]
        public Enums.NzItemState    State           { get; set; }
        [NotMapped]
        public byte                 StateID         => (byte) this.State;


        public void RefreshAmounts(decimal Nerkh)
        {
	        var price = meqdar * Nerkh;
	        decimal takhfif = (takhfif_darsad > 0)
		                        ? Math.Round(price * takhfif_darsad / 100)
		                        : this.takhfif;

	        var mablaq = price - takhfif;

	        this.takhfif    = takhfif;
            this.mablaq     = mablaq;
        }
    }
}
