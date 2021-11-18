namespace FAAI2020WebAPI_Contract.PersitentContract
{
	using FAAI2020WebAPI_PresistentFile;
	using System;
	using System.Collections.Generic;

	public interface IPersistentOrderContract
	{
		void WriteOrder(Order order);
		IEnumerable<Order> ReadOrders();
		Order ReadOrder(Func<Order, bool> func);
	}
}
