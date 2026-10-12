namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_meqdar_kol_joz : DbMigration
    {
        public override void Up()
        {
            AddColumn("Anbar.tbl_Amaliat_Riz", "MeqdarKolBaste", c => c.Decimal(nullable: false, precision: 8, scale: 3,defaultValue:0));
            AddColumn("Anbar.tbl_Amaliat_Riz", "MeqdarKhordBaste", c => c.Decimal(nullable: false, precision: 8, scale: 3, defaultValue: 0));
        }
        
        public override void Down()
        {
            //DropColumn("Anbar.tbl_Amaliat_Riz", "MeqdarKhordBaste");
            //DropColumn("Anbar.tbl_Amaliat_Riz", "MeqdarKolBaste");
        }
    }
}
