using home_asp_net_core_dependency_injection.Services;
using Microsoft.AspNetCore.Mvc;

namespace home_asp_net_core_dependency_injection.Controllers
{
    public class HomeController : Controller
    {
        ICalc _calc;

        public HomeController(ICalc calc)
        {
            _calc = calc;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Sum()
        {
            return View();
        }

        [HttpPost]
        public int Sum(int operand1, char action, int operand2)
        {
            
        }
    }
}
