USE DB_NzResaaStore																																																												

GO

DECLARE @MSG			NVARCHAR(max)=N'hnxJcTb5p/xJVi78i3AdHnGo9qumMIseY414JdY4qC2/Qfi0cwxqqs0CW0Arb3dCFa5kP9YWc3uKxhaEGzURX6kGPVRGQFiB6NnCQSG+NCt9bk6YtmiUx4mzbKkEu8Ftz4pvtuvUqxknHmFsQHCDBigJfu8EefjsbbfkuwodJaQ=';
DECLARE @Serial			NVARCHAR(max)=N't+tlo7TzVnlZzgqfleC1X5Hk+Df8LdV9DP4PVdTTRkpMcwOlxW6ZUF/SC0c8VYK2nOFNElPnG29AdXqJSbzUNShgfTsdTmPrwMIOtu88Z1hLefVXaZCnYZtXzmpnQtc4jMV3OCku5GEf02qiD1/4RZgfhSscRs/ij6mFPr9P9bc=';
DECLARE @Title			NVARCHAR(max)=N'np1g9PU7ScASTxoCY6d1HMrTtR2kqGLD8SGym+Bf0dcoeJ2IM/Hlt4E2bdfNiyRjk/MPDce7k0fk8zEHxXDEDIlx1eY7JQXiNxiyeWTI7GAFPC0bl7ebgZ0ZJjWhNiAj4jwujw8Ceune4nfYI2tYqBC2jSUPLodPrm2kdRtlNAk=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'Yyn6VtmQtW7BB7sBZO3PdmBHCOVdAWlO8zmX2eSLLyJ2AyICTY+OR4+HPHpVT2Oa57uChivPHLJmJWW9GLDC0gb2aE+aR0h3mdzS89vEVnLYSPq7F0Vh/JeMAC8aNA/RulEdJoxG+V+hYS1NFh8kNUQrzOQZgOTzsYeeuGHOm34=';
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