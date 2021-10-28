namespace FAAI2020WebAPI_Contract.ServiceContract
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using System.Linq;
    public interface IOrderService
    {
        IQueryable<IOrder> GetOrders();
        void WriteOrder(IOrder order);
    }
}
