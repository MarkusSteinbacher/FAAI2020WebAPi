using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
	public interface IPresistentLineItemContract
	{
		void WriteLineItem(ILineItem lineItem);
		IEnumerable<ILineItem> ReadLineItems();
		ILineItem ReadLineItem(string id);
	}
}
