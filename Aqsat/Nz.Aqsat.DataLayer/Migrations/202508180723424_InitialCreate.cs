namespace Nz.Aqsat.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            Sql(@"
IF OBJECT_ID('Xazane.FK_tbl_Amaliat_DP_tbl_Aqsat_Riz') IS NOT NULL 
ALTER TABLE [Xazane].[tbl_Amaliat_DP] DROP CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Riz];

",true);

	        Sql(@"
IF OBJECT_ID('Aqsat.tbl_Aqsat_SmsLog', 'U') IS NOT NULL
    DROP TABLE Aqsat.tbl_Aqsat_SmsLog;
Go
",true);

	        Sql(@"
IF OBJECT_ID('Aqsat.tbl_Aqsat_Riz', 'U') IS NOT NULL
    DROP TABLE Aqsat.tbl_Aqsat_Riz;
Go
",true);

            Sql(@"
IF OBJECT_ID('Aqsat.tbl_Aqsat_Main', 'U') IS NOT NULL
    DROP TABLE Aqsat.tbl_Aqsat_Main;
Go
",true);

            Sql(@"
IF OBJECT_ID('Aqsat.tbl_Aqsat_Noh', 'U') IS NOT NULL
    DROP TABLE Aqsat.tbl_Aqsat_Noh;
Go
",true);


            Sql(@"
CREATE TABLE [Aqsat].[tbl_Aqsat_Kind](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Code] [smallint] NOT NULL,
	[Title] [nchar](250) NULL,
 CONSTRAINT [PK_Aqsat.tbl_Aqsat_Kind] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO

CREATE TABLE [Aqsat].[tbl_Aqsat_Main](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_Shaxs] [bigint] NOT NULL,
	[FK_Zamen] [bigint] NULL,
	[FK_Faktor] [bigint] NULL,
	[FK_Noh] [smallint] NOT NULL,
	[Serial] [bigint] NOT NULL,
	[Tarikh] [date] NOT NULL,
	[DoreQest] [tinyint] NOT NULL,
	[RoundMablaq] [tinyint] NOT NULL,
	[MablaqAqsat] [decimal](18, 0) NOT NULL,
	[MablaqPishpardaxt] [decimal](18, 0) NOT NULL,
	[MablaqMandeAqsat] [decimal](18, 0) NOT NULL,
	[DarsadSoud] [decimal](18, 2) NOT NULL,
	[MablaqSoud] [decimal](18, 0) NOT NULL,
	[MablaqFinalAqsat] [decimal](18, 0) NOT NULL,
	[StartDate] [date] NOT NULL,
	[TedadAqsat] [tinyint] NOT NULL,
	[Sharh] [nvarchar](max) NULL,
	[IsTasvie] [bit] NOT NULL,
 CONSTRAINT [PK_Aqsat.tbl_Aqsat_Main] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat] TEXTIMAGE_ON [PRIMARY]
GO
CREATE CLUSTERED INDEX [IX_tbl_Aqsat_Main] ON [Aqsat].[tbl_Aqsat_Main]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
GO
CREATE TABLE [Aqsat].[tbl_Aqsat_Riz](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Main] [bigint] NOT NULL,
	[Radif] [tinyint] NOT NULL,
	[tarixQest] [date] NOT NULL,
	[tarixPardaxt] [datetime] NOT NULL,
	[mablaqQest] [decimal](18, 0) NOT NULL,
	[isPardaxt] [bit] NOT NULL,
 CONSTRAINT [PK_Aqsat.tbl_Aqsat_Riz] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO
/****** Object:  Index [IX_tbl_Aqsat_Riz]    Script Date: 20/08/2025 11:03:41 AM ******/
CREATE CLUSTERED INDEX [IX_tbl_Aqsat_Riz] ON [Aqsat].[tbl_Aqsat_Riz]
(
	[FK_Main] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
GO

CREATE TABLE [Aqsat].[tbl_Aqsat_SmsLog](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Riz] [bigint] NOT NULL,
	[Tarikh] [datetime] NOT NULL,
	[IsSuccess] [bit] NOT NULL,
 CONSTRAINT [PK_Aqsat.tbl_Aqsat_SmsLog] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO
/****** Object:  Index [IX_tbl_Aqsat_SmsLog]    Script Date: 20/08/2025 11:03:41 AM ******/
CREATE CLUSTERED INDEX [IX_tbl_Aqsat_SmsLog] ON [Aqsat].[tbl_Aqsat_SmsLog]
(
	[FK_Riz] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_Aqsat.tbl_Aqsat_Main_Aqsat.tbl_Aqsat_Kind_FK_Noh] FOREIGN KEY([FK_Noh])
REFERENCES [Aqsat].[tbl_Aqsat_Kind] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_Aqsat.tbl_Aqsat_Main_Aqsat.tbl_Aqsat_Kind_FK_Noh]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Amaliat_Title] FOREIGN KEY([FK_Faktor])
REFERENCES [Anbar].[tbl_Amaliat_Title] ([ID])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Amaliat_Title]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas] FOREIGN KEY([FK_Shaxs])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas1] FOREIGN KEY([FK_Zamen])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas1]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Salmali]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Riz]  WITH CHECK ADD  CONSTRAINT [FK_Aqsat.tbl_Aqsat_Riz_Aqsat.tbl_Aqsat_Main_FK_Main] FOREIGN KEY([FK_Main])
REFERENCES [Aqsat].[tbl_Aqsat_Main] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Riz] CHECK CONSTRAINT [FK_Aqsat.tbl_Aqsat_Riz_Aqsat.tbl_Aqsat_Main_FK_Main]
GO


ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Main] FOREIGN KEY([FK_Qest_Main])
REFERENCES [Aqsat].[tbl_Aqsat_Main] ([ID])
GO

ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Main]
GO

ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Riz] FOREIGN KEY([FK_Qest_Riz])
REFERENCES [Aqsat].[tbl_Aqsat_Riz] ([ID])
ON DELETE CASCADE
GO

ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Riz]
GO




",true);
        }
        
        public override void Down()
        {
            //DropForeignKey("Aqsat.tbl_Aqsat_Riz", "FK_Main", "Aqsat.tbl_Aqsat_Main");
            //DropForeignKey("Aqsat.tbl_Aqsat_SmsLog", "FK_Riz", "Aqsat.tbl_Aqsat_Riz");
            //DropForeignKey("Aqsat.tbl_Aqsat_Main", "FK_Noh", "Aqsat.tbl_Aqsat_Kind");
            //DropIndex("Aqsat.tbl_Aqsat_SmsLog", new[] { "FK_Riz" });
            //DropIndex("Aqsat.tbl_Aqsat_Riz", new[] { "FK_Main" });
            //DropIndex("Aqsat.tbl_Aqsat_Main", new[] { "FK_Noh" });
            //DropTable("Aqsat.tbl_Aqsat_SmsLog");
            //DropTable("Aqsat.tbl_Aqsat_Riz");
            //DropTable("Aqsat.tbl_Aqsat_Main");
            //DropTable("Aqsat.tbl_Aqsat_Kind");
        }
    }
}
