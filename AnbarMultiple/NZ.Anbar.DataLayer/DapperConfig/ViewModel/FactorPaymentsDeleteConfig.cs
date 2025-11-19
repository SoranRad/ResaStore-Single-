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
                DELETE FROM Xazane.tbl_Amaliat_DP
                WHERE 

            ");
        }
    }
}
