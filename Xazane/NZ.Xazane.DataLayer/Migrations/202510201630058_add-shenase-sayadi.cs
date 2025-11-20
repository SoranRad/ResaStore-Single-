namespace NZ.Xazane.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addshenasesayadi : DbMigration
    {
        public override void Up()
        {
            AddColumn("Xazane.tbl_Amaliat_Check", "Shenase_Sayadi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Xazane.tbl_Amaliat_Check", "Shenase_Sayadi");
        }
    }
}
