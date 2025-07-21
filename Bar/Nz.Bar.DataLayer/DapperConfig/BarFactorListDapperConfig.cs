using NZ.Anbar.Model;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Bar.Model.Report;

namespace Nz.Bar.DataLayer.DapperConfig
{
	public class BarFactorListDapperConfig : DapperEntityConfiguration<BarFactorList>
	{
		public BarFactorListDapperConfig()
		{
			SetList($@"

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
[tbf].[VaznOft],
[tbf].[Nerkh],
[tbf].[Mablaq],
[tbf].[FK_User_Add],
[tbf].[FK_User_Edit],
[tbf].[Tarikh_add],
[tbf].[Tarikh_edit],

LTRIM(RTRIM(tc.CarType))+N' '+LTRIM(RTRIM(tc.Plak)) AS CarTitle,
LTRIM(RTRIM(ta.title)) AS PeopleTitle,
LTRIM(RTRIM(tkx.title)) AS KalaTitle

FROM                Bar.tbl_BarFactor       AS tbf
LEFT OUT JOIN       Bar.tbl_Car             AS tc   ON tc.ID    = tbf.FK_Car
INNER JOIN          Base.tbl_Ashxas         AS ta   ON ta.ID    = tbf.FK_People
INNER JOIN          Base.tbl_Kala_Xadamat   AS tkx  ON tkx.Code = tbf.FK_Kala

");
		}
	}
}
