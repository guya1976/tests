namespace Calculator.Controllers
{
    using BL;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculator _calculator;

        public CalculatorController(ICalculator calculator)
        {
            _calculator = calculator;
        }

        [HttpGet(nameof(Add))]
        public ActionResult<int> Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        [HttpGet(nameof(Divide))]
        public ActionResult<int> Divide(int a, int b)
        {
            return _calculator.Divide(a, b);
        }
    }
}
