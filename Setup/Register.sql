USE DB_NzResaaStore																																																												

GO

DECLARE @MSG			NVARCHAR(max)=N'bTQRg8s3gAgp7kGZ3P6oV8Iwj1PuVMQByq3y778vmdrUaCng9WVKnhWxvyAvHXWZm41ndSeVqWdjS0DE9Nnrx58ueEbov8zBj81Y/ygzLUZG51NqIWvWvQLDRrzUkDOrilz4tNcxxNJppymZB01eSol/QSfw91GtKdQftVhrLNU=';
DECLARE @Serial			NVARCHAR(max)=N'EZXJj/GxwjOjcN13J2hy4ItI8Xgh+pWk57TWh6nFpcfDNuMDJhjbFGPHFKbamrRRI9d8jfbEPSytvW/jkkwC7q7321sBZOAQjBkJq9Tl0Fv0S17IiSaCm/k+AEwICQhWZukPJbm1TIJScs6cJcPKK+AH1nF3QaP75w8B/P7r5K4=';
DECLARE @Title			NVARCHAR(max)=N'TtFpCUpp1qeS0Ht7nxsP0F4siyHIeqeIAA3VruNw7eO2taRNHD2xd1ITp8uvYb/SSGugEQT1yHqPv0DKIJdyzwtpFeGnTGu+7ikcGV9eMtGyCoYt3McIfXHsuUSOI+B8u8vWO/iYTvq2FIpvnjclUW4scQqjSqy6/34QtITbL1M=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'AHX54SDCM0PoGG1MZNkXaDJm26WmLryJmC5gdbSmsJMC0PKG4HwUlpzPSLlRM+g2Fh8aJwwAndz7Zuy/dAqL0BPor/4x5i3SWgcUPS8fblVVA6Ze/4WJnDvBP7xtL3rRymQ12ApkhaNoG06/7vxG9RIPmU6TsfY3Wz68UkW/3bA=';
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