using Microsoft.EntityFrameworkCore;


namespace CalculadoraPrestamo.Data

{
    public class CalculadoraPrestamoWeb : DbContext
    {
        public CalculadoraPrestamoWeb(DbContextOptions options) : base(options) { } 

        public DbSet<CalculadoraPrestamo.Models.Cliente> Cliente { get; set; }
        public DbSet<CalculadoraPrestamo.Models.Credito> Credito { get; set; }
        public DbSet<CalculadoraPrestamo.Models.ConsultaPrestamo> ConsultaPrestamo { get; set; }
        public DbSet<CalculadoraPrestamo.Models.Interes> Interes { get; set; }
       


    }
}
