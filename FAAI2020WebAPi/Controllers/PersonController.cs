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
            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("GetPersons")]
        public ActionResult Person()
        {
            var result = this._PersonService.GetPersons();
            if (result != null && result.Any())
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpGet]
        [Route("GetPerson")]
        public ActionResult GetPerson(string personId)
        {
            var result = this._PersonService.GetPerson(personId);
            if (result != null)
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

        [HttpPost]
        [Route("PostWholeOrder")]
        public ActionResult PostOrder([FromBody] PersonDto personDto)
        {
            this._PersonService.WriteWholeOrder(personDto);
            return Ok();
        }

        [HttpDelete]
        [Route("DeletePerson")]
        public ActionResult DeletePerson(string id)
        {
            var result = this._PersonService.GetPerson(id);
            this._PersonService.DeletePerson(result);
            return Ok();
        }



    }
}
