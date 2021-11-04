using FAAI2020WebAPI_Contract.PersitentContract;
using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PresistentFile
{
	[DelimitedRecord(";")]
	public class Order : IOrder
	{
		public string DocumentId { get; set; }
		public string PersonId { get; set; }
		public string Subject { get; set; }
		public DateTime Date { get; set; }
	}
}
