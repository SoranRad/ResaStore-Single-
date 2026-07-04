namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addamanitofactordetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "IsAmani", c => c.Boolean(nullable: false,defaultValue:false));
        }
        
        public override void Down()
        {
            //DropColumn("Anbar.tbl_Amaliat_Title_Detail", "IsAmani");
        }
    }
}
