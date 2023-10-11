using Microsoft.EntityFrameworkCore;

namespace Transporte.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base (options) { }

        public  DbSet<Curso> Cursos { get; set; }   

        public DbSet<Veiculo> Veiculos { get; set;}
    }
}
