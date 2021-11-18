namespace FAAI2020WebAPi.Controllers
{
    using FAAI2020WebAPI_Services.Services;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase
    {
        private readonly IPersonService _PersonService;

        public PersonController(IPersonService personService) 
        {
            this._PersonService = personService;
        }

        [HttpGet]
        public ActionResult Person()
        {
            var result = this._PersonService.GetPersons();
            if (result != null && result.Any())
            {
                return Ok(result);
            }

            return NoContent();
        }

    }
}
