namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_sms_template : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "General.tbl_SmsTemplate",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Kind = c.Byte(nullable: false),
                        Message = c.String(maxLength: 700, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            //DropTable("General.tbl_SmsTemplate");
        }
    }
}
