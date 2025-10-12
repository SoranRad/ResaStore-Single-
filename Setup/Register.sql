USE DB_NzResaaStore																																																												

GO

DECLARE @MSG			NVARCHAR(max)=N'zWO/sdSe7zutTEXZTBMAa5WJH4a/GkjSblivKth91PCRzdXo+riUnEeuX1E3CIrwrYnRgch6gDH/R6UHS/PNqOW5p7oTLRBqgbMDw6weMcMufMmGfdgK12tSdo37uQMr/IHjSKbV4le4DAB7imd7SKsSGTpJVQiz+Tht4QraKTI=';
DECLARE @Serial			NVARCHAR(max)=N'wdkRwTEJvR5pNxuWAuUxQfED3BfOe4iWK+J85uel7SoG08+sGkcOFoj63r2l+7PX2p80V5Wpy4q8qsc7IAeGpStA3B/rHGKdPRYTy54l8+ioYI1U21iMCvSftq2LEyiqMktLciqrBBM/2XmGnOYBsI98VtWpFDYO5WKlOqIdIf4=';
DECLARE @Title			NVARCHAR(max)=N'nW20BWN/dzPtdpP04p2bhnD73XOujtR4xfuyXzv8Rw7Cqg4IDmUHtsfr/czJm8t6ZGNdE6hD4lWNJLruDHaEL4eyuDoS/a5llHz7izz/7y6KjEHIIrcxMQlbexw7sUwlIG9duWcD9ZqDwtBtzsZf7I5sChhQlI6drpQzX5SNLEI=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'fi16Q7QOKNIMuF1LUl7Hg+7KDEDfxqv3Soz+pIqvt3CENJNAwbSgsI4QUbcQxN+yJXmhSHajB0vTtESsHFE4QP0ABtUmxkSP37iEd4JV9Zv/Yvz5DY0aTTYxbeZOHO8ZK8fWU+VPnJVkghdFQcVbz8mPnhtIPLbneQ0IOMaGkXM=';
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