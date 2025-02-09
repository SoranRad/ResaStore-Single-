using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class FactorPaymentIDConfig : DapperEntityConfiguration<FactorPaymentID>
    {
        public FactorPaymentIDConfig()
        {
            SetItem(@"

SELECT TOP(1) tad.ID FROM Xazane.tbl_Amaliat_DP AS tad
WHERE tad.FK_Faktor = @ID

");
        }
    }
}
