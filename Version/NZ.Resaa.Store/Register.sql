
DECLARE @MSG			NVARCHAR(max)=N'JOiufKpxl3RFJr6cIaOWiYXasV9U7Y9vj0FDiK74o59QyJZpqB6pwjF9m5E3iTTUTE5ePNqy8L+tvM1BEDV0WMBq1ppHtbrW1AZ22hYkYn77Ome5cO0wIrHWInWwyJHqVsnMPX1dBHy01Bw82kMGvny5T0VOnu5e+UJCTqjAhk8=';
DECLARE @Serial			NVARCHAR(max)=N'uWQ0smrfgF7mPX2dUPGJAgwMYGPlMGqwnhDFbe54zFIeGLOYXNyaPeqHKIjC8EgEDuDODwdwKmQYi5axxBFt1GbmmwE4eyraopstcLQiouAE0ElkekzyWOi4IKDaCh0zk9k8M4DTpEfjGSj10phQbyixeqahEepRLkP4Mkoemrs=';
DECLARE @Title			NVARCHAR(max)=N'zSVnIHIpiP6dnF+XLkJ2nGdGaQbElO/FUiPZ2xCNj06G4xH1Oa4iu7Jfhki+5n04sm1r9LQlxjOidIYpSrV/Whm3g1LCYawxuGGDtfnjpfFTosc9yLo1gRK8W0D5yOyVlkhuJlc3qNQAWx5RKllfORUA5e74ahrkRY2fgX3vnto=';
DECLARE @Address		NVARCHAR(max)=N'سنندج، ';
DECLARE @StartDate		NVARCHAR(max)=N'nEKst8oHkYkUHTgobB2WZNdjArcIFYMOiTQUTW8I0F/nukHyx8EKhYOsFccIAr3lQvfLTdj5XLsBRXQTdthIQAt12/NCXRhSnBXoO5NqK32Zh+p3E1STsrGNOJlgG37GWHIy/vYvIaBClMmVWZhdGfdbWqdaEOngfkJIEM6E2bE=';
DECLARE @Mobile			NVARCHAR(max)=N'09183717118';
DECLARE @Email			NVARCHAR(max)=N'SORANNEW@YAHOO.COM';
DECLARE @Year			SMALLINT=1400;
DECLARE @StartYear		DATE= '2021-03-21';
DECLARE @EndYear		DATE= '2022-03-20';

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