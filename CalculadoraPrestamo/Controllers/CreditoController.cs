using CalculadoraPrestamo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CalculadoraPrestamo.Controllers
{
    public class CreditoController : Controller
    {
        private readonly CalculadoraPrestamoWeb _context;

        public CreditoController(CalculadoraPrestamoWeb context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> AbmCredito()
        {
            return View(await _context.Credito.ToListAsync());
        }




    }
}
