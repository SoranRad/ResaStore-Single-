USE DB_NzResaaStore

GO

DECLARE @MSG			NVARCHAR(max)=N'EhciTKw3Zu8nkb9TVzixS0hkLepWWBcNOc8MtMzW6rmZkdBLy3udjDEA5AbRIMilbQ0Zh9RvIhYjWgOrpIznRqmH9PlnqGbhFL094zo669JmxweFztVNWyCrEfJc90nGOHKZUEi6m6Cy4B8NxTCEBFgL5mCqGg05nQ/vJerYem8=';
DECLARE @Serial			NVARCHAR(max)=N'mvgPm6P8sfzGoDmLppHh7Jyu6PHq1Vz8A0c0/QbPdWNRcSYshb+PVw5O8Rzi0VtHcC9NmIuFknwggm6MmYNI4FOq43ZjeP9gZvkjq5kgirzenxfLUwNy5wX8+wDzPe202UYIIbJRhqG7i5Zp6DcSwLEJw+p/ZD3hxK1gKE+awCM=';
DECLARE @Title			NVARCHAR(max)=N'Bg+3pNmXb8v2Db44p1ZQMUWAlDKKSniZSqIm6DQLySnvFSJcGGz1YU8fjDxzMCodB4sC5g9n/+F/aGzzdHfK/X+1+0YGrEJmKcQIDDWN2Ff+axmTy96T+7cdgrxl3EjSzYuFS6iPJkL6jRJ1okZ7du259Lt8TuScVAiwIakAoDg=';
DECLARE @Address		NVARCHAR(max)=N'';
DECLARE @StartDate		NVARCHAR(max)=N'DIPChQqZlq5DZZq4qdSwqJOCCmYBRBobYsCL0e2+uMmH4alxpiPwscWLcHQ469IyxAhAEF4l0Gm2vfkR4ZmrS9cM54UM/IYjoPZ4YxFFIlWtyJR145TM2I2dDi35uLvnwg4GiXJCe0GIqgazk6TZsVqbVrjhA6u4lL75kqK/7m8=';
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