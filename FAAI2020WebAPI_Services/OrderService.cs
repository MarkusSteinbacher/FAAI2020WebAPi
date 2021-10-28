using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Contract.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
	public class OrderService : IOrderService
	{
		private readonly IPersistentOrderContract _PersistentOrderContract;

		public OrderService(IPersistentOrderContract persistentOrderContract)
		{
			this._PersistentOrderContract = persistentOrderContract;
		}
		public IQueryable<IOrder> GetOrders()
		{
			return this._PersistentOrderContract.Read().AsQueryable();
		}

		public void WriteOrder(IOrder order)
		{
			this._PersistentOrderContract.Write(order);
		}
	}
}
