using CalculadoraPrestamo.Data;
using CalculadoraPrestamo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CalculadoraPrestamo.Controllers
{
    
    public class ClienteController : Controller
    {
        private readonly CalculadoraPrestamoWeb _context;

        public ClienteController(CalculadoraPrestamoWeb context)
        {
            _context = context;
        }
        //Metodo post
        [HttpPost]
        public async Task<IActionResult> CrearCliente(Cliente cliente)
        {
                if (ModelState.IsValid)
                {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                }
            return View(cliente);
        }
        public IActionResult AbmCliente()
        {
            List<Cliente> ListaCliente = ObtenerListaClientesDesdeLaBaseDeDatos();
            return View();
        }

        public IActionResult CrearCliente() { return View(); }



        private List<Cliente> ObtenerListaClientesDesdeLaBaseDeDatos()
        {
         List<Cliente> ListaCliente = new List<Cliente>();
         return ListaCliente;
        }





    }



}
