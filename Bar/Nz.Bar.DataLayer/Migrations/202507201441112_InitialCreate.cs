namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
	        Sql(@"
IF NOT EXISTS (SELECT * FROM sys.filegroups where name = 'FG_Bar') BEGIN
    ALTER DATABASE CURRENT
    ADD FILEGROUP [FG_Bar]
END
            ", true);

            Sql(@"
 IF EXISTS (SELECT * FROM sys.filegroups where name = 'FG_Bar') AND NOT EXISTS (SELECT * FROM sys.master_files where name = 'ResaaStore_Bar') BEGIN
		DECLARE @Path nvarchar(max)
        DECLARE @SQL nvarchar(max)

        SELECT TOP 1 @Path = physical_name 
        FROM sys.master_files 
        WHERE database_id = DB_ID() AND file_id = 1 AND type_desc = N'ROWS'
		
		SET @Path = (left((@Path),LEN(@Path)- charindex('\', reverse(@Path))+1))+N'ResaaStore_Bar.ndf';
		 

		SET @SQL = N'ALTER DATABASE CURRENT
                        ADD FILE (
                            NAME = [ResaaStore_Bar],
                            FILENAME = N''' + @Path + ''',
                            SIZE =50MB,
                            MAXSIZE = UNLIMITED,
                            FILEGROWTH = 20MB
                            )
                        TO FILEGROUP [FG_Bar]';
        EXECUTE sp_executesql @SQL
END
",true);

            Sql(@"

IF NOT EXISTS (
    SELECT 1 
    FROM sys.schemas 
    WHERE name = 'Bar'  
)
BEGIN
    EXEC('CREATE SCHEMA [Bar]') 
END
GO

",true);

            Sql(@"
CREATE TABLE [Bar].[tbl_Car](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Code] [smallint] NOT NULL,
	[FK_People] [bigint] NOT NULL,
	[Plak] [nvarchar](max) NULL,
	[CarType] [nvarchar](max) NULL,
	[IsDisable] [bit] NOT NULL,
 CONSTRAINT [PK_Bar.tbl_Car] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Bar]
) ON [FG_Bar] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [Bar].[tbl_Car]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Car_tbl_Ashxas] FOREIGN KEY([FK_People])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO

ALTER TABLE [Bar].[tbl_Car] CHECK CONSTRAINT [FK_tbl_Car_tbl_Ashxas]
GO


            ", true);

            Sql(@"
CREATE TABLE [Bar].[tbl_BarFactor](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[kind] [tinyint] NOT NULL,
	[is_ok] [bit] NOT NULL,
	[FK_Car] [smallint] NULL,
	[FK_People] [bigint] NOT NULL,
	[FK_Kala] [int] NOT NULL,
	[Serial] [int] NOT NULL,
	[Tarikh] [date] NOT NULL,
	[Tozihat] [nvarchar](max) NULL,
	[VaznPorMachine] [decimal](18, 2) NOT NULL,
	[VaznKHaliMachine] [decimal](18, 2) NOT NULL,
	[TedadBox] [decimal](18, 2) NOT NULL,
	[VaznKhaliBox] [decimal](18, 2) NOT NULL,
	[VaznOft] [decimal](18, 2) NOT NULL,
	[Nerkh] [decimal](18, 2) NOT NULL,
	[Mablaq] [decimal](18, 2) NOT NULL,
	[FK_User_Add] [smallint] NOT NULL,
	[FK_User_Edit] [smallint] NULL,
	[Tarikh_add] [datetime] NOT NULL,
	[Tarikh_edit] [datetime] NULL,
 CONSTRAINT [ID.tbl_BarFactor] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Bar]
) ON [FG_Bar] TEXTIMAGE_ON [PRIMARY]
GO
 
CREATE CLUSTERED INDEX [IX_FK_Salmali_tbl_BarFactor] ON [Bar].[tbl_BarFactor]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Bar]
GO

ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_Bar.tbl_BarFactor.tbl_Car_FK_Car] FOREIGN KEY([FK_Car])
REFERENCES [Bar].[tbl_Car] ([ID])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_Bar.tbl_BarFactor.tbl_Car_FK_Car]
GO
ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BarFactor_tbl_Ashxas] FOREIGN KEY([FK_People])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_tbl_BarFactor_tbl_Ashxas]
GO
ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BarFactor_tbl_Kala_Xadamat] FOREIGN KEY([FK_Kala])
REFERENCES [Base].[tbl_Kala_Xadamat] ([Code])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_tbl_BarFactor_tbl_Kala_Xadamat]
GO
ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BarFactor_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_tbl_BarFactor_tbl_Salmali]
GO
ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BarFactor_tbl_User] FOREIGN KEY([FK_User_Edit])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_tbl_BarFactor_tbl_User]
GO
ALTER TABLE [Bar].[tbl_BarFactor]  WITH CHECK ADD  CONSTRAINT [FK_tbl_BarFactor_tbl_UserAdd] FOREIGN KEY([FK_User_Add])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Bar].[tbl_BarFactor] CHECK CONSTRAINT [FK_tbl_BarFactor_tbl_UserAdd]
GO
            ", true);

        }
        
        public override void Down()
        {
            //DropForeignKey("Bar.tbl_BarFactor", "FK_Car", "Bar.tbl_Car");
            ////DropIndex("Bar.tbl_BarFactor", new[] { "FK_Car" });
            //DropTable("Bar.tbl_Car");
            //DropTable("Bar.tbl_BarFactor");
        }
    }
}

