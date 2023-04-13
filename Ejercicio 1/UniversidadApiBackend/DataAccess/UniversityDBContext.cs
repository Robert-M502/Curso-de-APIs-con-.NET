using Microsoft.EntityFrameworkCore;
using UniversidadApiBackend.Models.DataModels;

namespace UniversidadApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) { 
        
        }

        // TODO: Agregar DBSets (Tablas de nuestra base de datos)
        public DbSet<Curso>? Cursos { get; set; }
    }
}
