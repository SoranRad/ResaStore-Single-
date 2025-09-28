namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesubgroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("Base.tbl_GroupKala_2th", "ShowInBarcode", c => c.Boolean(nullable: false,defaultValue:false));
        }
        
        public override void Down()
        {
            DropColumn("Base.tbl_GroupKala_2th", "ShowInBarcode");
        }
    }
}
