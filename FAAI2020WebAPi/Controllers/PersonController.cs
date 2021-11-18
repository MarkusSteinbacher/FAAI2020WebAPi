namespace FAAI2020WebAPi.Controllers
{
    using FAAI2020WebAPI_Services.Dto;
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
        [Route("GetAllOrdersForPerson")]
        public ActionResult GetAllOrdersForPerson(string personId)
        {
            var result = this._PersonService.GetAllOrdersPerson(personId);
            if (result != null && result.Any())
            {
                return Ok(result);
            }

            return NoContent();
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

        [HttpPost]
        public ActionResult PostPerson([FromBody] PersonDto personDto)
        {
            this._PersonService.WritePerson(personDto);
            return Ok();
        }



    }
}
