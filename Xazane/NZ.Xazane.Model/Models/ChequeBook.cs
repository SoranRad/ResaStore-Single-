using MS_Control.Tarikh;
using ShareLib.Interfaces;

namespace NZ.Xazane.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class ChequeBook : ISqlQueryMaker
    {
        public    ChequeBook    ()
        {
            ChequeBookDetails = new HashSet<ChequeBookDetail>();
        }

        public int                  ID             { get; set; }
        public int                  FK_Xazaneh     { get; set; }
        public short                Code           { get; set; }
        [Column(TypeName = "date")]
        public DateTime             Tarikh_Tahvil  { get; set; }
        
        public int                  Start_Serial   { get; set; }
        [StringLength(250)]
        public string               Sharh          { get; set; }
        public bool                 Is_Disable     { get; set; }

        
        public ICollection<ChequeBookDetail>    ChequeBookDetails { get; set; }
        public Accounts                         Account                 { get; set; }



        [NotMapped]
        public byte                 Tedad_Barge    { get; set; }
        [NotMapped]
        public string               Title          { get; set; }
        [NotMapped]
        public string               PersianDate     =>new MS_Structure_Shamsi(this.Tarikh_Tahvil).ToShamsi();
        [NotMapped]
        public string               StateTitle      => this.Is_Disable ? "غیر فعال" : "فعال";



        public string GetItem()
        {
            return @"";
        }
        public string GetList()
        {
            return @"
            SELECT tdc.ID ,
               tdc.FK_Xazaneh ,
               tdc.Code ,
               tdc.Tarikh_Tahvil ,
               COUNT(tdcr.ID) AS Tedad_Barge ,
               tdc.Start_Serial ,
                rtrim(LTRIM( tdc.Sharh)) as Sharh,
	            rtrim(LTRIM( thx.title))+' '
	           +rtrim(LTRIM(ISNULL(thx.Shomare_Hesab,''))) 
			   AS Title ,
               tdc.Is_Disable 
	           
	           FROM Xazane.tbl_Daste_Chque					AS tdc
	           INNER JOIN Xazane.tbl_Daste_Cheque_Riz		AS tdcr ON tdcr.FK_Dasteh_Cheque = tdc.ID 
	           INNER JOIN Xazane.tbl_Hesab_Xazaneh			AS thx	ON thx.ID = tdc.FK_Xazaneh
	           WHERE tdc.FK_Salmali =@Year
            GROUP BY tdc.Code ,
                     tdc.FK_Salmali ,
                     tdc.FK_Xazaneh ,
                     tdc.ID ,
                     tdc.Is_Disable ,
                     tdc.Sharh ,
                     tdc.Start_Serial ,
                     tdc.Tarikh_Tahvil ,
                     tdc.Tedad_Barge,
	        		 thx.title,
	        		 thx.Shomare_Hesab";
        }
    }
}
