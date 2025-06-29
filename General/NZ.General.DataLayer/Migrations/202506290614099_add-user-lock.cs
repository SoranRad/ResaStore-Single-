namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserlock : DbMigration
    {
        public override void Up()
        {
            AddColumn("General.tbl_User", "LockAccount", c => c.Boolean(nullable: false,defaultValue:false));
            AddColumn("General.tbl_User", "LockTime", c => c.Short(nullable: false,defaultValue:2));
        }
        
        public override void Down()
        {
            DropColumn("General.tbl_User", "LockTime");
            DropColumn("General.tbl_User", "LockAccount");
        }
    }
}
