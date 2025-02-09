USE DB_NzResaaStore

GO

DECLARE @MSG			NVARCHAR(max)=N'Kd45FVWMY2d3KasL2BG2nA8K3qw5SHBrlpiF/nL0r4Ki0z7v2g7NLk/k2Pr51I1kU9lX00OWavftafISVaMVKx+covqVZxZMfb+Z2ifgb7AG6yt7+NN0CYaUMFfLkhwohpPhv1LxhLEv8a+BgUVHfxAzC6gVpg0De38rG9B5hnU=';
DECLARE @Serial			NVARCHAR(max)=N'bQeafpxqTef/l1b9WYytvalGoXNoUA3QPwpFMSrJT7Rwken8sgKO3iQIrtKniBmyB97eBP9UwJv8/bjgXdrKmac6rtOx7MLOgdD2hnqTAA+IgQXeHzJJZ7nj/iYiK8ihXil9OS/jaRoi+ADSRUPFwAYm1Ka6jDqsw4RxOuXY2SQ=';
DECLARE @Title			NVARCHAR(max)=N'WbnQ5HgtSx/WVg4f3Rdq9YeKO0o4Q4lVcyneWDnaNp+GP1ldOjtMcaUOxvKeRPBtstS9ILA2qpLr16n3GT1LE751FB0P2rgTBOiq6ojWpy0iCBaTPq51fvcKvOJObS53H6MVJTfPG8yZmlTUrAVkT/5vccPkpolEBbmMUTz8yIo=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'wxcJB43TwTkba2PDunJKICn3XiKhQ7NQFEZnKsWeg91pWOPBPP90kGnyS1xOzvV3zdUWV32QMhmmO/vvoll6+q3TueipGfGvW6OhH8/fEEud80JnQgdJ1wK0IPybLUjK4L5IGp+SU4s4PHy6e1xIkeLx6ceITVJWS3CW8zvlNTg=';
DECLARE @Mobile			NVARCHAR(max)=N'09172825280';
DECLARE @Email			NVARCHAR(max)=N'SORANNEW@gmail.com';
DECLARE @Year			SMALLINT=1403;
DECLARE @StartYear		DATE= '2024-03-20';
DECLARE @EndYear		DATE= '2025-03-20';

INSERT INTO General.tbl_Config
(
    ActiveString,
    LastVersion,
    ModuleList
)
VALUES
(   @MSG, -- ActiveString - nvarchar(max)
    N'1.1.0', -- LastVersion - nvarchar(max)
    N'1,2,4,5,6'  -- ModuleList - nvarchar(max)
    )

INSERT INTO General.tbl_Info
        ( ID ,
          Code ,
          title ,
          tarikh ,
          address ,
          mobile ,
		  email
        )
VALUES  ( 1 , 
          @Serial,
		  @Title,
		  @StartDate,
		  @Address,
		  @Mobile,
		  @Email
        )

INSERT INTO General.tbl_Salmali
        ( Salmali ,
          darsad_arzesh_afzude ,
          is_close ,
          Money ,
          StartDate ,
          EndDate
        )
VALUES  ( @Year , 
          0 , 
          0 , 
          N'ریال' , 
          @StartYear , 
          @EndYear
        )

INSERT INTO General.tbl_User
        ( Code ,
          title ,
          kind ,
          user_name ,
          password ,
          default_password ,
          dastressi ,
          is_disable ,
          picture
        )
VALUES  ( 1 ,
          N'مدیر سیستم' ,
          2 ,
          N'1' , 
          N'uTOhwjj2BA4=' , 
          N'2Yswcyj7+ew=',
          N'X0woB2qleyjjky2aajyXpvC2Oq3AtyDoW/tJdZ0kfyI=' , 
          0 , 
          NULL 
        )