using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class UpdatePaymentConfig : DapperEntityConfiguration<UpdatePaymentCustomer>
    {
        public UpdatePaymentConfig()
        {
            SetList(@"

UPDATE Xazane.tbl_Amaliat_DP

SET FK_ShaXs = @IDPeople 

WHERE FK_Faktor = @IDFactor

");
        }
    }
}
