namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changewebsitekind : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Base.tbl_Kala_Xadamat", "WebSiteProductKind", c => c.String());
        }
        
        public override void Down()
        {
            //AlterColumn("Base.tbl_Kala_Xadamat", "WebSiteProductKind", c => c.Byte());
        }
    }
}
