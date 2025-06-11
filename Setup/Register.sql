USE DB_NzResaaStore

GO

DECLARE @MSG			NVARCHAR(max)=N'UXzRuta/gWkYL9MXJ2w2b4axIy3Qy/w6SkoEXKXHamO3nZI6tJY5EBGYQEPdD3Io+UL+fRRh3dWfe43mh9qkMcR/vZKg7LxeYp4gCm5Y+kqLTcLv1W+3x882LHQ4tDa7p2hJM3f39R+yIXpnHLH0UqlO/kITuNPX5DQcEzZ500w=';
DECLARE @Serial			NVARCHAR(max)=N'MThD49J3HIllkz/KHi0zKpXGQRHT5Ls/0fI7eCPjq1iQSwAENIUPIDflbk32W4n0xec0jsX0p+3Guphh9kWBpuZTBU6mrOzVuFw1hJ5Pak2YQKE8PqrfbxACrbFldf9F5jpz5F3xXiimG43xojhpUvttw11w0reQQkQX+85gEVI=';
DECLARE @Title			NVARCHAR(max)=N'QKeXyl9HXMklJ9+O4WSHRTDm57lOUzL19UAppso4pR2TU8XuaJTOIHIsmvSNcviZ01HUjeh6fHJWjW62jo2S9xzvMhvSSe+gw84ipVtZZEZv7RId3UvrszxfqvtInIzjxC6hd+D0SuuL0mWh19g5whffFU+80g7av40yCLfbT1M=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'BWgQN01uOwOwVqDIhBb7hP47+V+jaTIWcNr/eLSsfyvYChsXkeeFvoXAWWmP6SdzCrsdQDjZM5Uf7xAZ69IRnxTaN6NypBykAqckG0+aGGs8wjzzxS+wxJOYNmyjFGUd7rPIdHRJ8wwSoC5CPF7g/Y+oSrtvq1zMLWXqE1p/2sQ=';
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