using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class FactorPaymentResolverConfig : DapperEntityConfiguration<FactorPaymentResolve>
    {
        public FactorPaymentResolverConfig()
        {
//            SetItem(@"
//SELECT  tad.ID FROM Xazane.tbl_Amaliat_DP AS tad 
//WHERE tad.FK_Faktor = @ID
//");

//            SetList(@"
//DELETE FROM Xazane.tbl_Amaliat_DP
//WHERE FK_Faktor = @ID
//");


            SetList
            (@"
                SELECT  tad.ID 
                FROM Xazane.tbl_Amaliat_DP AS tad 
                WHERE   tad.FK_Faktor = @ID
            ");

        }
    }
}
