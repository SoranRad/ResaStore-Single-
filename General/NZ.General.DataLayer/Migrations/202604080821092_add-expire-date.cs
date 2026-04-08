namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addexpiredate : DbMigration
    {
        public override void Up()
        {
            AddColumn("General.tbl_Info", "Expired", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("General.tbl_Info", "Expired");
        }
    }
}
