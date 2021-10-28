using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
	public interface IOrder
	{
		string DocumentId { get; set; }
		string PersonId { get; set; }
		string Subject { get; set; }
		DateTime Date { get; set; }
	}
}
