using CalculadoraPrestamo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculadoraPrestamo.Controllers
{
    public class InteresController : Controller
    {
        private readonly CalculadoraPrestamoWeb _context;

        public InteresController(CalculadoraPrestamoWeb context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<IActionResult> AbmInteres()
        {
            var intereses = _context.Interes.Include(i => i.Credito).ToList();
            return View(await _context.Interes.ToListAsync());
        }

    }
}
