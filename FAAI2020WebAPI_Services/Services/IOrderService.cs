namespace FAAI2020WebAPI_Services.Services
{
    using FAAI2020WebAPI_Services.Dto;
    using System.Linq;

    public interface IOrderService
    {
        IQueryable<OrderDto> GetOrders();
        void WriteOrder(OrderDto order);
    }
}
