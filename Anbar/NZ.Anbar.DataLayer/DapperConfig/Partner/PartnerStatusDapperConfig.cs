using NZ.Anbar.Model;
using ShareLib.Interfaces;
using ShareLib.Models.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Partner
{
	public class PartnerStatusDapperConfig : DapperEntityConfiguration<PartnerStatus>
	{
		public PartnerStatusDapperConfig()
		{
			SetList(@"

");
			SetItem(@"



");
		}
	}
}

/*
 DECLARE 
   
   @SumFroshKalaAmani		DECIMAL,
   @SumFroshKalaAdi		DECIMAL,
   @MandeKalaAdi			DECIMAL,
   @MandeKalaAmani			DECIMAL,
   @SumSoodKala			DECIMAL
   
   SELECT 
   
   @SumFroshKalaAmani  = SUM( CASE WHEN tatd.IsAmani = 1 THEN  (tar.meqdar - tar.Remain) * tar.nerkh    ELSE 0 END ) ,
   @MandeKalaAmani     = SUM( CASE WHEN tatd.IsAmani = 1 THEN  (tar.Remain * tar.nerkh)                 ELSE 0 END ) ,
   																												     
   @SumFroshKalaAdi    = SUM( CASE WHEN tatd.IsAmani = 0 THEN  (tar.meqdar - tar.Remain) * tar.nerkh    ELSE 0 END ) ,
   @MandeKalaAdi       = SUM( CASE WHEN tatd.IsAmani = 0 THEN  (tar.Remain * tar.nerkh)                 ELSE 0 END ) 
   
   FROM        Anbar.tbl_Amaliat_Riz                AS tar 
   INNER JOIN  Anbar.tbl_Amaliat_Title              AS tat     ON tat.ID   =   tar.FK_Title
   INNER JOIN  Anbar.tbl_Amaliat_Title_Detail       AS tatd    ON tat.ID   =   tatd.ID 
   
   WHERE 
       tat.FK_Salmali  = @Year 
   AND tat.kind        = 12
   AND (tat.tarikh >= @Start   OR @Start   IS NULL)
   AND (tat.tarikh <= @End     OR @End     IS NULL)
   
   
   SELECT 
   
   @SumSoodKala    = SUM(tar.mablaq - tar.nerkh_2)  
   
   FROM        Anbar.tbl_Amaliat_Riz                AS tar 
   INNER JOIN  Anbar.tbl_Amaliat_Title              AS tat     ON tat.ID   =   tar.FK_Title
   --INNER JOIN  Anbar.tbl_Amaliat_Title_Detail       AS tatd    ON tat.ID   =   tatd.ID 
   
   WHERE 
       tat.FK_Salmali  = @Year 
   AND tat.kind        = 50
   AND (tat.tarikh >= @Start   OR @Start   IS NULL)
   AND (tat.tarikh <= @End     OR @End     IS NULL)
   
   
   SELECT	@SumFroshKalaAmani		AS SumFroshKalaAmani ,
   		@SumFroshKalaAdi		AS SumFroshKalaAdi ,
   		@MandeKalaAdi			AS MandeKalaAdi, 
   		@MandeKalaAmani			AS MandeKalaAmani, 
   		@SumSoodKala			AS SumSoodKala
 */