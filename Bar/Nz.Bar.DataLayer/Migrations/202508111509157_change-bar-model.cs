namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changebarmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("Bar.tbl_BarFactor", "SumKhaliBox", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AddColumn("Bar.tbl_BarFactor", "DarsadOft", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            //DropColumn("Bar.tbl_BarFactor", "DarsadOft");
            //DropColumn("Bar.tbl_BarFactor", "SumKhaliBox");
        }
    }
}
