namespace FAAI2020WebAPI_Services
{
	using AutoMapper;
	using FAAI2020WebAPI_Contract.PersitentContract;
	using FAAI2020WebAPI_PersistentFile.PresistentContracts;
	using FAAI2020WebAPI_PresistentFile;
	using FAAI2020WebAPI_Services.Dto;
	using FAAI2020WebAPI_Services.Services;
	using System.Collections.Generic;
	using System.Linq;

	public class OrderService : IOrderService
	{
		private readonly IPersistentOrderContract presistentOrderContract;
		private readonly IMapper mapper;
		private readonly IPresistentLineItemContract _PresistentLineItemContract;

		public OrderService(IPersistentOrderContract presistentOrderContract, IPresistentLineItemContract presistentLineItemContract ,IMapper mapper)
		{
			this.presistentOrderContract = presistentOrderContract;
			this.mapper = mapper;
			this._PresistentLineItemContract = presistentLineItemContract;
		}

        public IEnumerable<LineItemDto> GetAllLineItemsOrder(string orderId)
        {
			var lineItems = this._PresistentLineItemContract.ReadLineItems().Where(w => w.OrderId == orderId);
			return this.mapper.Map<IEnumerable<LineItemDto>>(lineItems);
        }

        public IQueryable<OrderDto> GetOrders()
		{
			var result = this.mapper.Map<List<OrderDto>>(this.presistentOrderContract.ReadOrders());
			return result.AsQueryable();
		}

		public void WriteOrder(OrderDto orderDto)
		{
			var result = this.mapper.Map<Order>(orderDto);
			this.presistentOrderContract.WriteOrder(result);
		}
	}
}
