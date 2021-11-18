namespace FAAI2020WebAPI_PresistentFile
{
	using FileHelpers;

	[DelimitedRecord(";")]
	public class LineItem
	{
        public string OrderId { get; set; }
        public string ArticleId { get; set; }
		public double Quantity { get; set; }
		public string Text { get; set; }
	}
}
