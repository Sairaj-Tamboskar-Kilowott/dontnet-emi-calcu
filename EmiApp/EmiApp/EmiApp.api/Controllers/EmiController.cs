using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmiApp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmiController : ControllerBase
    {
        [HttpPost]
        [Route("api/[controller]CalculateMonthlyEmi")]

        public Response CalculateMonthlyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();

            var response = new Calculator();

            var emiMonthly = emiCalculator.CalculateMonthlyEmi(request);
            return emiMonthly;
        }

        [HttpPost]
        [Route("api/[controller]CalculateDailyEmi")]

        public Response CalculateDailyEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();

            var response = new Calculator();

            var emiDaily = emiCalculator.CalculateDailyEmi(request);
            return emiDaily;
        }

        [HttpPost]
        [Route("api/[controller]CalculateContinuousEmi")]

        public Response CalculateContinuousEmi(Request request)
        {
            ICalculator emiCalculator = new Calculator();

            var response = new Calculator();

            var emiContinuous = emiCalculator.CalculateContinousEmi(request);
            return emiContinuous;
        }
    }
}
