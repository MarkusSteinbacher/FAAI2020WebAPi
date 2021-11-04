using AutoMapper;
using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Contract.ServiceContract;
using FAAI2020WebAPI_PersistentFile.PresistentContracts;
using FAAI2020WebAPI_PresistentFile;
using FAAI2020WebAPI_Services.Dto;
using FAAI2020WebAPI_Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_Services
{
	public class OrderService : IOrderService
	{
		private readonly IPersistentOrderContract presistentOrderContract;
		private readonly IMapper mapper;

		public OrderService(IPersistentOrderContract presistentOrderContract, IMapper mapper)
		{
			this.presistentOrderContract = presistentOrderContract;
			this.mapper = mapper;
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
