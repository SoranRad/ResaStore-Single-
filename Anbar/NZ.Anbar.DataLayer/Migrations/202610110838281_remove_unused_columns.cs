namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remove_unused_columns : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Anbar.tbl_Amaliat_Riz", "FK_Vahed", "Base.tbl_Vahed");
            DropIndex("Anbar.tbl_Amaliat_Riz", new[] { "FK_Vahed" });
            DropColumn("Base.tbl_Kala_Xadamat", "FK_Vahed_Fari");
            DropColumn("Anbar.tbl_Amaliat_Riz", "FK_Vahed");
            DropColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Az");
            DropColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Be");
            DropColumn("Anbar.tbl_Amaliat_Riz", "kind");
            DropColumn("Anbar.tbl_Amaliat_Riz", "CostDescriptor");
        }
        
        public override void Down()
        {
            AddColumn("Anbar.tbl_Amaliat_Riz", "CostDescriptor", c => c.String());
            AddColumn("Anbar.tbl_Amaliat_Riz", "kind", c => c.Byte());
            AddColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Be", c => c.Byte());
            AddColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Az", c => c.Byte(nullable: false));
            AddColumn("Anbar.tbl_Amaliat_Riz", "FK_Vahed", c => c.Short());
            AddColumn("Base.tbl_Kala_Xadamat", "FK_Vahed_Fari", c => c.Short());
            CreateIndex("Anbar.tbl_Amaliat_Riz", "FK_Vahed");
            AddForeignKey("Anbar.tbl_Amaliat_Riz", "FK_Vahed", "Base.tbl_Vahed", "ID");
        }
    }
}
