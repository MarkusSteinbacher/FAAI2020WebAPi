namespace FAAI2020WebAPi.Controllers
{
	using FAAI2020WebAPI_Services;
	using Microsoft.AspNetCore.Mvc;
	using System.Linq;

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
		public ActionResult PostLineItem([FromBody] LineItemDto lineItem)
		{
			this.lineItemService.WriteLineItems(lineItem);
			return Ok();
		}
	}
}
