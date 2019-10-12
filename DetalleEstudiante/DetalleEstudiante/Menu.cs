using DetalleEstudiante.UI;
using DetalleEstudiante.UI.Consulta;
using DetalleEstudiante.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetalleEstudiante
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencias r = new rAsistencias();
            r.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas r = new rAsignaturas();
            r.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes r = new rEstudiantes();
            r.Show();
        }

        private void AsistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAsistencia c = new cAsistencia();
            c.Show();
        }
    }
}