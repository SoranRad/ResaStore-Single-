using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class PaymentChequeArriveBackInDateConfig: DapperEntityConfiguration<PaymentChequeArriveBackInDate>
    {
        public PaymentChequeArriveBackInDateConfig()
        {
            this.SetList(@"
                    UPDATE Xazane.tbl_Amaliat_Check 

                    SET Kind_Vaziat			= @Kind,
	                    Tarix_Vaziat		= @Date,
	                    FK_Salmali_Vaziat	= @Year,
	                    FK_Shaxs_Vaziat		= NULL,
                        FK_Xazaneh_Vaziat	= NULL,
                        FK_User_Add_Vaziat	= COALESCE(FK_User_Add_Vaziat ,@User),
                        FK_User_Edit_Vaziat = CASE WHEN FK_User_Add_Vaziat IS NULL THEN NULL ELSE @User END,
	                    Sharh_Vaziat		= @Desc,
                        Tarix_Add_Vaziat	= COALESCE(Tarix_Add_Vaziat ,GETDATE()),
                        Tarix_Edit_Vaziat	= CASE WHEN Tarix_Add_Vaziat IS NULL THEN NULL ELSE GETDATE() END

                    WHERE  ");
        }
    }
}
