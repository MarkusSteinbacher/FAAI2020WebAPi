namespace FAAI2020WebAPi.Controllers
{
    using FAAI2020WebAPI_Contract.Services;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private readonly ICalcService _CalcService;

        public CalcController(ICalcService calcService)
        {
            this._CalcService = calcService;
        }

        //[HttpGet]
        //public ActionResult Add(string numberOne, string numberTwo)
        //{
        //    double result = 0;
        //    if (double.TryParse(numberOne, out var valueOne) && double.TryParse(numberTwo, out var valueTwo))
        //        result = this._CalcService.Add(valueOne, valueTwo);

        //    return Ok(result);
        //}


        //[HttpGet]
        //public ActionResult Add(double numberOne, double numberTwo)
        //{           
        //     var result = this._CalcService.Add(numberOne, numberTwo);
        //     return Ok(result);
        //}


        [HttpPost]
        public ActionResult Add(CalcDto calcDto)
        {
            var result = this._CalcService.Add(calcDto.NumberOne, calcDto.NumberTow);
            return Ok(new CalcResultDto(){ Result = result });
        }
    }
}
