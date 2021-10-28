using FAAI2020WebAPI_Contract.PersitentContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Contract.ServiceContract
{
	public interface IOrderService
	{
		IQueryable<IOrder> GetOrders();
		void WriteOrder(IOrder order);
	}
}
