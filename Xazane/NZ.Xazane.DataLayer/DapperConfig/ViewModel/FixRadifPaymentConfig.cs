using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
	public  class FixRadifPaymentConfig :  DapperEntityConfiguration<FixRadifPayment>
	{
		public FixRadifPaymentConfig()
		{
			SetItem(@"

UPDATE Xazane.tbl_Amaliat_DP  set Fk_Factor_radif_Id =  @Fk_kala
WHERE FK_Faktor = @IdFaktor 

");
		}
	}
}
