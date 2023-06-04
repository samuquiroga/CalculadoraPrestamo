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
                TempData["Mensaje"] = "Cliente creado satisfactoriamente";
                return RedirectToAction("AbmCliente", "Cliente"); 
            }
            return View(cliente);
        }


        public IActionResult CrearCliente() { return View(); }



        private List<Cliente> ObtenerListaClientesDesdeLaBaseDeDatos()
        {
         List<Cliente> ListaCliente = new List<Cliente>();
         return ListaCliente;
        }

        [HttpGet]
        public async Task<IActionResult> AbmCliente()
        {
            return View(await _context.Cliente.ToListAsync());
        }




    }



}
