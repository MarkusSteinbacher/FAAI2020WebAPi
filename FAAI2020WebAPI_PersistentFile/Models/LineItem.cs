namespace FAAI2020WebAPI_PresistentFile
{
    using FAAI2020WebAPI_PersistentFile.Models;
    using FileHelpers;

	[DelimitedRecord(";")]
	public class LineItem : BaseModel
	{
        public string ArticleId { get; set; }
		public double Quantity { get; set; }
		public string Text { get; set; }
	}
}
