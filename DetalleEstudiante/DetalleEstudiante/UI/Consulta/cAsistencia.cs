using DetalleEstudiante.BLL;
using DetalleEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetalleEstudiante.UI.Consulta
{
    public partial class cAsistencia : Form
    {
        public cAsistencia()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asistencia>();


            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //Todo
                        listado = DetalleBLL.GetList(p => true);
                        break;
                    case 1:
                        int ID = Convert.ToInt32(CriteriotextBox.Text);
                        listado = DetalleBLL.GetList(p => p.AsistenciasId == ID);
                        break;
                    case 2:
                        int IDAsignatura = Convert.ToInt32(CriteriotextBox.Text);
                        listado = DetalleBLL.GetList(p => p.AsignaturasId == IDAsignatura);
                        break;
                    case 3:
                        int Cantidad = Convert.ToInt32(CriteriotextBox.Text);
                        listado = DetalleBLL.GetList(p => p.Cantidad == Cantidad);
                        break;
                    default:
                        MessageBox.Show("No existe esa opción en el filtro.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                //Fecha
                listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date && p.Fecha <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = DetalleBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultadataGridView.DataSource = listado;

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
    

