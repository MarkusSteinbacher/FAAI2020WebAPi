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
	public class LineItemController : ControllerBase
	{
		private readonly ILineItemService lineItemService;

		public LineItemController(ILineItemService lineItemService)
		{
			this.lineItemService = lineItemService;
		}

		[HttpGet]
		public ActionResult GetLineItem()
		{
			var result = this.lineItemService.GetLineItems();
			if (result != null && result.Any())
			{
				return Ok(result);
			}
			return NoContent();
		}

		[HttpPost]
		public ActionResult PostLineItem([FromBody] LineItem lineItem)
		{
			this.lineItemService.WriteLineItems(lineItem);
			return Ok();
		}
	}
}
