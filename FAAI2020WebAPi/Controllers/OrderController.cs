using FAAI2020WebAPI_Contract.PersitentContract;
using FAAI2020WebAPI_Contract.ServiceContract;
using FAAI2020WebAPI_Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAAI2020WebAPi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService orderService;

		public OrderController(IOrderService orderService)
		{
			this.orderService = orderService;
		}

		[HttpGet]
		public ActionResult GetOrder()
		{
			var result = this.orderService.GetOrders();
			if (result != null && result.Any())
			{
				return Ok(result);
			}
			return NoContent();
		}

		[HttpPost]
		public ActionResult PostOrder([FromBody] Order order)
		{
			this.orderService.WriteOrder(order);
			return Ok();
		}

	}
}
