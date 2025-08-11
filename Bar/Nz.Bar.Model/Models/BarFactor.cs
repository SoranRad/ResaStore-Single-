using System;
using ShareLib.Interfaces;

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
		public decimal						SumKhaliBox				{ get; set; }

		public decimal						DarsadOft				{ get; set; }
		public decimal						VaznOft					{ get; set; }
		public decimal						VaznKHales				{ get; set; }
		public decimal						Nerkh					{ get; set; }
		public decimal                      Mablaq					{ get; set; }
		public decimal                      MablaqKeraye			{ get; set; }
		

		public short                        FK_User_Add				{ get; set; }
		public short?                       FK_User_Edit			{ get; set; } 
		public DateTime                     Tarikh_add				{ get; set; }
		public DateTime?                    Tarikh_edit				{ get; set; }

		 
		public Car		Car			{ get; set; } 



		public string GetItem()
		{
			return $@"
SELECT 

[tbf].[ID],
[tbf].[FK_Salmali],
[tbf].[kind],
[tbf].[is_ok],
[tbf].[FK_Car],
[tbf].[FK_People],
[tbf].[FK_Kala],
[tbf].[Serial],
[tbf].[Tarikh],
LTRIM(RTRIM([tbf].[Tozihat])) AS Tozihat,
[tbf].[VaznPorMachine],
[tbf].[VaznKHaliMachine],
[tbf].[TedadBox],
[tbf].[VaznKhaliBox],
[tbf].[SumKhaliBox],
[tbf].[VaznKHales],
[tbf].[DarsadOft],
[tbf].[VaznOft],
[tbf].[Nerkh],
[tbf].[Mablaq],
[tbf].[MablaqKeraye], 
[tbf].[FK_User_Add],
[tbf].[FK_User_Edit],
[tbf].[Tarikh_add],
[tbf].[Tarikh_edit]

FROM Bar.tbl_BarFactor AS tbf
WHERE tbf.ID= @ID
";
		}

		public string GetList()
		{
			return $@"";
		}

		public string GenerateCode()
		{
			return @"SELECT MAX(tbf.[Serial]) FROM Bar.tbl_BarFactor AS tbf WHERE tbf.FK_Salmali = @Year";

		}

		public string UniqueCode()
		{
			return @"SELECT COUNT(tbf.ID) FROM Bar.tbl_BarFactor AS tbf  WHERE tbf.Serial = @Code";
		}

		public string CircularQuery()
		{
			return @"";
		}
	}
}
