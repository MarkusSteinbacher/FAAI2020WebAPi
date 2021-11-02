namespace FAAI2020WebAPi.Controllers
{
    using FAAI2020WebAPI_Contract.PersitentContract;
    using FAAI2020WebAPI_Contract.ServiceContract;
    using FAAI2020WebAPI_Model;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService orderService)
        {
            this._OrderService = orderService;
        }

        [HttpGet]
        public ActionResult GetOrder()
        {
            var result = this._OrderService.GetOrders();
            if (result != null && result.Any())
                return Ok(result);

            return NoContent();
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] Order order)
        {
            this._OrderService.WriteOrder(order);
            return Ok();
        }
    }
}
