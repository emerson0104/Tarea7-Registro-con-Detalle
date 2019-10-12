using DetalleEstudiante.Entidades;
using System.Data.Entity;

namespace DetalleEstudiante.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }


        public Contexto() : base("ConStr")
        {


        }
    }
}


