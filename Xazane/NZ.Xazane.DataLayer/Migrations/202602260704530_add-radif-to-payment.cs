namespace NZ.Xazane.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addradiftopayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("Xazane.tbl_Amaliat_DP", "Fk_Factor_radif_Id", c => c.Long());
        }
        
        public override void Down()
        {
            
        }
    }
}
