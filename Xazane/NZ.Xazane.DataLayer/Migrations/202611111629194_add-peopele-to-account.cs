namespace NZ.Xazane.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addpeopeletoaccount : DbMigration
    {
        public override void Up()
        {
            //AddColumn("Xazane.tbl_Hesab_Xazaneh", "FK_People", c => c.Long());
            Sql("ALTER TABLE Xazane.tbl_Hesab_Xazaneh ADD FK_People bigint NULL", true);
            Sql(@"
ALTER TABLE Xazane.tbl_Hesab_Xazaneh WITH NOCHECK ADD CONSTRAINT
	FK_tbl_Hesab_Xazaneh_tbl_Ashxas FOREIGN KEY
	(
	FK_People
	) REFERENCES Base.tbl_Ashxas
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
", true);
		}
        
        public override void Down()
        {
            //DropColumn("Xazane.tbl_Hesab_Xazaneh", "FK_People");
        }
    }
}
