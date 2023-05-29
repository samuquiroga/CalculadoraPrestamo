using System.ComponentModel.DataAnnotations;

namespace CalculadoraPrestamo.Models
{
    public class ConsultaPrestamo
    {
        [Key]
        public int Id { get; set; }
        public long MontoPrestamo { get; set; }
        //public int Moneda

        public float TasaInteres { get; set; }

        public int CantidadMeses { get; set; }

        public int ClienteId { get; set; }
        //public virtual Cliente Cliente { get; set; }
        public int CreditoId { get; set; }

        //public virtual Credito Credito { get; set; }

    }
}

