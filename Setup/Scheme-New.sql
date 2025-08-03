USE [master]
GO
/****** Object:  Database [DB_NzResaaStore]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE DATABASE [DB_NzResaaStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ResaaStore_Primary', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_Primary.mdf' , SIZE = 102400KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20%), 
 FILEGROUP [FG_Anbar] 
( NAME = N'ResaaStore_Anabr', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_Anabr.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20%), 
 FILEGROUP [FG_Aqsat] 
( NAME = N'ResaaStore_Aqsat', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_Aqsat.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20%), 
 FILEGROUP [FG_Base] 
( NAME = N'ResaaStore_Base', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_Base.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%), 
 FILEGROUP [FG_DimDate] 
( NAME = N'ResaaStore_DimDate', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_DimDate.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%), 
 FILEGROUP [FG_General] 
( NAME = N'ResaaStore_General', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_General.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%), 
 FILEGROUP [FG_ImageData] 
( NAME = N'RessaStor_ImageData', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\RessaStor_ImageData.ndf' , SIZE = 102400KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20%), 
 FILEGROUP [FG_Xazaneh] 
( NAME = N'ResaaStore_Xazaneh', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_Xazaneh.ndf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20%)
 LOG ON 
( NAME = N'ResaaStore_log', FILENAME = N'E:\Work_Space_DataBase\Nz_Resaastore\Ahmadi\ResaaStore_log.ldf' , SIZE = 256000KB , MAXSIZE = 2048GB , FILEGROWTH = 256000KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_NzResaaStore] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_NzResaaStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_NzResaaStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_NzResaaStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_NzResaaStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_NzResaaStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_NzResaaStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_NzResaaStore] SET  MULTI_USER 
GO
ALTER DATABASE [DB_NzResaaStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_NzResaaStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_NzResaaStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_NzResaaStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_NzResaaStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_NzResaaStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_NzResaaStore', N'ON'
GO
ALTER DATABASE [DB_NzResaaStore] SET QUERY_STORE = OFF
GO
USE [DB_NzResaaStore]
GO
/****** Object:  Schema [Anbar]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [Anbar]
GO
/****** Object:  Schema [Aqsat]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [Aqsat]
GO
/****** Object:  Schema [Base]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [Base]
GO
/****** Object:  Schema [Dim_Date]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [Dim_Date]
GO
/****** Object:  Schema [General]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [General]
GO
/****** Object:  Schema [SMS]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [SMS]
GO
/****** Object:  Schema [Xazane]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE SCHEMA [Xazane]
GO
/****** Object:  UserDefinedFunction [Anbar].[Get_Faktor_Name]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [Anbar].[Get_Faktor_Name] (@kind TINYINT)
RETURNS VARCHAR(25)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Kind_Str VARCHAR(25)
	SELECT
		@Kind_Str =
					CASE @kind
						WHEN 0 THEN 'پیش فـاکتور'
						WHEN 1 THEN 'اول دوره'
						WHEN 2 THEN 'خـرید'
						WHEN 3 THEN 'برگشتی فروش'
						WHEN 4 THEN 'رسید امانی'
						WHEN 5 THEN 'خرید بار'
						WHEN 6 THEN 'نقل و انتقال (رسید)'
						WHEN 50 THEN 'فروش'
						WHEN 51 THEN 'برگشتی خرید'
						WHEN 52 THEN 'حواله امانی'
						WHEN 53 THEN 'فروش بار'
						WHEN 54 THEN 'حواله ضـایعات'
						WHEN 55 THEN 'حواله مصرفی'
						WHEN 56 THEN 'نقل و انتقال (حواله)'
						WHEN 57 THEN 'ارائه خدمات مکانیزه'
					END

	RETURN @Kind_Str

END





GO
/****** Object:  UserDefinedFunction [Anbar].[Get_Last_Nerx_Xarid]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Anbar].[Get_Last_Nerx_Xarid]
(
	@Salmali SMALLINT,
	@Company TINYINT,
	@Kala_Code INT
)
RETURNS DECIMAL
AS
BEGIN
	-- Declare the return variable here
	DECLARE @nerx DECIMAL

	SET @nerx=(
	SELECT TOP 1 tar.nerkh
	
	FROM Anbar.tbl_Amaliat_Riz tar
	INNER JOIN Anbar.tbl_Amaliat_Title tat ON tar.FK_Title = tat.ID

	WHERE tat.FK_Salmali=@Salmali AND tat.FK_Company=@Company AND tat.kind=2
			AND tar.FK_Salmali=@Salmali AND tar.FK_Company=@Company AND tar.FK_Kala=@Kala_Code
	ORDER BY tat.tarikh
	)

	RETURN @nerx

END




GO
/****** Object:  UserDefinedFunction [Anbar].[GetFactorDetail]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [Anbar].[GetFactorDetail] 
(
	@ID BIGINT,
	@TopCount TINYINT
)
RETURNS NVARCHAR( MAX)
AS
BEGIN
	DECLARE @Str NVARCHAR(MAX);

	SET @Str=(


	SELECT STUFF((

    SELECT ' , ' + gl.name
    FROM (
		SELECT 
				TOP (@TopCount)
				FORMAT(tar.meqdar ,'0,0.##')+' '+
				LTRIM(RTRIM(tv.title))+' '+ RTRIM(LTRIM(tkx.title)) AS name

				FROM 
				Anbar.tbl_Amaliat_Riz AS tar
				INNER JOIN Base.tbl_Kala_Xadamat AS tkx ON tkx.Code = tar.FK_Kala
				INNER JOIN Base.tbl_Vahed AS tv ON tv.ID = tkx.FK_Vahed
				WHERE tar.FK_Title = @ID
	) AS gl
    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(Max)'), 1, 1, '')
	);

	RETURN LTRIM(RTRIM(@Str));

END
GO
/****** Object:  UserDefinedFunction [General].[MS_Get_Date]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE FUNCTION [General].[MS_Get_Date]
(

)
RETURNS DATETIME
AS
BEGIN
	RETURN (SELECT
		GETDATE())
END




GO
/****** Object:  UserDefinedFunction [General].[RestoteDB]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create FUNCTION [General].[RestoteDB]
(
	-- Add the parameters for the function here
	@BackupPath NVARCHAR(MAX)
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	    DECLARE @CurrentPath NVARCHAR(MAX);
        DECLARE @Command NVARCHAR(MAX);
		DECLARE @Files NVARCHAR(MAX);
		DECLARE @DB_Name NVARCHAR(MAX);

		SET @DB_Name=DB_NAME();
		SET @Command = N'USE master'+ CHAR(13) + CHAR(10);
		SET @Command =@Command+ N'ALTER DATABASE ' + DB_NAME() + N' SET SINGLE_USER WITH ROLLBACK IMMEDIATE' + CHAR(13) + CHAR(10);

        SET @CurrentPath = ( SELECT TOP 1
                                    ( LEFT(( physical_name ),LEN(physical_name) - CHARINDEX('\',REVERSE(physical_name))+ 1) )
                             FROM   sys.master_files mf
                             WHERE  mf.database_id = DB_ID()
                           );

        SET @Command =@Command+ N'RESTORE DATABASE ' + DB_NAME() + N' FROM DISK = ''' + @BackupPath + N''' WITH  FILE = 1,' + CHAR(13) + CHAR(10);
        SET @Files = @Command
            + STUFF((SELECT N',Move ''' + mf.name + N''' TO ''' + @CurrentPath + REVERSE(LEFT(REVERSE(physical_name),
                                           CHARINDEX('\', REVERSE(physical_name))
                                           - 1)) + '''' + CHAR(13) + CHAR(10)
                     FROM   sys.master_files mf
                     WHERE  mf.database_id = DB_ID()
            FOR     XML PATH('') ,
                        TYPE).value('.', 'varchar(max)'), 1, 1, '');


        SET @Command = @Files + N',KEEP_REPLICATION,  NOUNLOAD,  REPLACE,  STATS = 10'+CHAR(13) + CHAR(10);
        SET @Command =@Command+ N'ALTER DATABASE  ' + DB_NAME() + N' SET MULTI_USER' + CHAR(13) + CHAR(10);

	RETURN @Command;

END
GO
/****** Object:  UserDefinedFunction [Xazane].[GetDPDetail]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [Xazane].[GetDPDetail] 
(
	@ID BIGINT
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
	DECLARE @Cache DECIMAL, @POS DECIMAL,@Cheque DECIMAL,@OFF DECIMAL,@Str NVARCHAR(max);

SET @Cache = (
SELECT tax.mablaq
FROM Xazane.tbl_Amaliat_Xazaneh	 AS tax
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP
WHERE tax.kind = 9 AND  tad.ID = @ID
)

SET @POS = 
(
SELECT tax.mablaq
FROM Xazane.tbl_Amaliat_Xazaneh	 AS tax
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP
WHERE tax.kind = 10 AND  tad.ID = @ID
)

SET @Cheque = 
(
SELECT SUM(tac.mablaq) 
FROM Xazane.tbl_Amaliat_Check AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP
WHERE tad.ID = @ID
)

SET @OFF = 
(
SELECT tad.takhfif 
FROM  Xazane.tbl_Amaliat_DP AS tad 
WHERE tad.ID = @ID
)

SET @Str=N'';

IF ISNULL(@Cache,0)>0 
	SET @Str=@Str + N'('+FORMAT(ISNULL(@Cache,0),'0,0.##;(0,0.##);0') +N' نقدی  )';

IF ISNULL(@POS,0)>0 
	SET @Str=@Str +  N'('+FORMAT(ISNULL(@POS,0),'0,0.##;(0,0.##);0') +N' حواله بانکی  )';

IF ISNULL(@Cheque,0)>0 
	SET @Str=@Str + N'('+FORMAT(ISNULL( SUM(@Cheque),0),'0,0.##;(0,0.##);0') +N' چک و اسناد بهادار )' ;

IF ISNULL(@OFF,0)>0 
	SET @Str=@Str + N'('+FORMAT(SUM(ISNULL(@OFF,0)),'0,0.##;(0,0.##);0') +N' تخفیف تسویه )' ;

RETURN @Str

END

GO
/****** Object:  Table [Anbar].[tbl_Amaliat_Kardex]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Anbar].[tbl_Amaliat_Kardex](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_Riz] [bigint] NOT NULL,
	[FK_Kala] [int] NOT NULL,
	[FK_Parent_Varede] [bigint] SPARSE  NULL,
	[FK_Anbar] [tinyint] NOT NULL,
	[kind] [tinyint] NOT NULL,
	[kind_enteqal] [tinyint] SPARSE  NULL,
	[tarikh] [date] NOT NULL,
	[nerkh] [decimal](18, 4) SPARSE  NULL,
	[nerkh_mande_miangin] [decimal](18, 4) SPARSE  NULL,
	[meqdar] [decimal](18, 4) SPARSE  NULL,
	[meqdar_mande_miangin] [decimal](18, 4) SPARSE  NULL,
	[meqdar_mande_miani_Fari] [decimal](18, 4) NULL,
	[meqdar_mande_varede] [decimal](18, 4) SPARSE  NULL,
	[meqdar_mandeh_radif] [decimal](18, 4) SPARSE  NULL,
	[meqdar_mande_varede_fari] [decimal](18, 4) NULL,
	[meqdar_mandeh_radif_fari] [decimal](18, 4) NULL,
	[rowversion] [timestamp] NOT NULL,
 CONSTRAINT [PK_tbl_Amalit_Kardex] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
) ON [FG_Anbar]
GO
/****** Object:  Table [Anbar].[tbl_Amaliat_Riz]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Anbar].[tbl_Amaliat_Riz](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Title] [bigint] NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_Kala] [int] NOT NULL,
	[FK_Vahed] [smallint] NULL,
	[FK_Anbar_Az] [tinyint] NOT NULL,
	[FK_Anbar_Be] [tinyint] NULL,
	[kind] [tinyint] NULL,
	[radif] [int] NOT NULL,
	[meqdar] [decimal](18, 3) NOT NULL,
	[nerkh] [decimal](18, 2) NOT NULL,
	[nerkh_2] [decimal](18, 3) NOT NULL,
	[takhfif] [decimal](18, 2) NOT NULL,
	[takhfif_darsad] [decimal](8, 3) NOT NULL,
	[mablaq] [decimal](18, 2) NOT NULL,
	[rowversion] [timestamp] NOT NULL,
	[Remain] [decimal](18, 3) NOT NULL,
	[CostDescriptor] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_Amaliat_Riz] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
) ON [FG_Anbar] TEXTIMAGE_ON [FG_Anbar]
GO
/****** Object:  Index [IX_tbl_Amaliat_Riz]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE CLUSTERED INDEX [IX_tbl_Amaliat_Riz] ON [Anbar].[tbl_Amaliat_Riz]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
GO
/****** Object:  Table [Anbar].[tbl_Amaliat_Title]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Anbar].[tbl_Amaliat_Title](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_User_Add] [smallint] NOT NULL,
	[FK_AshXas_ID] [bigint] NULL,
	[FK_Kind_Frosh] [smallint] NULL,
	[Serial] [int] NOT NULL,
	[kind] [tinyint] NOT NULL,
	[tarikh] [date] NOT NULL,
	[tarikh_add] [datetime] NOT NULL,
	[mablaq] [decimal](18, 2) NOT NULL,
	[sharh] [nchar](300) SPARSE  NULL,
	[is_ok] [bit] NOT NULL,
	[FK_Location] [smallint] NULL,
	[FK_Mabna] [bigint] NULL,
 CONSTRAINT [PK_tbl_Amaliat_Title_1] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
) ON [FG_Anbar]
GO
/****** Object:  Index [IX_tbl_Amaliat_Title]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE CLUSTERED INDEX [IX_tbl_Amaliat_Title] ON [Anbar].[tbl_Amaliat_Title]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
GO
/****** Object:  Table [Anbar].[tbl_Amaliat_Title_Detail]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Anbar].[tbl_Amaliat_Title_Detail](
	[ID] [bigint] NOT NULL,
	[FK_User_Edit] [smallint] NULL,
	[tarikh_edit] [datetime] SPARSE  NULL,
	[tarikh_etebar] [date] NULL,
	[mablaq_takhfif] [decimal](18, 2) NULL,
	[mablaq_Maliat] [decimal](18, 2) NULL,
	[Darsad_Maliat] [decimal](6, 2) NULL,
	[Darsad_Takhfif] [decimal](6, 2) NULL,
	[FK_Vaset] [bigint] NULL,
	[Darsad_Porsant] [decimal](6, 2) NULL,
	[Ezafat] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbl_Amaliat_Title_Detail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
) ON [FG_Anbar]
GO
/****** Object:  Table [Aqsat].[tbl_Aqsat_Main]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Aqsat].[tbl_Aqsat_Main](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_Shaxs] [bigint] NOT NULL,
	[FK_Faktor] [bigint] NULL,
	[FK_Noh] [smallint] NOT NULL,
	[code] [int] NOT NULL,
	[tarixXarid] [datetime] NULL,
	[doreQest] [tinyint] NULL,
	[roundMablaq] [tinyint] NULL,
	[mablaqFaktor] [decimal](18, 0) NULL,
	[mablaqKol] [decimal](18, 0) NULL,
	[mablaqPishpardaxt] [decimal](18, 0) NULL,
	[mablaqTaqsit] [decimal](18, 0) NULL,
	[mablaqDirkardRuzane] [decimal](18, 0) NULL,
	[darsadDirkardRuzane] [decimal](2, 2) NULL,
	[darsadKarmozd] [decimal](2, 2) NULL,
	[darsadBahre] [decimal](2, 2) NULL,
	[tedadAqsat] [tinyint] NULL,
	[tarixStart] [datetime] NULL,
	[sharh] [nchar](400) NULL,
	[isTasvie] [bit] NULL,
	[addUser] [smallint] NOT NULL,
	[addDate] [datetime] NOT NULL,
	[editUser] [smallint] NULL,
	[editDate] [datetime] NULL,
	[FK_Zamen_Aval] [bigint] NULL,
	[FK_Zamen_Dowom] [bigint] NULL,
	[FK_Zamen_Sewom] [bigint] NULL,
	[kindAval] [tinyint] NULL,
	[kindDowom] [tinyint] NULL,
	[kindSewom] [tinyint] NULL,
	[sharhAval] [nchar](500) NULL,
	[sharhDowom] [nchar](500) NULL,
	[sharhSewom] [nchar](500) NULL,
	[arzeshAval] [decimal](18, 0) NULL,
	[arzeshDowom] [decimal](18, 0) NULL,
	[arzeshSewom] [decimal](18, 0) NULL,
 CONSTRAINT [PK_tbl_Aqsat_Main] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO
/****** Object:  Table [Aqsat].[tbl_Aqsat_Noh]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Aqsat].[tbl_Aqsat_Noh](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[code] [smallint] NOT NULL,
	[title] [nchar](150) NOT NULL,
 CONSTRAINT [PK_tbl_Noh_Qest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO
/****** Object:  Table [Aqsat].[tbl_Aqsat_Riz]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Aqsat].[tbl_Aqsat_Riz](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Aqsat_Main] [bigint] NULL,
	[radif] [tinyint] NULL,
	[tarixQest] [datetime] NULL,
	[tarixPardaxt] [datetime] NULL,
	[mablaqQest] [decimal](18, 0) NULL,
	[mablaqPardaxt] [decimal](18, 0) NULL,
	[mablaqDirkard] [decimal](18, 0) NULL,
	[sharh] [nchar](400) NULL,
	[isPardaxt] [bit] NULL,
	[isAuto] [bit] NULL,
 CONSTRAINT [PK_tbl_Aqsat_Riz] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Aqsat]
) ON [FG_Aqsat]
GO
/****** Object:  Table [Base].[tbl_Ashxas]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Ashxas](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Shahr] [smallint] NULL,
	[FK_Bank] [smallint] NULL,
	[FK_Group] [smallint] NOT NULL,
	[kind] [tinyint] NOT NULL,
	[code] [int] NOT NULL,
	[title] [nchar](250) NULL,
	[sex] [tinyint] NOT NULL,
	[tarix] [date] SPARSE  NULL,
	[namePedar] [nchar](50) SPARSE  NULL,
	[codeMeli] [nchar](10) SPARSE  NULL,
	[codePosti] [nchar](10) NULL,
	[codeEqtesadi] [nchar](50) SPARSE  NULL,
	[tel] [nchar](50) SPARSE  NULL,
	[mobile] [nchar](50) SPARSE  NULL,
	[fax] [nchar](50) NULL,
	[addressHome] [nchar](400) SPARSE  NULL,
	[is_disable] [bit] NOT NULL,
	[telDowom] [nchar](50) NULL,
	[mobDowom] [nchar](50) NULL,
	[addresswork] [nchar](400) NULL,
	[shomareHesab] [nchar](50) NULL,
	[shomareShenasname] [nchar](10) NULL,
	[isBlock] [bit] NULL,
	[BlockMablaq] [decimal](18, 0) NULL,
	[FK_Image_Tasvir] [bigint] NULL,
	[FK_Image_Zemanat] [bigint] NULL,
	[FK_Image_Emza] [bigint] NULL,
	[is_Froshande] [bit] NOT NULL,
	[is_Xaridar] [bit] NOT NULL,
	[Sarmaye_Avalie] [decimal](18, 0) NULL,
	[Sarmaye_Kol] [decimal](18, 0) NULL,
	[Sarmaye_Darsad] [decimal](4, 2) NULL,
	[Sood_Darsad] [decimal](4, 2) NULL,
	[Plak] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_Ashxas] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General],
 CONSTRAINT [IX_tbl_Ashxas] UNIQUE NONCLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_General]
GO
/****** Object:  Table [Base].[tbl_Bank]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Bank](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[title] [nchar](200) NOT NULL,
 CONSTRAINT [PK_tbl_Bank] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Base_Anbar]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Base_Anbar](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Code] [tinyint] NOT NULL,
	[Title] [nchar](100) NOT NULL,
	[Kind] [tinyint] NOT NULL,
	[Is_Disable] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Base_Anbar] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base],
 CONSTRAINT [IX_tbl_Base_Anbar_1] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Base_Anbar_Dastresi]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Base_Anbar_Dastresi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_Anbar] [tinyint] NOT NULL,
	[FK_User] [smallint] NOT NULL,
 CONSTRAINT [PK_tbl_Base_Anbar_Dastresi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Base_Location]    Script Date: 02/08/2025 4:09:49 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Base].[tbl_BasteBandi]    Script Date: 02/08/2025 4:09:49 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Brand]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Brand](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](100) NOT NULL,
	[test] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Brand] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Group_Ashxas]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Group_Ashxas](
	[ID] [smallint] NOT NULL,
	[Title] [nchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_Group_Public] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_GroupKala_1th]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_GroupKala_1th](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [smallint] NOT NULL,
	[title] [nchar](200) NOT NULL,
 CONSTRAINT [PK_tbl_GroupKala_1th] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base],
 CONSTRAINT [IX_tbl_GroupKala_1th_1] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_GroupKala_2th]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_GroupKala_2th](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_GroupKala_1th] [smallint] NULL,
	[Code] [smallint] NOT NULL,
	[title] [nchar](200) NOT NULL,
 CONSTRAINT [PK_tbl_Group_B] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base],
 CONSTRAINT [IX_tbl_GroupKala_2th_1] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Kala_Xadamat]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Kala_Xadamat](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_GroupKala_2th] [smallint] NOT NULL,
	[FK_Vahed] [smallint] NOT NULL,
	[kind] [tinyint] NOT NULL,
	[Code] [int] NOT NULL,
	[title] [nchar](500) NOT NULL,
	[barcode] [nchar](50) NULL,
	[nameFani] [nchar](150) NULL,
	[codeFani] [nchar](50) NULL,
	[point_bohrani] [decimal](12, 2) SPARSE  NULL,
	[is_disabled] [bit] NOT NULL,
	[nerkh_frosh] [decimal](18, 0) NOT NULL,
	[nerkh_frosh1] [decimal](18, 0) NULL,
	[nerkh_frosh2] [decimal](18, 0) NULL,
	[nerkh_frosh3] [decimal](18, 0) NULL,
	[FK_Image] [bigint] NULL,
	[keshvarSazande] [nchar](150) NULL,
	[FK_Brand] [smallint] NULL,
	[FK_BasteBandi] [smallint] NULL,
	[Height] [decimal](18, 2) NULL,
	[Width] [decimal](18, 2) NULL,
	[Length] [decimal](18, 2) NULL,
	[Season] [tinyint] NULL,
	[Gender] [nchar](200) NULL,
	[Color] [int] NULL,
	[Size] [nchar](20) NULL,
	[Zarib] [decimal](18, 3) NOT NULL,
	[FK_Vahed_Fari] [smallint] NULL,
 CONSTRAINT [PK_tbl_Base_Kala_Xadamat] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base],
 CONSTRAINT [IX_tbl_Kala_Xadamat_1] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Ostan]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Ostan](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[title] [nchar](150) NULL,
 CONSTRAINT [PK_tbl_Ostan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_DimDate]
) ON [FG_DimDate]
GO
/****** Object:  Table [Base].[tbl_Prefactor]    Script Date: 02/08/2025 4:09:49 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_PreFactorItems]    Script Date: 02/08/2025 4:09:49 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Base].[tbl_Shahr]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Shahr](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[FK_Ostan] [smallint] NOT NULL,
	[title] [nchar](150) NULL,
 CONSTRAINT [PK_tbl_Shahr] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_DimDate]
) ON [FG_DimDate]
GO
/****** Object:  Table [Base].[tbl_Vahed]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Base].[tbl_Vahed](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[title] [nchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_Vahed] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [General].[DimDate]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[DimDate](
	[DateKey] [int] NOT NULL,
	[GregorianDate] [date] NULL,
	[GregorianYearInt] [smallint] NULL,
	[GregorianMonthNo] [tinyint] NULL,
	[GregorianDayInMonth] [tinyint] NULL,
	[GregorianMonthDayInt] [smallint] NULL,
	[GregorianDayOfWeekInt] [tinyint] NULL,
	[GregorianMonthName] [nvarchar](20) NULL,
	[GregorianStr] [char](10) NULL,
	[GregorianYearMonthInt] [int] NULL,
	[GregorianYearMonthStr] [char](7) NULL,
	[GregorianDayOfWeekName] [nvarchar](20) NULL,
	[GrgorianWeekOfYearName] [nvarchar](20) NULL,
	[GregorianWeekOfYearNo] [int] NULL,
	[PersianInt] [int] NULL,
	[PersianYearInt] [smallint] NULL,
	[PersianMonthNo] [tinyint] NULL,
	[PersianDayInMonth] [tinyint] NULL,
	[PersianMonthDayInt] [smallint] NULL,
	[PersianDayOfWeekInt] [tinyint] NULL,
	[PersianMonthName] [nvarchar](20) NULL,
	[PersianStr] [char](10) NULL,
	[PersianYearMonthInt] [int] NULL,
	[PersianYearMonthStr] [char](7) NULL,
	[PersianDayOfWeekName] [nvarchar](20) NULL,
	[PersianWeekOfYearName] [nvarchar](20) NULL,
	[PersianWeekOfYearNo] [int] NULL,
	[PersianFullName] [nvarchar](60) NULL,
	[HijriInt] [int] NULL,
	[HijriYearInt] [smallint] NULL,
	[HijriMonthNo] [tinyint] NULL,
	[HijriDayInMonth] [tinyint] NULL,
	[HijriMonthDayInt] [smallint] NULL,
	[HijriDayOfWeekInt] [tinyint] NULL,
	[HijriMonthName] [nvarchar](20) NULL,
	[HijriStr] [char](10) NULL,
	[HijriYearMonthInt] [int] NULL,
	[HijriYearMonthStr] [char](7) NULL,
	[HijriDayOfWeekName] [nvarchar](20) NULL,
	[HijriWeekOfYearName] [nvarchar](20) NULL,
	[HijriWeekOfYearNo] [int] NULL,
	[SeasonCode] [tinyint] NULL,
	[SeasonName] [nvarchar](50) NULL,
	[IsGregorianLeap] [bit] NULL,
	[IsPersianLeap] [bit] NULL,
	[IsOneDayBefore_PersianHoliday] [bit] NULL,
	[IsOneDayBefore_HijriHoliday] [bit] NULL,
 CONSTRAINT [PK_DimDate] PRIMARY KEY CLUSTERED 
(
	[DateKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 85, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_DimDate]
) ON [FG_DimDate]
GO
/****** Object:  Table [General].[tbl_Config]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Config](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[ActiveString] [nvarchar](max) NOT NULL,
	[LastVersion] [nvarchar](max) NOT NULL,
	[ModuleList] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_tbl_Config] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [General].[tbl_DailyNote]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_DailyNote](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Msg] [nvarchar](max) NOT NULL,
	[IsChecked] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_DailyNote] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [General].[tbl_Image]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Image](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Image] [varbinary](max) NULL,
 CONSTRAINT [PK_tbl_Image] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_ImageData]
) ON [FG_ImageData] TEXTIMAGE_ON [FG_ImageData]
GO
/****** Object:  Table [General].[tbl_Info]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Info](
	[ID] [bit] NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[title] [nvarchar](max) NOT NULL,
	[tarikh] [nvarchar](max) NOT NULL,
	[modir] [nchar](100) NULL,
	[molahezat] [nvarchar](500) NULL,
	[address] [nvarchar](500) NULL,
	[tel] [nchar](50) NULL,
	[mobile] [nchar](50) NULL,
	[fax] [nchar](50) NULL,
	[code_posti] [nchar](10) NULL,
	[code_melli] [nchar](10) NULL,
	[code_eqtesadi] [nchar](50) NULL,
	[tel2] [nchar](50) NULL,
	[mobile2] [nchar](50) NULL,
	[email] [nchar](100) NULL,
	[website] [nchar](100) NULL,
	[logo] [varbinary](max) NULL,
	[mohr] [varbinary](max) NULL,
 CONSTRAINT [PK_tbl_Info] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [General].[tbl_Mokaleme_Ashxas]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Mokaleme_Ashxas](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Shaxs_ID] [bigint] NOT NULL,
	[FK_User_Add] [smallint] NOT NULL,
	[FK_User_Edit] [smallint] SPARSE  NULL,
	[tarix] [date] NOT NULL,
	[saat] [nchar](5) NULL,
	[userTell] [nchar](500) NULL,
	[shaxsTell] [nchar](500) NULL,
	[vaziat] [bit] NOT NULL,
	[tarikh_add] [datetime] NOT NULL,
	[tarikh_edit] [datetime] NULL,
 CONSTRAINT [PK_tbl_Mokaleme_Ashxas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General]
GO
/****** Object:  Table [General].[tbl_Salmali]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Salmali](
	[Salmali] [smallint] NOT NULL,
	[darsad_arzesh_afzude] [decimal](18, 2) NOT NULL,
	[is_close] [bit] NOT NULL,
	[Money] [nchar](50) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_tbl_Salmali] PRIMARY KEY CLUSTERED 
(
	[Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General]
GO
/****** Object:  Table [General].[tbl_Sharh]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_Sharh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[System] [tinyint] NOT NULL,
	[Text] [nchar](500) NOT NULL,
 CONSTRAINT [PK_tbl_Sharh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
) ON [FG_General]
GO
/****** Object:  Table [General].[tbl_User]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [General].[tbl_User](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[Code] [smallint] NOT NULL,
	[title] [nchar](100) NOT NULL,
	[kind] [smallint] NOT NULL,
	[user_name] [nchar](50) NOT NULL,
	[password] [nchar](100) NOT NULL,
	[default_password] [nchar](100) NOT NULL,
	[dastressi] [varchar](max) NULL,
	[is_disable] [bit] NOT NULL,
	[picture] [varbinary](max) NULL,
	[LockAccount] [bit] NOT NULL,
	[LockTime] [smallint] NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General],
 CONSTRAINT [IX_tbl_User] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General],
 CONSTRAINT [IX_tbl_User_1] UNIQUE NONCLUSTERED 
(
	[user_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_General] TEXTIMAGE_ON [FG_ImageData]
GO
/****** Object:  Table [SMS].[SmsPanel]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SMS].[SmsPanel](
	[ID] [tinyint] NOT NULL,
	[Number] [nchar](50) NULL,
	[userName] [nchar](150) NULL,
	[userPass] [nchar](150) NULL,
	[Title] [nchar](400) NULL,
 CONSTRAINT [PK_SmsPanel_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [SMS].[SmsReady]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [SMS].[SmsReady](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](150) NULL,
	[Detiles] [nchar](500) NULL,
 CONSTRAINT [PK_SmsReady] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Xazane].[tbl_Amaliat_Check]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Amaliat_Check](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Bank] [smallint] SPARSE  NULL,
	[FK_Hesab_Pardaxtani] [int] SPARSE  NULL,
	[FK_Daste_Cheque] [bigint] NULL,
	[FK_DP] [bigint] NOT NULL,
	[FK_User_Add] [smallint] NOT NULL,
	[FK_User_Edit] [smallint] SPARSE  NULL,
	[tarikh_sar_resid] [date] NULL,
	[kind] [tinyint] NULL,
	[mablaq] [decimal](18, 0) NULL,
	[shomare_check] [nchar](50) NULL,
	[babat] [nvarchar](150) SPARSE  NULL,
	[tarikh_add] [datetime] NOT NULL,
	[tarikh_edit] [datetime] NULL,
	[is_ok] [bit] NOT NULL,
	[FK_Salmali_Vaziat] [smallint] NULL,
	[FK_Xazaneh_Vaziat] [int] NULL,
	[FK_Shaxs_Vaziat] [bigint] NULL,
	[FK_User_Add_Vaziat] [smallint] NULL,
	[FK_User_Edit_Vaziat] [smallint] NULL,
	[FK_DP_Vagozari] [bigint] NULL,
	[Kind_Vaziat] [tinyint] NULL,
	[Tarix_Vaziat] [date] NULL,
	[Tarix_Edit_Vaziat] [datetime] NULL,
	[Tarix_Add_Vaziat] [datetime] NULL,
	[Sharh_Vaziat] [nchar](100) SPARSE  NULL,
 CONSTRAINT [PK_tbl_Amaliat_Check] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
) ON [FG_Xazaneh]
GO
/****** Object:  Index [IX_tbl_Amaliat_Check]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE CLUSTERED INDEX [IX_tbl_Amaliat_Check] ON [Xazane].[tbl_Amaliat_Check]
(
	[FK_DP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
GO
/****** Object:  Table [Xazane].[tbl_Amaliat_DP]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Amaliat_DP](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NOT NULL,
	[FK_User_Add] [smallint] NOT NULL,
	[FK_User_Edit] [smallint] SPARSE  NULL,
	[FK_Faktor] [bigint] SPARSE  NULL,
	[FK_ShaXs] [bigint] SPARSE  NULL,
	[FK_ShaXs_Enteqal] [bigint] NULL,
	[FK_Qest_Main] [bigint] NULL,
	[FK_Qest_Riz] [bigint] NULL,
	[serial] [int] NOT NULL,
	[takhfif] [decimal](18, 4) NULL,
	[kind] [tinyint] NOT NULL,
	[tarikh] [date] NOT NULL,
	[tarikh_add] [datetime] NOT NULL,
	[tarikh_edit] [datetime] NULL,
	[sharh] [nvarchar](300) NULL,
	[is_ok] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Amaliat_DP] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
) ON [FG_Xazaneh]
GO
/****** Object:  Index [IX_tbl_Amaliat_DP]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE CLUSTERED INDEX [IX_tbl_Amaliat_DP] ON [Xazane].[tbl_Amaliat_DP]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
GO
/****** Object:  Table [Xazane].[tbl_Amaliat_Xazaneh]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Amaliat_Xazaneh](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Salmali] [smallint] NULL,
	[FK_Xazaneh_Bad] [int] NULL,
	[FK_Xazaneh_Bas] [int] NULL,
	[FK_DP] [bigint] NULL,
	[FK_User_Add] [smallint] NULL,
	[FK_User_Edit] [smallint] SPARSE  NULL,
	[serialPeygiri] [bigint] SPARSE  NULL,
	[serial] [int] NOT NULL,
	[mablaq] [decimal](18, 4) NOT NULL,
	[sharh] [nchar](200) NULL,
	[kind] [tinyint] NOT NULL,
	[tarikh] [date] NULL,
	[tarikh_add] [datetime] NULL,
	[tarikh_edit] [datetime] NULL,
 CONSTRAINT [PK_tbl_Amaliat_Xazaneh] PRIMARY KEY NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
) ON [FG_Xazaneh]
GO
/****** Object:  Index [IX_tbl_Amaliat_Xazaneh]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE CLUSTERED INDEX [IX_tbl_Amaliat_Xazaneh] ON [Xazane].[tbl_Amaliat_Xazaneh]
(
	[FK_Salmali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
GO
/****** Object:  Table [Xazane].[tbl_Daste_Cheque_Riz]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Daste_Cheque_Riz](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Dasteh_Cheque] [bigint] NOT NULL,
	[Serial] [int] NOT NULL,
	[Vaziat] [tinyint] NOT NULL,
	[Sharh] [nchar](250) NULL,
 CONSTRAINT [PK_tbl_Base_Daste_Cheque_Riz] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Table [Xazane].[tbl_Daste_Chque]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Daste_Chque](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FK_Xazaneh] [int] NOT NULL,
	[Code] [smallint] NOT NULL,
	[Tarikh_Tahvil] [date] NOT NULL,
	[Tedad_Barge] [tinyint] NOT NULL,
	[Start_Serial] [int] NOT NULL,
	[Sharh] [nchar](250) NULL,
	[Is_Disable] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_Base_Daste_Chque] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base],
 CONSTRAINT [IX_tbl_Daste_Chque] UNIQUE NONCLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [FG_Base]
GO
/****** Object:  Table [Xazane].[tbl_Hesab_Xazaneh]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Xazane].[tbl_Hesab_Xazaneh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FK_Bank] [smallint] NULL,
	[Code] [smallint] NOT NULL,
	[Kind] [tinyint] NOT NULL,
	[title] [nchar](150) NULL,
	[mojudi_avalie] [decimal](18, 2) NOT NULL,
	[is_disable] [bit] NOT NULL,
	[shobe] [nchar](250) NULL,
	[has_POS] [bit] NULL,
	[Shomare_Hesab] [nchar](30) NULL,
	[Kind_Hesab] [nchar](100) NULL,
 CONSTRAINT [PK_tbl_Base_Xazaneh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Base]
) ON [FG_Base]
GO
/****** Object:  Index [IX_tbl_Amaliat_Riz_1]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Amaliat_Riz_1] ON [Anbar].[tbl_Amaliat_Riz]
(
	[FK_Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
GO
/****** Object:  Index [IX_tbl_Amaliat_Title_1]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Amaliat_Title_1] ON [Anbar].[tbl_Amaliat_Title]
(
	[kind] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Anbar]
GO
/****** Object:  Index [IX_tbl_Aqsat_Noh]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_tbl_Aqsat_Noh] ON [Aqsat].[tbl_Aqsat_Noh]
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = OFF, ALLOW_PAGE_LOCKS = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DimDate]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_DimDate] ON [General].[DimDate]
(
	[PersianYearInt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 85, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_DimDate]
GO
/****** Object:  Index [IX_tbl_Mokaleme_Ashxas]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Mokaleme_Ashxas] ON [General].[tbl_Mokaleme_Ashxas]
(
	[FK_Shaxs_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_General]
GO
/****** Object:  Index [IX_tbl_Amaliat_DP_1]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Amaliat_DP_1] ON [Xazane].[tbl_Amaliat_DP]
(
	[FK_Faktor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
GO
/****** Object:  Index [IX_tbl_Amaliat_Xazaneh_1]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Amaliat_Xazaneh_1] ON [Xazane].[tbl_Amaliat_Xazaneh]
(
	[FK_DP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [FG_Xazaneh]
GO
/****** Object:  Index [IX_tbl_Hesab_Xazaneh]    Script Date: 02/08/2025 4:09:49 PM ******/
CREATE NONCLUSTERED INDEX [IX_tbl_Hesab_Xazaneh] ON [Xazane].[tbl_Hesab_Xazaneh]
(
	[Code] ASC,
	[Kind] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz] ADD  DEFAULT ((0)) FOR [Remain]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title] ADD  CONSTRAINT [DF_tbl_Amaliat_Title_is_ok]  DEFAULT ((1)) FOR [is_ok]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Riz] ADD  CONSTRAINT [DF_tbl_Aqsat_Riz_isAuto]  DEFAULT ((1)) FOR [isAuto]
GO
ALTER TABLE [Base].[tbl_Ashxas] ADD  CONSTRAINT [DF_tbl_Public_sex]  DEFAULT ((0)) FOR [sex]
GO
ALTER TABLE [Base].[tbl_Ashxas] ADD  CONSTRAINT [DF_tbl_Public_is_disable]  DEFAULT ((0)) FOR [is_disable]
GO
ALTER TABLE [Base].[tbl_Base_Anbar] ADD  CONSTRAINT [DF_tbl_Base_Anbar_Is_Disable]  DEFAULT ((0)) FOR [Is_Disable]
GO
ALTER TABLE [Base].[tbl_Base_Location] ADD  CONSTRAINT [DF_tbl_Base_Location_Is_Disable]  DEFAULT ((0)) FOR [Is_Disable]
GO
ALTER TABLE [Base].[tbl_Brand] ADD  DEFAULT ((0)) FOR [test]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] ADD  CONSTRAINT [DF_tbl_Base_Kala_Xadamat_nerkh_frosh]  DEFAULT ((0)) FOR [nerkh_frosh]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] ADD  DEFAULT ((0)) FOR [Zarib]
GO
ALTER TABLE [General].[tbl_Salmali] ADD  CONSTRAINT [DF_tbl_Salmali_is_close]  DEFAULT ((0)) FOR [is_close]
GO
ALTER TABLE [General].[tbl_Salmali] ADD  CONSTRAINT [DF_tbl_Salmali_StartDate]  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [General].[tbl_Salmali] ADD  CONSTRAINT [DF_tbl_Salmali_EndDate]  DEFAULT (getdate()) FOR [EndDate]
GO
ALTER TABLE [General].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_Code_2]  DEFAULT ((0)) FOR [Code]
GO
ALTER TABLE [General].[tbl_User] ADD  CONSTRAINT [DF_tbl_User_is_disable]  DEFAULT ((0)) FOR [is_disable]
GO
ALTER TABLE [General].[tbl_User] ADD  DEFAULT ((0)) FOR [LockAccount]
GO
ALTER TABLE [General].[tbl_User] ADD  DEFAULT ((0)) FOR [LockTime]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] ADD  CONSTRAINT [DF_tbl_Amaliat_Xazaneh_FK_User_Add]  DEFAULT ((1)) FOR [FK_User_Add]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] ADD  CONSTRAINT [DF_tbl_Amaliat_Xazaneh_serial]  DEFAULT ((0)) FOR [serial]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] ADD  CONSTRAINT [DF_tbl_Amaliat_Xazaneh_tarikh]  DEFAULT (getdate()) FOR [tarikh]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] ADD  CONSTRAINT [DF_tbl_Amaliat_Xazaneh_tarikh_add]  DEFAULT (getdate()) FOR [tarikh_add]
GO
ALTER TABLE [Xazane].[tbl_Daste_Chque] ADD  CONSTRAINT [DF_tbl_Base_Daste_Chque_Is_Disable]  DEFAULT ((0)) FOR [Is_Disable]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Kardex]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amalit_Kardex_tbl_Amaliat_Riz] FOREIGN KEY([FK_Riz])
REFERENCES [Anbar].[tbl_Amaliat_Riz] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Kardex] CHECK CONSTRAINT [FK_tbl_Amalit_Kardex_tbl_Amaliat_Riz]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Amaliat_Title] FOREIGN KEY([FK_Title])
REFERENCES [Anbar].[tbl_Amaliat_Title] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz] CHECK CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Amaliat_Title]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Kala_Xadamat] FOREIGN KEY([FK_Kala])
REFERENCES [Base].[tbl_Kala_Xadamat] ([Code])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz] CHECK CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Kala_Xadamat]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Vahed] FOREIGN KEY([FK_Vahed])
REFERENCES [Base].[tbl_Vahed] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Riz] CHECK CONSTRAINT [FK_tbl_Amaliat_Riz_tbl_Vahed]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Ashxas] FOREIGN KEY([FK_AshXas_ID])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Ashxas]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Base_Location] FOREIGN KEY([FK_Location])
REFERENCES [Base].[tbl_Base_Location] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Base_Location]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_tbl_Salmali]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_tbl_User] FOREIGN KEY([FK_User_Add])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_tbl_User]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_Amaliat_Title] FOREIGN KEY([ID])
REFERENCES [Anbar].[tbl_Amaliat_Title] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_Amaliat_Title]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_Ashxas] FOREIGN KEY([FK_Vaset])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_Ashxas]
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_User] FOREIGN KEY([FK_User_Edit])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Anbar].[tbl_Amaliat_Title_Detail] CHECK CONSTRAINT [FK_tbl_Amaliat_Title_Detail_tbl_User]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas] FOREIGN KEY([FK_Shaxs])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Ashxas]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Noh_Qest] FOREIGN KEY([FK_Noh])
REFERENCES [Aqsat].[tbl_Aqsat_Noh] ([ID])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Noh_Qest]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Salmali] FOREIGN KEY([FK_Salmali])
REFERENCES [General].[tbl_Salmali] ([Salmali])
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Main] CHECK CONSTRAINT [FK_tbl_Aqsat_Main_tbl_Salmali]
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Riz]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Aqsat_Riz_tbl_Aqsat_Main] FOREIGN KEY([FK_Aqsat_Main])
REFERENCES [Aqsat].[tbl_Aqsat_Main] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Aqsat].[tbl_Aqsat_Riz] CHECK CONSTRAINT [FK_tbl_Aqsat_Riz_tbl_Aqsat_Main]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH NOCHECK ADD  CONSTRAINT [FK_tbl_Ashxas_tbl_Group_Ashxas] FOREIGN KEY([FK_Group])
REFERENCES [Base].[tbl_Group_Ashxas] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Ashxas_tbl_Group_Ashxas]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ashxas_tbl_Image] FOREIGN KEY([FK_Image_Emza])
REFERENCES [General].[tbl_Image] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Ashxas_tbl_Image]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ashxas_tbl_Image1] FOREIGN KEY([FK_Image_Tasvir])
REFERENCES [General].[tbl_Image] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Ashxas_tbl_Image1]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ashxas_tbl_Image2] FOREIGN KEY([FK_Image_Zemanat])
REFERENCES [General].[tbl_Image] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Ashxas_tbl_Image2]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Ashxas_tbl_Shahr] FOREIGN KEY([FK_Shahr])
REFERENCES [Base].[tbl_Shahr] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Ashxas_tbl_Shahr]
GO
ALTER TABLE [Base].[tbl_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Public_tbl_Bank] FOREIGN KEY([FK_Bank])
REFERENCES [Base].[tbl_Bank] ([ID])
GO
ALTER TABLE [Base].[tbl_Ashxas] CHECK CONSTRAINT [FK_tbl_Public_tbl_Bank]
GO
ALTER TABLE [Base].[tbl_Base_Anbar_Dastresi]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Anbar_Dastresi_tbl_User] FOREIGN KEY([FK_User])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Base].[tbl_Base_Anbar_Dastresi] CHECK CONSTRAINT [FK_tbl_Base_Anbar_Dastresi_tbl_User]
GO
ALTER TABLE [Base].[tbl_GroupKala_2th]  WITH CHECK ADD  CONSTRAINT [FK_tbl_GroupKala_2th_tbl_GroupKala_1th] FOREIGN KEY([FK_GroupKala_1th])
REFERENCES [Base].[tbl_GroupKala_1th] ([Code])
GO
ALTER TABLE [Base].[tbl_GroupKala_2th] CHECK CONSTRAINT [FK_tbl_GroupKala_2th_tbl_GroupKala_1th]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Kala_Xadamat_tbl_Image] FOREIGN KEY([FK_Image])
REFERENCES [General].[tbl_Image] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] CHECK CONSTRAINT [FK_tbl_Base_Kala_Xadamat_tbl_Image]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Kala_Xadamat_tbl_Vahed] FOREIGN KEY([FK_Vahed])
REFERENCES [Base].[tbl_Vahed] ([ID])
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] CHECK CONSTRAINT [FK_tbl_Base_Kala_Xadamat_tbl_Vahed]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_BasteBandi] FOREIGN KEY([FK_BasteBandi])
REFERENCES [Base].[tbl_BasteBandi] ([ID])
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] CHECK CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_BasteBandi]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_Brand] FOREIGN KEY([FK_Brand])
REFERENCES [Base].[tbl_Brand] ([ID])
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] CHECK CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_Brand]
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_GroupKala_2th] FOREIGN KEY([FK_GroupKala_2th])
REFERENCES [Base].[tbl_GroupKala_2th] ([Code])
GO
ALTER TABLE [Base].[tbl_Kala_Xadamat] CHECK CONSTRAINT [FK_tbl_Kala_Xadamat_tbl_GroupKala_2th]
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
ALTER TABLE [Base].[tbl_Shahr]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Shahr_tbl_Shahr] FOREIGN KEY([FK_Ostan])
REFERENCES [Base].[tbl_Ostan] ([ID])
GO
ALTER TABLE [Base].[tbl_Shahr] CHECK CONSTRAINT [FK_tbl_Shahr_tbl_Shahr]
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_Ashxas] FOREIGN KEY([FK_Shaxs_ID])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas] CHECK CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_Ashxas]
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_User] FOREIGN KEY([FK_User_Add])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas] CHECK CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_User]
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_User1] FOREIGN KEY([FK_User_Edit])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [General].[tbl_Mokaleme_Ashxas] CHECK CONSTRAINT [FK_tbl_Mokaleme_Ashxas_tbl_User1]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Amaliat_DP] FOREIGN KEY([FK_DP])
REFERENCES [Xazane].[tbl_Amaliat_DP] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Amaliat_DP]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Bank] FOREIGN KEY([FK_Bank])
REFERENCES [Base].[tbl_Bank] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Bank]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Base_Daste_Chque] FOREIGN KEY([FK_Daste_Cheque])
REFERENCES [Xazane].[tbl_Daste_Cheque_Riz] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Base_Daste_Chque]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Base_Xazaneh] FOREIGN KEY([FK_Hesab_Pardaxtani])
REFERENCES [Xazane].[tbl_Hesab_Xazaneh] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Base_Xazaneh]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Hesab_Xazaneh] FOREIGN KEY([FK_Xazaneh_Vaziat])
REFERENCES [Xazane].[tbl_Hesab_Xazaneh] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_Hesab_Xazaneh]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_User] FOREIGN KEY([FK_User_Add])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_User]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Check_tbl_User1] FOREIGN KEY([FK_User_Edit])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Check] CHECK CONSTRAINT [FK_tbl_Amaliat_Check_tbl_User1]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Amaliat_Title] FOREIGN KEY([FK_Faktor])
REFERENCES [Anbar].[tbl_Amaliat_Title] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Amaliat_Title]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Riz] FOREIGN KEY([FK_Qest_Riz])
REFERENCES [Aqsat].[tbl_Aqsat_Riz] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Aqsat_Riz]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Ashxas] FOREIGN KEY([FK_ShaXs])
REFERENCES [Base].[tbl_Ashxas] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_Ashxas]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_User] FOREIGN KEY([FK_User_Add])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_User]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_tbl_User1] FOREIGN KEY([FK_User_Edit])
REFERENCES [General].[tbl_User] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_DP] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_tbl_User1]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_Xazaneh_tbl_Amaliat_DP] FOREIGN KEY([FK_DP])
REFERENCES [Xazane].[tbl_Amaliat_DP] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_Xazaneh_tbl_Amaliat_DP]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_DP_Xazaneh_tbl_Base_Xazaneh] FOREIGN KEY([FK_Xazaneh_Bas])
REFERENCES [Xazane].[tbl_Hesab_Xazaneh] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] CHECK CONSTRAINT [FK_tbl_Amaliat_DP_Xazaneh_tbl_Base_Xazaneh]
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Amaliat_Xazaneh_tbl_Base_Xazaneh] FOREIGN KEY([FK_Xazaneh_Bad])
REFERENCES [Xazane].[tbl_Hesab_Xazaneh] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Amaliat_Xazaneh] CHECK CONSTRAINT [FK_tbl_Amaliat_Xazaneh_tbl_Base_Xazaneh]
GO
ALTER TABLE [Xazane].[tbl_Daste_Cheque_Riz]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Daste_Cheque_Riz_tbl_Base_Daste_Chque] FOREIGN KEY([FK_Dasteh_Cheque])
REFERENCES [Xazane].[tbl_Daste_Chque] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [Xazane].[tbl_Daste_Cheque_Riz] CHECK CONSTRAINT [FK_tbl_Base_Daste_Cheque_Riz_tbl_Base_Daste_Chque]
GO
ALTER TABLE [Xazane].[tbl_Daste_Chque]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Daste_Chque_tbl_Base_Xazaneh] FOREIGN KEY([FK_Xazaneh])
REFERENCES [Xazane].[tbl_Hesab_Xazaneh] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Daste_Chque] CHECK CONSTRAINT [FK_tbl_Base_Daste_Chque_tbl_Base_Xazaneh]
GO
ALTER TABLE [Xazane].[tbl_Hesab_Xazaneh]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Base_Xazaneh_tbl_Bank] FOREIGN KEY([FK_Bank])
REFERENCES [Base].[tbl_Bank] ([ID])
GO
ALTER TABLE [Xazane].[tbl_Hesab_Xazaneh] CHECK CONSTRAINT [FK_tbl_Base_Xazaneh_tbl_Bank]
GO
/****** Object:  StoredProcedure [dbo].[CreateBackup]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE  PROCEDURE [dbo].[CreateBackup]
(
	@Path NVARCHAR(MAX),@BackCreated BIT OUTPUT,@ZipCreated BIT OUTPUT
)
AS
BEGIN
	DECLARE @DbName		NVARCHAR(MAX)
	DECLARE @Command	NVARCHAR(MAX)
	DECLARE @FileName	NVARCHAR(MAX)
	DECLARE @sqlcmd		NVARCHAR(MAX)

	SET @DbName= DB_NAME();

	SET @BackCreated = 0
	SET @ZipCreated=0

	BEGIN TRY
		BACKUP DATABASE   @DbName  TO  DISK = @Path WITH NOFORMAT, NOINIT,  NAME = @DbName   , SKIP, NOREWIND, NOUNLOAD,  STATS = 10
		COMMIT TRANSACTION
	SET @BackCreated= 1
	END TRY
    BEGIN CATCH
		SET @BackCreated= 0
	END CATCH
	--=========================

	BEGIN TRY
		
		EXEC master.dbo.sp_configure 'show advanced options', 1
		RECONFIGURE WITH OVERRIDE
		
		EXEC master.dbo.sp_configure 'xp_cmdshell', 1
		RECONFIGURE WITH OVERRIDE
		

	SET @FileName=(left((@Path),LEN(@Path)- charindex('.', reverse(@Path))+1))
	set @sqlcmd = 'EXEC xp_cmdshell ''rar.exe mf -ep -df -o+ -inul "'+@FileName+'rar" "'+@Path+'"'''
			EXEC (@sqlcmd)
	SET @ZipCreated =1

		EXEC master.dbo.sp_configure 'xp_cmdshell', 0
		RECONFIGURE WITH OVERRIDE

		EXEC master.dbo.sp_configure 'show advanced options', 0
		RECONFIGURE WITH OVERRIDE
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
			SET @ZipCreated =0
			print ERROR_MESSAGE() 
	END CATCH
	
END


GO
/****** Object:  StoredProcedure [General].[CreateBackup]    Script Date: 02/08/2025 4:09:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [General].[CreateBackup]
(
	@Path NVARCHAR(MAX),@BackCreated BIT OUTPUT,@ZipCreated BIT OUTPUT
)
AS
BEGIN
	DECLARE @DbName		NVARCHAR(MAX)
	DECLARE @Command	NVARCHAR(MAX)
	DECLARE @FileName	NVARCHAR(MAX)
	DECLARE @sqlcmd		NVARCHAR(MAX)

	SET @DbName= DB_NAME();

	SET @BackCreated = 0
	SET @ZipCreated=0

	BEGIN TRY
		BACKUP DATABASE   @DbName  TO  DISK = @Path WITH NOFORMAT, NOINIT,  NAME = @DbName   , SKIP, NOREWIND, NOUNLOAD,  STATS = 10
		COMMIT TRANSACTION
	SET @BackCreated= 1
	END TRY
    BEGIN CATCH
		SET @BackCreated= 0
	END CATCH
	--=========================

	BEGIN TRY
		
		EXEC master.dbo.sp_configure 'show advanced options', 1
		RECONFIGURE WITH OVERRIDE
		
		EXEC master.dbo.sp_configure 'xp_cmdshell', 1
		RECONFIGURE WITH OVERRIDE
		

	SET @FileName=(left((@Path),LEN(@Path)- charindex('.', reverse(@Path))+1))
	set @sqlcmd = 'EXEC xp_cmdshell ''rar.exe mf -ep -df -o+ -inul "'+@FileName+'rar" "'+@Path+'"'''
			EXEC (@sqlcmd)
	SET @ZipCreated =1

		EXEC master.dbo.sp_configure 'xp_cmdshell', 0
		RECONFIGURE WITH OVERRIDE

		EXEC master.dbo.sp_configure 'show advanced options', 0
		RECONFIGURE WITH OVERRIDE
		COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
			SET @ZipCreated =0
			print ERROR_MESSAGE() 
	END CATCH
	
END
GO
USE [master]
GO
ALTER DATABASE [DB_NzResaaStore] SET  READ_WRITE 
GO
