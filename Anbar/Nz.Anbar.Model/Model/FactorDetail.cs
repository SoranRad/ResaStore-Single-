using ShareLib;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class FactorDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long                 ID                  { get; set; }
        public short?               FK_User_Edit        { get; set; }
        public DateTime?            tarikh_edit         { get; set; }
        public decimal?             mablaq_takhfif      { get; set; }
        public decimal?             mablaq_Maliat       { get; set; }
        public decimal?             Darsad_Maliat       { get; set; }
        public decimal?             Darsad_Takhfif      { get; set; }
        public decimal?             Ezafat              { get; set; }
        public long?                FK_Vaset            { get; set; }
        public decimal?             Darsad_Porsant      { get; set; }
        [Column(TypeName = "date")]
        public DateTime?            tarikh_etebar       { get; set; }
        public FactorHead           FactorHead          { get; set; }

        [NotMapped]
        public Enums.NzItemState    State               { get; set; }
    }
}
