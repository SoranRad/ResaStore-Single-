namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddKerayeMablaq : DbMigration
    {
        public override void Up()
        {
            AddColumn("Bar.tbl_BarFactor", "MablaqKeraye", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("Bar.tbl_BarFactor", "MablaqKeraye");
        }
    }
}
