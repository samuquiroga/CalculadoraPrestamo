using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace CalculadoraPrestamo.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int DNI { get; set; }


     
    }
  
  
}