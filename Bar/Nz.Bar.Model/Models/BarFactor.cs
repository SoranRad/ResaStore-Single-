using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace Nz.Bar.Model.Models
{
	public class BarFactor :  ISqlQueryMaker, ICodeEntity
	{

		public long                         ID						{ get; set; }
		public short                        FK_Salmali				{ get; set; }
		public byte                         kind					{ get; set; }
		public bool                         is_ok					{ get; set; }


        public short?                       FK_Car					{ get; set; }
        public long                         FK_People				{ get; set; }
		public int							FK_Kala					{ get; set; }
        public int                          Serial					{ get; set; }
        public DateTime                     Tarikh					{ get; set; }
		public string                       Tozihat					{ get; set; }

		 
		public decimal						VaznPorMachine			{ get; set; }
		public decimal						VaznKHaliMachine		{ get; set; }
		public decimal						TedadBox				{ get; set; }
		public decimal						VaznKhaliBox			{ get; set; }
		public decimal						VaznOft					{ get; set; }
		public decimal						Nerkh					{ get; set; }
		public decimal                      Mablaq					{ get; set; }


		public short                        FK_User_Add				{ get; set; }
		public short?                       FK_User_Edit			{ get; set; } 
		public DateTime                     Tarikh_add				{ get; set; }
		public DateTime?                    Tarikh_edit				{ get; set; }




		//public NzObject						Kala					{ get; set; }
		public Car Car { get; set; }
		//public People						People					{ get; set; }
		//public Year							Year					{ get; set; }
		//public User							UserAdd					{ get; set; }
		//public User							UserEdit				{ get; set; }

		public string GetItem()
		{
			return $@"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
WHERE tbb.ID= @ID
";
		}

		public string GetList()
		{
			return $@"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
WHERE tbb.ID= @ID
";
		}

		public string GenerateCode()
		{
			return @"SELECT MAX(tba.Code )
                        FROM Base.tbl_Base_Anbar AS tba";
		}

		public string UniqueCode()
		{
			return @"SELECT COUNT(tba.ID)
                    FROM Base.tbl_Base_Anbar AS tba
                    WHERE tba.Code = @Code";
		}

		public string CircularQuery()
		{
			return @"
SELECT TOP(1) tar.ID  FROM Anbar.tbl_Amaliat_Riz AS tar
WHERE (tar.FK_Anbar_Az=@Code OR tar.FK_Anbar_Be=@Code)
";
		}
	}
}
