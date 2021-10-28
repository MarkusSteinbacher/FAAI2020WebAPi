namespace FAAI2020WebAPI_Services
{
    using System.Linq;
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Contract.ServiceContract;

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
