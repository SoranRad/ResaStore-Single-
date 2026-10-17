namespace SmsBan.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
                public override void Up()
        {
            // ساخت Schema در صورت نبودن؛ تا نیازی به ساخت دستی نباشد.
            Sql("IF NOT EXISTS (SELECT 1 FROM sys.schemas WHERE name = N'SmsBan') " +
                "EXEC(N'CREATE SCHEMA [SmsBan] AUTHORIZATION [dbo];');");
CreateTable(
                "SmsBan.tbl_SmsArchive",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        OutboxID = c.Long(),
                        SortOrder = c.Decimal(nullable: false, precision: 18, scale: 6),
                        Priority = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 32),
                        MessageText = c.String(),
                        PageCount = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        RetryCount = c.Int(nullable: false),
                        ErrorMessage = c.String(maxLength: 1024),
                        SmsReference = c.String(maxLength: 64),
                        IsDelivered = c.Boolean(nullable: false),
                        DeliveredAt = c.DateTime(),
                        DeliveredAtShamsi = c.String(maxLength: 19, unicode: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedAtShamsi = c.String(maxLength: 19, unicode: false),
                        SentAt = c.DateTime(),
                        SentAtShamsi = c.String(maxLength: 19, unicode: false),
                        DurationMs = c.Int(),
                        ModemDevice = c.String(maxLength: 128),
                        EnqueuedBy = c.String(maxLength: 128),
                        SentBy = c.String(maxLength: 128),
                        SendInterval = c.Int(nullable: false),
                        RetryTimes = c.Int(nullable: false),
                        SmsValidity = c.Int(nullable: false),
                        SmsCenter = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.Status, t.SentAt })
                .Index(t => t.SentAt);
            
            CreateTable(
                "SmsBan.tbl_SmsInbox",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        ModemIndex = c.Int(nullable: false),
                        SmsCenter = c.String(maxLength: 32),
                        SmsType = c.String(maxLength: 64),
                        TelNumber = c.String(maxLength: 32),
                        TimeStamp = c.String(maxLength: 32),
                        Discharge = c.String(maxLength: 32),
                        SmsText = c.String(),
                        TPPid = c.String(maxLength: 8),
                        TPDcs = c.String(maxLength: 8),
                        TPVp = c.String(maxLength: 8),
                        TPSt = c.String(maxLength: 8),
                        SReference = c.String(maxLength: 64),
                        AllPart = c.Int(nullable: false),
                        PartNo = c.Int(nullable: false),
                        DeviceName = c.String(maxLength: 128),
                        SimId = c.String(maxLength: 64),
                        DedupHash = c.String(maxLength: 64, unicode: false),
                        ReceivedAt = c.DateTime(nullable: false),
                        ReceivedAtShamsi = c.String(maxLength: 19, unicode: false),
                        IsRead = c.Boolean(nullable: false),
                        IsDeletedFromModem = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.DedupHash, unique: true)
                .Index(t => t.ReceivedAt);
            
            CreateTable(
                "SmsBan.tbl_SmsOutbox",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        SortOrder = c.Decimal(nullable: false, precision: 18, scale: 6),
                        Priority = c.Int(nullable: false),
                        PhoneNumber = c.String(maxLength: 32),
                        MessageText = c.String(),
                        PageCount = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        RetryCount = c.Int(nullable: false),
                        LastError = c.String(maxLength: 1024),
                        CreatedAt = c.DateTime(nullable: false),
                        CreatedAtShamsi = c.String(maxLength: 19, unicode: false),
                        EnqueuedBy = c.String(maxLength: 128),
                        LockedBy = c.String(maxLength: 128),
                        LockedAt = c.DateTime(),
                        LockedAtShamsi = c.String(maxLength: 19, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.Status, t.SortOrder });
            
            CreateTable(
                "SmsBan.tbl_SmsRateCounter",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        PeriodType = c.Int(nullable: false),
                        PeriodKey = c.String(maxLength: 20, unicode: false),
                        PeriodKeyShamsi = c.String(maxLength: 20, unicode: false),
                        PeriodStart = c.DateTime(nullable: false),
                        PeriodStartShamsi = c.String(maxLength: 19, unicode: false),
                        PageCount = c.Int(nullable: false),
                        MessageCount = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => new { t.PeriodType, t.PeriodKey }, unique: true);
            
            CreateTable(
                "SmsBan.tbl_SmsWorkerState",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IsPaused = c.Boolean(nullable: false),
                        PausedAt = c.DateTime(),
                        PausedAtShamsi = c.String(maxLength: 19, unicode: false),
                        PausedBy = c.String(maxLength: 128),
                        ModemDevice = c.String(maxLength: 128),
                        OwnerID = c.String(maxLength: 128),
                        Heartbeat = c.DateTime(),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropIndex("SmsBan.tbl_SmsRateCounter", new[] { "PeriodType", "PeriodKey" });
            DropIndex("SmsBan.tbl_SmsOutbox", new[] { "Status", "SortOrder" });
            DropIndex("SmsBan.tbl_SmsInbox", new[] { "ReceivedAt" });
            DropIndex("SmsBan.tbl_SmsInbox", new[] { "DedupHash" });
            DropIndex("SmsBan.tbl_SmsArchive", new[] { "SentAt" });
            DropIndex("SmsBan.tbl_SmsArchive", new[] { "Status", "SentAt" });
            DropTable("SmsBan.tbl_SmsWorkerState");
            DropTable("SmsBan.tbl_SmsRateCounter");
            DropTable("SmsBan.tbl_SmsOutbox");
            DropTable("SmsBan.tbl_SmsInbox");
            DropTable("SmsBan.tbl_SmsArchive");
        }
    }
}
