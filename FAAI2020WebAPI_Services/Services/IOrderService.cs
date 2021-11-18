namespace FAAI2020WebAPI_Services.Services
{
    using FAAI2020WebAPI_Services.Dto;
    using System.Collections.Generic;
    using System.Linq;

    public interface IOrderService
    {
        IQueryable<OrderDto> GetOrders();
        void WriteOrder(OrderDto order);

        public IEnumerable<LineItemDto> GetAllLineItemsOrder(string orderId);
    }
}
