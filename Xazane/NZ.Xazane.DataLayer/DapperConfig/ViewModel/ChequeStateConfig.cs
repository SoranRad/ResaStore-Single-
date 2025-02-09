using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class ChequeStateConfig : DapperEntityConfiguration<ChequeState>
    {
        public ChequeStateConfig()
        {
            SetItem(@"
SELECT 

ddState.PersianStr				AS Date,
ddAdd.PersianStr				AS DateAdd ,
ddEdit.PersianStr				AS DateEdit,

LTRIM(RTRIM(UserAdd.title))		AS	UserAdd,
LTRIM(RTRIM(UserAdd.title))		AS	UserEdit,

LTRIM(RTRIM(ta.title))			AS PeopleAssign,
LTRIM(RTRIM(tac.Sharh_Vaziat))	AS Description,

tac.Kind_Vaziat					AS Kind,
tad.kind						AS MainKind,
LTRIM(RTRIM(thx.title))			AS AccountAct

 
FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad		ON tad.ID                   = tac.FK_DP
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx		ON thx.ID                   = tac.FK_Xazaneh_Vaziat

LEFT OUTER JOIN General.DimDate				AS ddState	ON ddState.GregorianDate	= tac.Tarix_Vaziat
LEFT OUTER JOIN General.DimDate				AS ddAdd	ON ddAdd.GregorianDate		= CAST(tac.Tarix_Add_Vaziat AS DATE)
LEFT OUTER JOIN General.DimDate				AS ddEdit	ON ddEdit.GregorianDate		= CAST(tac.Tarix_Edit_Vaziat AS DATE)

LEFT OUTER JOIN General.tbl_User			AS UserAdd	ON UserAdd.ID		        = tac.FK_User_Add_Vaziat
LEFT OUTER JOIN General.tbl_User			AS UserEdit	ON UserEdit.ID		        = tac.FK_User_Edit_Vaziat

LEFT OUTER JOIN Base.tbl_Ashxas				AS ta		ON tac.FK_Shaxs_Vaziat      = ta.ID


WHERE tac.ID = @ID

");
        }
    }
}
