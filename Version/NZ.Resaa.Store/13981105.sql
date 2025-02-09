use DB_NzResaaStore
go

ALTER TABLE Anbar.tbl_Amaliat_Riz ADD Remain DECIMAL(18,3) NOT NULL DEFAULT(0)
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Base].[tbl_Base_Location](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](300) NOT NULL,
	[Is_Disable] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Base_Location] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [Base].[tbl_Base_Location] ADD  CONSTRAINT [DF_tbl_Base_Location_Is_Disable]  DEFAULT ((0)) FOR [Is_Disable]
GO


ALTER TABLE Anbar.tbl_Amaliat_Title ADD FK_Location SMALLINT NULL 

GO

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE Base.tbl_Base_Location SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE Anbar.tbl_Amaliat_Title ADD CONSTRAINT
	FK_tbl_Amaliat_Title_tbl_Base_Location FOREIGN KEY
	(
	FK_Location
	) REFERENCES Base.tbl_Base_Location
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE Anbar.tbl_Amaliat_Title SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

/****** Object:  Table [Base].[tbl_Prefactor]    Script Date: 8/16/2020 8:09:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Prefactor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](300) NOT NULL,
 CONSTRAINT [PK_tbl_Prefactor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_PreFactorItems]    Script Date: 8/16/2020 8:09:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_PreFactorItems](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Title] [int] NOT NULL,
	[FK_Kala] [bigint] NOT NULL,
	[Count] [decimal](18, 3) NOT NULL,
 CONSTRAINT [PK_tbl_PreFactorItems] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [FG_Base]
) ON [FG_Base]
GO
ALTER TABLE [Base].[tbl_PreFactorItems]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PreFactorItems_tbl_Kala_Xadamat] FOREIGN KEY([FK_Kala])
REFERENCES [Base].[tbl_Kala_Xadamat] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Base].[tbl_PreFactorItems] CHECK CONSTRAINT [FK_tbl_PreFactorItems_tbl_Kala_Xadamat]
GO
ALTER TABLE [Base].[tbl_PreFactorItems]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PreFactorItems_tbl_Prefactor] FOREIGN KEY([FK_Title])
REFERENCES [Base].[tbl_Prefactor] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Base].[tbl_PreFactorItems] CHECK CONSTRAINT [FK_tbl_PreFactorItems_tbl_Prefactor]
GO
 
/*-----------------------------------*/

/****** Object:  Table [Base].[tbl_BasteBandi]    Script Date: 2/9/2021 11:57:31 AM ******/

USE [DB_NzResaaStore]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Base].[tbl_BasteBandi](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_BasteBandi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [FG_Base]
) ON [FG_Base]
GO
 

/****** Object:  Table [Base].[tbl_Brand]    Script Date: 2/9/2021 11:58:13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Base].[tbl_Brand](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_Brand] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [FG_Base]
) ON [FG_Base]
GO

/**********************************************/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE Base.tbl_Brand SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE Base.tbl_BasteBandi SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE Base.tbl_Kala_Xadamat ADD
	FK_Brand smallint NULL,
	FK_BasteBandi smallint NULL,
	Height decimal(18, 2) NULL,
	Width decimal(18, 2) NULL,
	Length decimal(18, 2) NULL,
	Season tinyint NULL,
	Gender nchar(200) NULL,
	Color int NULL,
	Size nchar(20) NULL

GO
ALTER TABLE Base.tbl_Kala_Xadamat ADD CONSTRAINT
	FK_tbl_Kala_Xadamat_tbl_BasteBandi FOREIGN KEY
	(
	FK_BasteBandi
	) REFERENCES Base.tbl_BasteBandi
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE Base.tbl_Kala_Xadamat ADD CONSTRAINT
	FK_tbl_Kala_Xadamat_tbl_Brand FOREIGN KEY
	(
	FK_Brand
	) REFERENCES Base.tbl_Brand
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE Base.tbl_Kala_Xadamat SET (LOCK_ESCALATION = TABLE)
GO
COMMIT

/*========================================================*/

ALTER TABLE Anbar.tbl_Amaliat_Title ADD FK_Mabna BIGINT NULL
GO

ALTER TABLE Anbar.tbl_Amaliat_Riz ADD CostDescriptor NVARCHAR(max) NULL

Go

ALTER TABLE Base.tbl_Kala_Xadamat ADD Zarib DECIMAL(18,3) NOT NULL DEFAULT(0)

Go

ALTER TABLE Base.tbl_Kala_Xadamat ADD FK_Vahed_Fari SMALLINT NULL

GO


ALTER TABLE Base.tbl_Ashxas ADD Plak NVARCHAR(20) NULL

Go
