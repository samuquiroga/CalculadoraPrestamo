using System.ComponentModel.DataAnnotations;

namespace CalculadoraPrestamo.Models
{
    public class Interes
    {
        [Key]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        public int RangoInferior { get; set; }
        public int RangoSuperior { get; set; }
        public float TasaInteres { get; set; }

        public Credito Credito { get; set; }
    }
}
