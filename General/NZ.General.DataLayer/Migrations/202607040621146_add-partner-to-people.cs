namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpartnertopeople : DbMigration
    {
        public override void Up()
        {
            AddColumn("Base.tbl_Ashxas", "IsPartner", c => c.Boolean(nullable: false,defaultValue:false));
            AddColumn("Base.tbl_Ashxas", "PartnerPercent", c => c.Decimal(nullable: false, precision: 4, scale: 2,defaultValue:0));
        }
        
        public override void Down()
        {
            //DropColumn("Base.tbl_Ashxas", "PartnerPercent");
            //DropColumn("Base.tbl_Ashxas", "IsPartner");
        }
    }
}
