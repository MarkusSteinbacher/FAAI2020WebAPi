namespace FAAI2020WebAPI_PresistentFile
{
	using FileHelpers;
	using System;

	[DelimitedRecord(";")]
	public class Order
	{
		public string DocumentId { get; set; }
		public string PersonId { get; set; }
		public string Subject { get; set; }
		public DateTime Date { get; set; }
    }
}
