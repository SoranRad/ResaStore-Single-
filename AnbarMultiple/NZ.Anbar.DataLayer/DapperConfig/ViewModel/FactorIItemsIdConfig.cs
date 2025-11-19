using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class FactorIItemsIdConfig :DapperEntityConfiguration<FactorIItemsId>
    {
        public FactorIItemsIdConfig()
        {
            SetList(@"
                    SELECT	
                            tar.ID ,
                            tar.FK_Kala as Code

                    FROM	Anbar.tbl_Amaliat_Riz AS tar
                    WHERE	tar.FK_Title = @ID
            ");

        }
    }
}
