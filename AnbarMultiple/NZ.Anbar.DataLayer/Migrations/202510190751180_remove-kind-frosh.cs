namespace NZ.Anbar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removekindfrosh : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Anbar.tbl_Amaliat_Title DROP CONSTRAINT IF EXISTS FK_tbl_Amaliat_Title_tbl_Kind_Frosh", true);
            Sql("DROP TABLE IF EXISTS Base.tbl_Kind_Frosh", true);
            //DropTable("Base.tbl_Kind_Frosh");
        }
        
        public override void Down()
        {
            CreateTable(
                "Base.tbl_Kind_Frosh",
                c => new
                    {
                        ID = c.Short(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100, fixedLength: true),
                        Is_Disable = c.Boolean(nullable: false),
                        Kind = c.Byte(nullable: false),
                        FK_Salmali = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("Anbar.tbl_Amaliat_Title", "FK_Kind_Frosh");
            AddForeignKey("Anbar.tbl_Amaliat_Title", "FK_Kind_Frosh", "Base.tbl_Kind_Frosh", "ID");
        }
    }
}
