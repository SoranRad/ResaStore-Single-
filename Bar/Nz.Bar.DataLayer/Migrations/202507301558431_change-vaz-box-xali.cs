namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevazboxxali : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Bar.tbl_BarFactor", "VaznKhaliBox", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            //AlterColumn("Bar.tbl_BarFactor", "VaznKhaliBox", c => c.Decimal(nullable: false, precision: 18, scale: 0));
        }
    }
}
