namespace Nz.Machine.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
                Sql(@"
                    IF NOT EXISTS (SELECT * FROM sys.filegroups where name = 'FG_Machine') BEGIN
                        ALTER DATABASE CURRENT
                            ADD FILEGROUP [FG_Machine]
                    END
                    GO
                ", true);

                Sql(@"
    IF EXISTS (SELECT * FROM sys.filegroups where name = 'FG_Machine') AND NOT EXISTS (SELECT * FROM sys.master_files where name = 'ResaaStore_Machine') BEGIN
        DECLARE @DatabasePath nvarchar(max)
        DECLARE @SQL nvarchar(max)

        SELECT TOP 1 @DatabasePath = physical_name 
        FROM sys.master_files 
        WHERE database_id = DB_ID() AND file_id = 1 AND type_desc = N'ROWS'

        SET @SQL = N'ALTER DATABASE CURRENT
                        ADD FILE (
                            NAME = [ResaaStore_Machine],
                            FILENAME = N''' + REPLACE(@DatabasePath, N'ResaaStore_Primary.mdf', N'ResaaStore_Machine.ndf') + ''',
                            SIZE = 50MB,
                            MAXSIZE = UNLIMITED,
                            FILEGROWTH =50MB
                            )
                        TO FILEGROUP [FG_Machine]'
        EXECUTE sp_executesql @SQL
    END
GO
", true);

                Sql(@"

IF (NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'Machine')) 
BEGIN
    EXEC ('CREATE SCHEMA [Machine]')
END
GO
", true);

                Sql(@"
IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[Machine].[tbl_AcceptMachine]') AND type in (N'U'))
BEGIN

CREATE TABLE [Machine].[tbl_AcceptMachine](
	[ID] [uniqueidentifier] NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[Shomare] [int] NOT NULL,
	[TarixAccept] [date] NOT NULL,
	[TimeAccept] [time](7) NOT NULL,
	[Mobile] [nchar](20) NOT NULL,
	[FK_People] [bigint] NOT NULL,
	[HomeAddress] [nchar](300) NULL,
	[Job] [nchar](150) NULL,
	[WorkAddress] [nchar](300) NULL,
	[Plak] [nchar](30) NULL,
	[KindMachine] [nchar](50) NULL,
	[Kilometer] [decimal](18, 0) NOT NULL,
	[MachineColor] [nchar](20) NULL,
	[ShomareShasi] [nchar](50) NULL,
	[ShomareMotor] [nchar](50) NULL,
	[LastikYadak] [bit] NOT NULL,
	[AcharCharx] [bit] NOT NULL,
	[Jak] [bit] NOT NULL,
	[Radio] [bit] NOT NULL,
	[Panel] [bit] NOT NULL,
	[Fandak] [bit] NOT NULL,
	[DozdGir] [bit] NOT NULL,
	[Anten] [bit] NOT NULL,
	[Ghalbagh] [bit] NOT NULL,
	[GhoflRing] [bit] NOT NULL,
	[MosalaXatar] [bit] NOT NULL,
	[GhoflFarman] [bit] NOT NULL,
	[GhoflPedal] [bit] NOT NULL,
	[Gas] [tinyint] NOT NULL,
	[Benzin] [decimal](18, 3) NOT NULL,
	[CustomerRequest] [nchar](500) NULL,
	[Descipt] [nchar](500) NULL,
	[BenzinPic] [varbinary](max) NULL,
 CONSTRAINT [PK_tbl_AcceptMachine] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [FG_Machine]
) ON [FG_Machine] TEXTIMAGE_ON [FG_ImageData]

ALTER TABLE [Machine].[tbl_AcceptMachine] ADD  CONSTRAINT [DF_tbl_AcceptMachine_ID]  DEFAULT (newsequentialid()) FOR [ID]
ALTER TABLE [Machine].[tbl_AcceptMachine]  WITH CHECK ADD  CONSTRAINT [FK_tbl_AcceptMachine_tbl_Ashxas] FOREIGN KEY([FK_People])
REFERENCES [Base].[tbl_Ashxas] ([ID])
ALTER TABLE [Machine].[tbl_AcceptMachine] CHECK CONSTRAINT [FK_tbl_AcceptMachine_tbl_Ashxas]
ALTER TABLE [Machine].[tbl_AcceptMachine]  WITH CHECK ADD  CONSTRAINT [FK_tbl_AcceptMachine_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
ALTER TABLE [Machine].[tbl_AcceptMachine] CHECK CONSTRAINT [FK_tbl_AcceptMachine_tbl_Salmali]


END;

", true);
            //CreateTable(
            //    "Machine.tbl_AcceptMachine",
            //    c => new
            //        {
            //            ID = c.Guid(nullable: false, identity: true),
            //            FK_People = c.Long(nullable: false),
            //            FK_Salmali = c.Short(nullable: false),
            //            Shomare = c.Int(nullable: false),
            //            TarixAccept = c.DateTime(nullable: false, storeType: "date"),
            //            TimeAccept = c.Time(nullable: false, precision: 7),
            //            Mobile = c.String(maxLength: 20, fixedLength: true),
            //            HomeAddress = c.String(maxLength: 300, fixedLength: true),
            //            Job = c.String(maxLength: 150, fixedLength: true),
            //            WorkAddress = c.String(maxLength: 300, fixedLength: true),
            //            Plak = c.String(maxLength: 30, fixedLength: true),
            //            KindMachine = c.String(maxLength: 50, fixedLength: true),
            //            Kilometer = c.Decimal(nullable: false, precision: 18, scale: 2),
            //            MachineColor = c.String(maxLength: 20, fixedLength: true),
            //            ShomareShasi = c.String(maxLength: 50, fixedLength: true),
            //            ShomareMotor = c.String(maxLength: 50, fixedLength: true),
            //            LastikYadak = c.Boolean(nullable: false),
            //            AcharCharx = c.Boolean(nullable: false),
            //            Jak = c.Boolean(nullable: false),
            //            Radio = c.Boolean(nullable: false),
            //            Panel = c.Boolean(nullable: false),
            //            Fandak = c.Boolean(nullable: false),
            //            DozdGir = c.Boolean(nullable: false),
            //            Anten = c.Boolean(nullable: false),
            //            Ghalbagh = c.Boolean(nullable: false),
            //            GhoflRing = c.Boolean(nullable: false),
            //            MosalaXatar = c.Boolean(nullable: false),
            //            GhoflFarman = c.Boolean(nullable: false),
            //            GhoflPedal = c.Boolean(nullable: false),
            //            Gas = c.Byte(nullable: false),
            //            Benzin = c.Decimal(nullable: false, precision: 18, scale: 3),
            //            CustomerRequest = c.String(maxLength: 500, fixedLength: true),
            //            Descipt = c.String(maxLength: 500, fixedLength: true),
            //            BenzinPic = c.Binary(),
            //        })
            //    .PrimaryKey(t => t.ID);
            

        }
        
        public override void Down()
        {
            DropTable("Machine.tbl_AcceptMachine");
            Sql(@"DROP SCHEMA IF EXISTS Machine",true);
            Sql(@"ALTER DATABASE Current REMOVE FILE [ResaaStore_Machine]", true);
            Sql(@"ALTER DATABASE Current REMOVE FILEGROUP FG_Machine; ", true);
        }
    }
}
