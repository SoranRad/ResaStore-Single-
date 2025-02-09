USE [master]
GO
ALTER DATABASE [DB_NzResaaStore] ADD FILEGROUP [FG_Machine]
GO
ALTER DATABASE [DB_NzResaaStore] ADD FILE ( NAME = N'ResaaStore_Machine', FILENAME = N'E:\Work_Space_DataBase\Resaa\ResaaStore_Machine.ndf' , SIZE = 51200KB , FILEGROWTH = 51200KB ) TO FILEGROUP [FG_Machine]
GO
USE [DB_NzResaaStore]
GO
/****** Object:  Schema [Machine]    Script Date: 3/7/2022 5:36:46 PM ******/
CREATE SCHEMA [Machine]
GO
/****** Object:  Table [Machine].[tbl_AcceptMachine]    Script Date: 3/7/2022 5:36:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
ALTER TABLE [Machine].[tbl_AcceptMachine] ADD  CONSTRAINT [DF_tbl_AcceptMachine_ID]  DEFAULT (newsequentialid()) FOR [ID]
GO
ALTER TABLE [Machine].[tbl_AcceptMachine]  WITH CHECK ADD  CONSTRAINT [FK_tbl_AcceptMachine_tbl_Ashxas] FOREIGN KEY([FK_People])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Machine].[tbl_AcceptMachine] CHECK CONSTRAINT [FK_tbl_AcceptMachine_tbl_Ashxas]
GO
ALTER TABLE [Machine].[tbl_AcceptMachine]  WITH CHECK ADD  CONSTRAINT [FK_tbl_AcceptMachine_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO
ALTER TABLE [Machine].[tbl_AcceptMachine] CHECK CONSTRAINT [FK_tbl_AcceptMachine_tbl_Salmali]
GO
