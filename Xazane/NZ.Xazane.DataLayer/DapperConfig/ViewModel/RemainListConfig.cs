using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class RemaindListConfig : DapperEntityConfiguration<RemaindList>
    {
        public RemaindListConfig()
        {
            SetList(@"
SELECT 
ta.ID,
ta.code,
LTRIM(RTRIM(ta.title)) AS  title,
ta.codeMeli,
LTRIM(RTRIM(ta.namePedar)) AS namePedar,

tad.ID AS ID_DP,
tad.FK_Salmali ,
tad.FK_User_Add ,
tad.FK_User_Edit ,
tad.takhfif ,
tad.kind ,
tad.tarikh ,
tad.tarikh_add ,
tad.tarikh_edit ,
LTRIM(RTRIM(tad.sharh ))  AS sharh

FROM Base.tbl_Ashxas AS ta
LEFT OUTER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.FK_ShaXs = ta.ID AND (tad.kind = @Kind1 OR tad.kind = @Kind2 )AND tad.FK_Salmali=@Year
");
        }
    }
}
