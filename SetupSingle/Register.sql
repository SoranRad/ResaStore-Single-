USE DB_NzResaaStore																																																												

GO

DECLARE @MSG			NVARCHAR(max)=N'XgFJeJbJmnAaDgbOllbBKrSVn/79XESWJyXNxdcc5haCSvRCZ4gjk8saVh5SZ5Zt1Kq9V819DY0tqdm8kGALc8+jI88VcGgZGWmxmxSeCgaKm9aluxH5esX2LGfKJfh9y+DF0+WUry6t6jIhR8is+DOuSeah+d9Th+MnIPLL34U=';
DECLARE @Serial			NVARCHAR(max)=N'OMP+TTnNtyfaYtRn8CnluXVBtxn/oFVSX3g5PcjYd6rAO3z6w0cL06zHEOjCR6euMlACz5gEmPlijnBP+SrAOh4vm1m7yDCoC3Sife2KtQIWs+armyahdVXvwCaNIdMVMdynFeKV7dvDGYJ0lOjAfznPnoPBUjP80bW6wpBK09Y=';
DECLARE @Title			NVARCHAR(max)=N'XN1EzDtxWGoX9yezE3IjtCDMCayImL5/vox/QYfhi5IgWTSYS3KvNumfW4Zf+oxYHFnXyx2uJzUEaiLAV8U7ajr+WDzBFvL9SqoqOPha7WnSB4mIJrduHVntBnyU/0XmJOM9NkKvrba25X0KcD5t1+KpeMw2llU8QBmNehCE/6A=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'sq44oC5ZQZ6feDOwHFrO0+SBI7N7yWuCzJS1zvIgWAwhyxnWLtpT5k+r0oOfCzjenAbJKt7Egle2Ktm9+V+e+Icw5isKTN7nw+DYtpZiGq9U0GQ18ZIFX2y5B0hUaVtYha2XGNfzD//G2ps6EqEYRAMGuIN4ZnrVHYT9Zh9Mf6Q=';
DECLARE @Mobile			NVARCHAR(max)=N'09394562843';
DECLARE @Email			NVARCHAR(max)=N'SORANNEW@gmail.com';
DECLARE @Year			SMALLINT=1404;
DECLARE @StartYear		DATE= '2025-03-20';
DECLARE @EndYear		DATE= '2026-03-20';

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
          NULL , 
          0 , 
          NULL 
        )