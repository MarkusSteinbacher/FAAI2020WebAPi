using FAAI2020WebAPI_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PersistentFile
{
	public interface IPresistentLineItemContract
	{
		void WriteLineItem(LineItem lineItem);
		IEnumerable<LineItem> ReadLineItems();
		LineItem ReadLineItem(string id);
		LineItem ReadLineItem(Func<LineItem, bool> func);
	}
}
