namespace Nz.Bar.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addersalkarkhane : DbMigration
    {
        public override void Up()
        {

	        Sql(@"

CREATE TABLE [Bar].[tbl_ErsalKarkhane](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[is_ok] [bit] NOT NULL,
	[FK_Car] [smallint] NULL,
	[FK_Karkhane] [bigint] NOT NULL,
	[Serial] [int] NOT NULL,
	[Tarikh] [date] NOT NULL,
	[ShomareGhabz] [int] NOT NULL,
	[Tozihat] [nvarchar](max) NULL,
	[VaznNaKhales] [decimal](18, 0) NOT NULL,
	[VaznKHali] [decimal](18, 0) NOT NULL,
	[DarsadOft] [decimal](10, 2) NOT NULL,
	[VaznOft] [decimal](18, 0) NOT NULL,
	[VaznKHales] [decimal](18, 0) NOT NULL,
	[Nerkh] [decimal](18, 0) NOT NULL,
	[Mablaq] [decimal](18, 0) NOT NULL,
	[MablaqKeraye] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Bar.tbl_ErsalKarkhane] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Bar]
) ON [FG_Bar] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane]  WITH CHECK ADD  CONSTRAINT [FK_Bar.tbl_ErsalKarkhane_Bar.tbl_Car_FK_Car] FOREIGN KEY([FK_Car])
REFERENCES [Bar].[tbl_Car] ([ID])
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane] CHECK CONSTRAINT [FK_Bar.tbl_ErsalKarkhane_Bar.tbl_Car_FK_Car]
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ErsalKarkhane_tbl_Ashxas] FOREIGN KEY([FK_Karkhane])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane] CHECK CONSTRAINT [FK_tbl_ErsalKarkhane_tbl_Ashxas]
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ErsalKarkhane_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO

ALTER TABLE [Bar].[tbl_ErsalKarkhane] CHECK CONSTRAINT [FK_tbl_ErsalKarkhane_tbl_Salmali]
GO

CREATE CLUSTERED INDEX [IX_ErsalKarkhane_FK_Salmali] ON [Bar].[tbl_ErsalKarkhane]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Bar]
GO

", false);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Bar.tbl_ErsalKarkhane", "FK_Car", "Bar.tbl_Car");
            DropIndex("Bar.tbl_ErsalKarkhane", new[] { "FK_Car" });
            DropIndex("Bar.tbl_ErsalKarkhane", "IX_ErsalKarkhane_FK_Salmali");
            DropTable("Bar.tbl_ErsalKarkhane");
        }
    }
}
