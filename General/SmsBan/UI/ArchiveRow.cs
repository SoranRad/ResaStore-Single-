namespace SmsBan.UI
{

 
	public class ArchiveRow
	{
		public long ID { get; set; }
		public string StatusText { get; set; }
		public string ContactName { get; set; }
		public string PhoneNumber { get; set; }
		public string MessageText { get; set; }
		public int PageCount { get; set; }
		public string CreatedAtShamsi { get; set; }
		public string SentAtShamsi { get; set; }
		public string SmsReference { get; set; }
		public string IsDelivered { get; set; }
		public string ErrorMessage { get; set; }
	}

	 
}
