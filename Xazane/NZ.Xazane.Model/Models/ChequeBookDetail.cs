namespace NZ.Xazane.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class ChequeBookDetail
    {
        public long          ID                     { get; set; }
        public int           FK_Dasteh_Cheque       { get; set; }
        public int           Serial                 { get; set; }

        public byte          Vaziat                 { get; set; }

        [StringLength(250)]
        public string Sharh                         { get; set; }

        public ChequeBook   ChequeBooks             { get; set; }

        public ICollection<Models.ChequeOperation> ChequeOP { get; set; }

    }
}
