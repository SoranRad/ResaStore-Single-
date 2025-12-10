namespace Nz.Aqsat.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsharhtoaqsat0item : DbMigration
    {
        public override void Up()
        {
            AddColumn("Aqsat.tbl_Aqsat_Riz", "Sharh", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Aqsat.tbl_Aqsat_Riz", "Sharh");
        }
    }
}
