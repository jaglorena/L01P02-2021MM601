using Microsoft.EntityFrameworkCore;

namespace L01P02_2021MM601.Models
{
    public class notasDbContext: DbContext
    {
        public notasDbContext(DbContextOptions options) : base (options) 
        { 

        }

        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Departamentos> Departamentos {get; set; }
        public DbSet<Facultades> Facultades { get; set; }
        public DbSet<Materias> Materias { get; set; }
    }
}
