namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changecolumntypedecimal : DbMigration
    {
        public override void Up()
        {
            AddColumn("Bar.tbl_BarFactor", "VaznKHales", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("Bar.tbl_BarFactor", "VaznPorMachine", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("Bar.tbl_BarFactor", "VaznKHaliMachine", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("Bar.tbl_BarFactor", "TedadBox", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("Bar.tbl_BarFactor", "VaznKhaliBox", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("Bar.tbl_BarFactor", "VaznOft", c => c.Decimal(nullable: false, precision: 18, scale: 0));
        }
        
        public override void Down()
        {
            AlterColumn("Bar.tbl_BarFactor", "VaznOft", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("Bar.tbl_BarFactor", "VaznKhaliBox", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("Bar.tbl_BarFactor", "TedadBox", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("Bar.tbl_BarFactor", "VaznKHaliMachine", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("Bar.tbl_BarFactor", "VaznPorMachine", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("Bar.tbl_BarFactor", "VaznKHales");
        }
    }
}
