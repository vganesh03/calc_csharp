using Microsoft.AspNetCore.Mvc;

namespace SumCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<decimal> CalculateSum([FromBody] Numbers numbers)
        {
            var sum = numbers.Number1 + numbers.Number2;
            return sum;
        }
    }

    public class Numbers
    {
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
    }
}
