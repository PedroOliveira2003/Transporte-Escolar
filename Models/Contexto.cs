using Microsoft.EntityFrameworkCore;
using Transporte.Models;

namespace Transporte.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base (options) { }

        public  DbSet<Curso> Cursos { get; set; }   

        public DbSet<Veiculo> Veiculos { get; set;}

        public DbSet<Estudante> Estudantes { get; set; }

        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}
