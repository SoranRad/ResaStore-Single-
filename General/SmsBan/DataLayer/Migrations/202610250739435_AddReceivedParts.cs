namespace SmsBan.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReceivedParts : DbMigration
    {
        public override void Up()
        {
            AddColumn("SmsBan.tbl_SmsInbox", "ReceivedParts", c => c.String(maxLength: 512, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("SmsBan.tbl_SmsInbox", "ReceivedParts");
        }
    }
}
