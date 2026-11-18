
using ShareLib;
using System.ComponentModel.DataAnnotations.Schema;

namespace NZ.Xazane.Model.ViewModel
{
	public class PeopleChequePayment
	{
		public long			ID							{ get; set; }
		public byte?		Kind_Vaziat					{ get; set; }
		public string		shomare_check				{ get; set; }
		public decimal		mablaq						{ get; set; }
		public string		BankTitle					{ get; set; }
		public string		PersianUsanceStr			{ get; set; }
		public string		babat						{ get; set; }
		public string		PersianStr					{ get; set; }
		public string		tarikh_sar_resid			{ get; set; }
		public string		Shenase_Sayadi				{ get; set; }
		public string		CustomerTitle				{ get; set; }
		public string		Sharh_Vaziat				{ get; set; }
		[NotMapped]
		public Enums.NzItemState State { get; set; }
	}
}
