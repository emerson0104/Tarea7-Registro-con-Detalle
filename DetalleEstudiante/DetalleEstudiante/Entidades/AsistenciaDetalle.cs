using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetalleEstudiante.Entidades
{
   public class AsistenciaDetalle
    {
            [Key]
            public int AsistenciasId { get; set; }
            public int DetalleAsistenciasId { get; set; }
            public int EstudiantesId { get; set; }
     
        public string Nombres { get; set; }
        public int Asistencia { get; set; }
        public AsistenciaDetalle()
        {
            DetalleAsistenciasId = 0;
            AsistenciasId = 0;
            EstudiantesId = 0;
            Nombres = string.Empty;
            Asistencia = 0;
        
    }
       public  AsistenciaDetalle (int DetalleAsistenciasId, int AsistenciaID, int EstudiantesId, string Nombres, int Asistencia)
        {
          this.DetalleAsistenciasId = DetalleAsistenciasId;
            this.AsistenciasId = AsistenciaID;
            this.EstudiantesId = EstudiantesId;
            this.Nombres = Nombres;
            this.Asistencia = Asistencia;
        }

    }
}
