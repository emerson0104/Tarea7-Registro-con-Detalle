using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetalleEstudiante.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudiantesId { get; set; }
        public string Nombres { get; set; }
      

        public Estudiantes()
        {
            this.EstudiantesId = 0;
            this.Nombres = string.Empty;
           



        }
    }
}
