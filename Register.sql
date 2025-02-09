USE DB_NzResaaStore

GO

DECLARE @MSG			NVARCHAR(max)=N'gOGq2DlKtWzrERGjZa4JWuyBQ6MR6U98yUC3gsOmJefIt5gmQO8Xil/lGwAwO6tu33MfYrrN7ksL+aY/KVq2Wd5eya0/WwT+EOuv9/eGtn/dE73eG1gE4f188PMoUzw+uVEnDmWLzrSUDx72TT9vbyV1PzByw5v31t++nNWuWis=';
DECLARE @Serial			NVARCHAR(max)=N'FTLC5jukKAMLfunu9SGNGp81NCpPBjyjVMmaehTs6CjRqPce1oTRCHbBfm1is7rIiXEaFkxMalICMQOMYY9WgIv2xLwXhA91AH7E2KjsCuJTUSdwq8P0JmrIY2BSyv4TQ2W+IWHE2ATBXzcvJyNRY5Sx+Lhc2IN5Nab7xPS+9Is=';
DECLARE @Title			NVARCHAR(max)=N'MEXAXdTmnLOKfFHpMsr/iLS4jnuDr8kivV0ooCvYbpi6uQzY3uFE0n1VNNLtOjmyuPAe5lZsT6Cwxy4/iksN+NpnDvTs+YabcT1tuea5480Bl4/JyAREE657Ywuf0A4gyiTbURp/A99/bukY+cWKY9ROqglqGeIKPXZjzE62PLI=';
DECLARE @Address		NVARCHAR(max)=N'تهران';
DECLARE @StartDate		NVARCHAR(max)=N'nqRoqX5PkYQ+lHDi+AUCaL9HVliEIIrsUradXOinD5pJiA9vD+xMmWiDN2Up7m+JDeM3/MOv/AY7cYSAY9/1xiIHhb6O6/2san5f0uQQM2vVSG75/dSQFlBrPDJquC13k/U+T93DHJMx81z73O5dNzr4Xt0oh6cKwhWLtPlPA6A=';
DECLARE @Mobile			NVARCHAR(max)=N'09121438553';
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