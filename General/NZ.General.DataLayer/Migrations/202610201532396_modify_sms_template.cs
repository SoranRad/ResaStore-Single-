namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify_sms_template : DbMigration
    {
        public override void Up()
        {
            AlterColumn("General.tbl_SmsTemplate", "Message", c => c.String(maxLength: 700, fixedLength: true));
        }
        
        public override void Down()
        {
            //AlterColumn("General.tbl_SmsTemplate", "Message", c => c.String(maxLength: 128, fixedLength: true));
        }
    }
}
