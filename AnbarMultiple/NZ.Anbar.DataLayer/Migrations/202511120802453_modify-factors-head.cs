namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyfactorshead : DbMigration
    {
        public override void Up()
        {
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "TitleGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "MobileGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "AddressGirande", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "Sent", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "Sent");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "AddressGirande");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "MobileGirande");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "TitleGirande");
        }
    }
}
