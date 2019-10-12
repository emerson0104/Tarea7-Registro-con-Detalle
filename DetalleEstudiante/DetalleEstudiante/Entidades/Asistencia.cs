using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DetalleEstudiante.Entidades
{
   public class Asistencia
    { [Key]
        public int AsistenciasId { get; set; }
        public DateTime Fecha { get; set; }

        public int AsignaturasId{ get; set; }
        public int Cantidad { get; set; }
        public virtual List<AsistenciaDetalle> Detalles{ get; set; }
        public Asistencia()
        {
            AsistenciasId = 0;
            Cantidad = 0;
            Fecha = DateTime.Now;
            AsignaturasId = 0;
            Detalles =new  List<AsistenciaDetalle>();
        }
    }

}
