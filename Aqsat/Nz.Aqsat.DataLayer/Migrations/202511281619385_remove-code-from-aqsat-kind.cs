namespace Nz.Aqsat.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removecodefromaqsatkind : DbMigration
    {
        public override void Up()
        {
            DropColumn("Aqsat.tbl_Aqsat_Kind", "Code");
        }
        
        public override void Down()
        {
            AddColumn("Aqsat.tbl_Aqsat_Kind", "Code", c => c.Short(nullable: false));
        }
    }
}
