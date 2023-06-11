using CalculadoraPrestamo.Data;
using CalculadoraPrestamo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculadoraPrestamo.Controllers
{
    public class ConsultaDePrestamoController : Controller
    {


        private readonly CalculadoraPrestamoWeb _context;

        public ConsultaDePrestamoController(CalculadoraPrestamoWeb context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AgregarPrestamo(ConsultaPrestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "Prestamo creado satisfactoriamente";
                return RedirectToAction("AbmConsulta", "ConsultaDePrestamo");
            }
            return View(prestamo);
        }

        [HttpGet]
        public async Task<IActionResult> AbmConsulta()
        {
            return View(await _context.ConsultaPrestamo.ToListAsync());
        }

       
    }
}
