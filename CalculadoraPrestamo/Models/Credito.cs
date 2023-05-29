using System.ComponentModel.DataAnnotations;

namespace CalculadoraPrestamo.Models
{
    public class Credito
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}
