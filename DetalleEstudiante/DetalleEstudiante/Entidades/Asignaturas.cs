using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetalleEstudiante.Entidades
{
   public class Asignaturas
    { [Key]
        public int AsignaturasId { get; set; }
        public string Nombre { get; set; }

        public Asignaturas()
        {
            AsignaturasId = 0;
            Nombre = string.Empty;
        }

        
        
    }
}

