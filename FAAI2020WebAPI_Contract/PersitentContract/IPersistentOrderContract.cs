using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.PersitentContract
{
	public interface IPersistentOrderContract
	{
		void WriteOrder(IOrder order);
		IEnumerable<IOrder> ReadOrders();
		IOrder ReadOrder(Func<IOrder, bool> func);
	}
}
