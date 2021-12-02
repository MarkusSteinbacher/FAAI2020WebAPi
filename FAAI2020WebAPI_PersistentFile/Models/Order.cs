namespace FAAI2020WebAPI_PresistentFile
{
    using FAAI2020WebAPI_PersistentFile.Models;
    using FileHelpers;
	using System;

	[DelimitedRecord(";")]
	public class Order : BaseModel
	{
		public string PersonId { get; set; }
		public string Subject { get; set; }
		public DateTime Date { get; set; }
    }
}
