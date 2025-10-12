namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addwebsitefields : DbMigration
    {
        public override void Up()
        {
            AddColumn("Base.tbl_Kala_Xadamat", "WebSiteProductKind", c => c.Byte());
            AddColumn("Base.tbl_Kala_Xadamat", "WebSiteProductId1", c => c.Long());
            AddColumn("Base.tbl_Kala_Xadamat", "WebSiteProductId2", c => c.Long());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "WebSiteId", c => c.Long());
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "Address");
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "WebSiteId");
            DropColumn("Base.tbl_Kala_Xadamat", "WebSiteProductId2");
            DropColumn("Base.tbl_Kala_Xadamat", "WebSiteProductId1");
            DropColumn("Base.tbl_Kala_Xadamat", "WebSiteProductKind");
        }
    }
}
