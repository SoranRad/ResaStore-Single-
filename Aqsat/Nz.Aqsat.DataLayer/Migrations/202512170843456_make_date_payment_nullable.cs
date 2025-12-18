namespace Nz.Aqsat.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class make_date_payment_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Aqsat.tbl_Aqsat_Riz", "tarixPardaxt", c => c.DateTime(nullable:true));
        }
        
        public override void Down()
        {
            AlterColumn("Aqsat.tbl_Aqsat_Riz", "tarixPardaxt", c => c.DateTime(nullable: false));
        }
    }
}
