using Microsoft.AspNetCore.Mvc;

namespace CalculadoraPrestamo.Controllers
{
    public class CreditoController : Controller
    {
        public IActionResult AbmCredito()
        {
            return View();
        }
    }
}
