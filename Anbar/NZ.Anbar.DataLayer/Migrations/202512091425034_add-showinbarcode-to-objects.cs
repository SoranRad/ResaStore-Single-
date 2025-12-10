namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addshowinbarcodetoobjects : DbMigration
    {
        public override void Up()
        {
            AddColumn("Base.tbl_Kala_Xadamat", "ShowInBarcodeForm", c => c.Boolean(nullable: false,defaultValue:false));
        }
        
        public override void Down()
        {
            DropColumn("Base.tbl_Kala_Xadamat", "ShowInBarcodeForm");
        }
    }
}
