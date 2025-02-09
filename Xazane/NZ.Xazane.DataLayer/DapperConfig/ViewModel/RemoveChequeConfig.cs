using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class RemoveChequeConfig : DapperEntityConfiguration<RemoveChequeState>
    {
        public RemoveChequeConfig()
        {
            this.SetList(@"

                UPDATE Xazane.tbl_Amaliat_Check 

                    SET Kind_Vaziat			= NULL,
	                    Tarix_Vaziat		= NULL,
	                    FK_Salmali_Vaziat	= NULL,
	                    FK_Shaxs_Vaziat		= NULL,
                        FK_Xazaneh_Vaziat	= NULL,
	                    Sharh_Vaziat		= NULL,

                        FK_User_Add_Vaziat	= COALESCE(FK_User_Add_Vaziat ,@User),
                        FK_User_Edit_Vaziat = CASE WHEN FK_User_Add_Vaziat IS NULL THEN NULL ELSE @User END,
                        Tarix_Add_Vaziat	= COALESCE(Tarix_Add_Vaziat ,GETDATE()),
                        Tarix_Edit_Vaziat	= CASE WHEN Tarix_Add_Vaziat IS NULL THEN NULL ELSE GETDATE() END

                    WHERE  ");
        }
    }
}
