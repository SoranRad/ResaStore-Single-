USE DB_NzResaaStore

GO

DECLARE @MSG			NVARCHAR(max)=N't3dWVHlFwgrR5SVv4cnbqyk0cZxgoQ8xu5Vm8yX3V5sEz+onxU51JwuS2h66Stpyuk05XLk89qcFjVQW4PxU/AzaFWP+DlB22lWUZOmuunMxiTfLjul037/CUOcYmDQzqOvCQZ9rBnRcYz17vPjlHLBN/M/eayp5QWDM+I1rKAw=';
DECLARE @Serial			NVARCHAR(max)=N'crXc+gTSdg9QmkyhUCO+mh2QXmQxiHEGh0+Z3C3UDzKspatJWLbH26g+vTya9kaz2PYGEkGaMGCBHkllqbENT6DU137esWyqaZvsDngwz7/ZoecY/SNQAxVlLvEBXL5KjgQas8WA5fbqfzH3RjbNVWE7m9057QU/Q+AkqnF7zWs=';
DECLARE @Title			NVARCHAR(max)=N'Sc5jyh8xEwHUTyaxjCNKDSufp92rak3m33zDTraedbqR7mb1JqaofYH5cYx7V1AruZZWJJ+Wd57IVaT1UjnhPI/gpADgzAdsUUxKX39ahj9bYn0q/VxaRsFJTR2oAMBkU/jeBzrkwyDHc7zNRY549FeaSBUbVFIRPTJhT3EaslU=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'bBC3sTvb3yTdjz1NM9f59kyXT0zODghNGnBhlAwgaidvEP7/4nw7K+tJtLksL7JHbA9+vQzzMqQzvLhUMagGx16b+nD/WsPyvz+/106ea7MuBhqIyjsOJNjc4cC6+kk03mhW3/VOK+/lLOHZFiySrgT5ZqHex/XxYrx1N7YDu6g=';
DECLARE @Mobile			NVARCHAR(max)=N'09143423010';
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