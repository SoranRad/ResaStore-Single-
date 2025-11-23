namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyfactorobject : DbMigration
    {
        public override void Up()
        {
            AddColumn("Base.tbl_Kala_Xadamat", "IsOffActive", c => c.Boolean(nullable: false));
            AddColumn("Base.tbl_Kala_Xadamat", "IsOffPercent", c => c.Boolean(nullable: false));
            AddColumn("Base.tbl_Kala_Xadamat", "OffAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));

            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "TitleGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "MobileGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "AddressGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "Sent", c => c.Boolean());
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "Address");
        }
        
        public override void Down()
        {
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "Address", c => c.String());
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "Sent");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "AddressGirande");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "MobileGirande");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "TitleGirande");
            DropColumn("Base.tbl_Kala_Xadamat", "OffAmount");
            DropColumn("Base.tbl_Kala_Xadamat", "IsOffPercent");
            DropColumn("Base.tbl_Kala_Xadamat", "IsOffActive");
        }
    }
}
