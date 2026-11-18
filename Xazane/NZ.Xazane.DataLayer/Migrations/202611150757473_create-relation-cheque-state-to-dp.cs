namespace NZ.Xazane.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createrelationchequestatetodp : DbMigration
    {
        public override void Up()
        {
            //CreateIndex("Xazane.tbl_Amaliat_Check", "FK_DP_Vagozari");
            //AddForeignKey("Xazane.tbl_Amaliat_Check", "FK_DP_Vagozari", "Xazane.tbl_Amaliat_DP", "ID");
            Sql(@"

ALTER TABLE Xazane.tbl_Amaliat_Check ADD CONSTRAINT
FK_tbl_Amaliat_Check_tbl_Amaliat_DP1 FOREIGN KEY
(
    FK_DP_Vagozari
) REFERENCES Xazane.tbl_Amaliat_DP
(
    ID
) 
ON UPDATE  NO  ACTION 
ON DELETE  NO  ACTION  

", true);
        }
        
        public override void Down()
        {
            //DropForeignKey("Xazane.tbl_Amaliat_Check", "FK_DP_Vagozari", "Xazane.tbl_Amaliat_DP");
            //DropIndex("Xazane.tbl_Amaliat_Check", new[] { "FK_DP_Vagozari" });
        }
    }
}
