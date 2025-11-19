namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("Anbar.tbl_Amaliat_Title", "FK_Anbar_Az", c => c.Short(nullable: false));
            AddColumn("Anbar.tbl_Amaliat_Title", "FK_Anbar_Be", c => c.Short());
            AddColumn("Anbar.tbl_Amaliat_Title", "FK_Tahvil_Girande", c => c.Long());
            AddColumn("Anbar.tbl_Amaliat_Title", "NoRemainEffect", c => c.Boolean(nullable: false));
            AddColumn("Anbar.tbl_Amaliat_Title_Detail", "FK_Mabna", c => c.Long());
            CreateIndex("Anbar.tbl_Amaliat_Title", "FK_Anbar_Az");
            CreateIndex("Anbar.tbl_Amaliat_Title", "FK_Anbar_Be");
            AddForeignKey("Anbar.tbl_Amaliat_Title", "FK_Anbar_Az", "Base.tbl_Base_Anbar", "ID", cascadeDelete: true);
            AddForeignKey("Anbar.tbl_Amaliat_Title", "FK_Anbar_Be", "Base.tbl_Base_Anbar", "ID");
            DropColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Az");
            DropColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Be");
        }
        
        public override void Down()
        {
            AddColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Be", c => c.Byte());
            AddColumn("Anbar.tbl_Amaliat_Riz", "FK_Anbar_Az", c => c.Byte(nullable: false));
            DropForeignKey("Anbar.tbl_Amaliat_Title", "FK_Anbar_Be", "Base.tbl_Base_Anbar");
            DropForeignKey("Anbar.tbl_Amaliat_Title", "FK_Anbar_Az", "Base.tbl_Base_Anbar");
            DropIndex("Anbar.tbl_Amaliat_Title", new[] { "FK_Anbar_Be" });
            DropIndex("Anbar.tbl_Amaliat_Title", new[] { "FK_Anbar_Az" });
            DropColumn("Anbar.tbl_Amaliat_Title_Detail", "FK_Mabna");
            DropColumn("Anbar.tbl_Amaliat_Title", "NoRemainEffect");
            DropColumn("Anbar.tbl_Amaliat_Title", "FK_Tahvil_Girande");
            DropColumn("Anbar.tbl_Amaliat_Title", "FK_Anbar_Be");
            DropColumn("Anbar.tbl_Amaliat_Title", "FK_Anbar_Az");
        }
    }
}
