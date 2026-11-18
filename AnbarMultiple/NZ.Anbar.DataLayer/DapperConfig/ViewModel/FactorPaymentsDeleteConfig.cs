using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class FactorPaymentsDeleteConfig : DapperEntityConfiguration<FactorPaymentsDelete>
    {
        public FactorPaymentsDeleteConfig()
        {
            SetItem
            (@"
UPDATE tac
SET 

FK_DP_Vagozari = null,
FK_Salmali_Vaziat = null,
Kind_Vaziat = null,
Tarix_Vaziat = null,
FK_Xazaneh_Vaziat = null,
FK_User_Edit_Vaziat = null,
FK_User_Add_Vaziat = null,
Tarix_Edit_Vaziat = null,
Tarix_Add_Vaziat = null,
Sharh_Vaziat = null,
FK_Shaxs_Vaziat = null


FROM  Xazane.tbl_Amaliat_Check AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP_Vagozari

WHERE tad.FK_Faktor = @ID;


DELETE FROM Xazane.tbl_Amaliat_DP
WHERE 	FK_Faktor =@ID;

            ");
        }
    }
}
