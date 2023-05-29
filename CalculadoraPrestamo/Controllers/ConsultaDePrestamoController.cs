using Microsoft.AspNetCore.Mvc;

namespace CalculadoraPrestamo.Controllers
{
    public class ConsultaDePrestamoController : Controller
    {
        public IActionResult AbmConsulta()
        {
            return View();
        }
    }
}
