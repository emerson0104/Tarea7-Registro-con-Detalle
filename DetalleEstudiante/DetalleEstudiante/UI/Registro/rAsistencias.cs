using DetalleEstudiante.BLL;
using DetalleEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DetalleEstudiante.UI.Registro
{
    public partial class rAsistencias : Form
   {public List<AsistenciaDetalle> Detalle { get; set; }
        public rAsistencias()
        {
            InitializeComponent();
            this.Detalle = new List<AsistenciaDetalle>();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LlenaComboboxEStudiante();
            LlenaCombobxAsignatura();
        }
        private void LlenaComboboxEStudiante()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            List<Estudiantes> Lista = new List<Estudiantes>();
            Lista = repositorio.GetList(r =>true );
            EstudiantecomboBox.DataSource = Lista;
            EstudiantecomboBox.ValueMember = "EstudiantesId";
            EstudiantecomboBox.DisplayMember = "Nombres";

        }
        private void LlenaCombobxAsignatura()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            List<Asignaturas> Lista = new List<Asignaturas>();
            Lista = repositorio.GetList(r => true);
            AsignaturacomboBox.DataSource = Lista;
            AsignaturacomboBox.ValueMember = "AsignaturasId";
            AsignaturacomboBox.DisplayMember = "Nombre";
        }

        private void Limpiar()
        {
            AsistenciaIDnumericUpDown.Value = 0;
            AsignaturacomboBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            Detalle = new List<AsistenciaDetalle>();
            DetalledataGridView.Rows.Clear();
            CargarGrid();

        }
        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (AsignaturacomboBox.Text == "")
            {
                MyerrorProvider.SetError(AsignaturacomboBox, " Elige una asignatura.");
                paso = false; 
            }

            if (EstudiantecomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Elige un Estudiante .");
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(Agregarbutton, "Agrega  un estudiante.");
                Agregarbutton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                MyerrorProvider.SetError(CantidadtextBox, "El campo Cantidad no puede estar vacío.");
                paso = false;
            }
            else
            {
                try
                {
                    int cantidad = Convert.ToInt32(CantidadtextBox.Text);
                }
                catch (Exception)
                {
                    MyerrorProvider.SetError(CantidadtextBox, "La cantidad debe ser entera y numerica.");
                    paso = false;
                }
            }

            return paso;
        }
        private bool Existe()
        {
            Asistencia asistencia = DetalleBLL.Buscar((int)AsistenciaIDnumericUpDown.Value);
            return (asistencia != null);
        }
        private Asistencia LlenaClase()
        {
            Asistencia asistencia = new Asistencia();
            asistencia.AsistenciasId = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            asistencia.Fecha = FechadateTimePicker.Value;
          //  asistencia.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            asistencia.AsignaturasId = Convert.ToInt32(AsignaturacomboBox.SelectedValue);
           
            int numlineas = DetalledataGridView.RowCount - 1;
            int contador = 0;
            while (numlineas >= 0)
            {
                contador++;
                numlineas = numlineas - 2;
            }
            asistencia.Cantidad = contador;
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);
            asistencia.Detalles = this.Detalle;
            return asistencia;
            
        }
        private void LlenaCampo(Asistencia asistencia)
        {
            AsistenciaIDnumericUpDown.Value = asistencia.AsistenciasId;
            FechadateTimePicker.Value = asistencia.Fecha;
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);
            AsignaturacomboBox.SelectedValue = Convert.ToString(asistencia.AsignaturasId);

            this.Detalle = asistencia.Detalles;
            CargarGridCiclo();
        }
        private void CargarGrid()
        {
            bool paso;

            if (VCheckBox() == 1)
                paso = true;
            else
                paso = false;

            DetalledataGridView.DataSource = null;
            DetalledataGridView.Rows.Add((int)EstudiantecomboBox.SelectedValue, GetNombreEstudiante(), paso);
        }
        private void CargarGridCiclo()
        {
            bool paso;
            DetalledataGridView.DataSource = null;
            DetalledataGridView.Rows.Clear();
            foreach (var item in this.Detalle)
            {
                if (item.Asistencia == 1)
                    paso = true;
                else
                    paso = false;
                DetalledataGridView.Rows.Add(item.EstudiantesId, item.Nombres, paso);
            }

        }
      

        private bool ValidarAgregar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (EstudiantecomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Debe elegir un estudiante.");
                paso = false;
            }
            if (EstudiantecomboBox.Text == "")
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Debe elegir al menos un estudiante.");
                paso = false;
            }
            if (paso)
            {
                foreach (var item in this.Detalle)
                {
                    if (item.EstudiantesId == (int)EstudiantecomboBox.SelectedValue)
                    {
                        MyerrorProvider.SetError(EstudiantecomboBox, "Ya el Estudiante existe en el detalle.");
                        return paso = false;
                    }

                }
            }


            return paso;
        }
     /*   private bool valid(AsistenciaDetalle asistencia)
        {
            bool paso ;
            paso = Detalle.Any(x => x.EstudiantesId.Equals(asistencia.EstudiantesId));
            
            return paso;
        }*/
        private int VCheckBox()
        {
            int paso;

            if (PresentecheckBox.Checked == true)
                return paso = 1;
            else
                return paso = 0;
        }


        private string GetNombreEstudiante()
        {
            string nombre = "";

            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            nombre = repositorio.Buscar((int)EstudiantecomboBox.SelectedValue).Nombres;

            return nombre;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            Asistencia asistencia;

            asistencia = DetalleBLL.Buscar(id);

            if (asistencia != null)
            {
                Limpiar();
                LlenaCampo(asistencia);
            }
            else
            {
                MessageBox.Show("Asistencia no encontrada.");
            }
        }

        private void Gurdarbutton_Click(object sender, EventArgs e)
        {
           if (!Validar())
               return;

            bool paso;
            Asistencia asistencia;
            asistencia = LlenaClase();

            if (AsistenciaIDnumericUpDown.Value == 0)
                paso = DetalleBLL.Guardar(asistencia);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = DetalleBLL.Modificar(asistencia);
            }

            if (paso)
            {
                
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int Id = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            bool paso;

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                paso = DetalleBLL.Eliminar(Id);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar la asistencia", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void AgregarEstudiantebutton_Click(object sender, EventArgs e)
        {
            rEstudiantes estudiante = new rEstudiantes();
            estudiante.ShowDialog();
            LlenaComboboxEStudiante();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Detalle = new List<AsistenciaDetalle>();
            
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<AsistenciaDetalle>)DetalledataGridView.DataSource;
            if (!ValidarAgregar())
                return;

            Detalle.Add( new AsistenciaDetalle( DetalleAsistenciasId: 0,AsistenciaID:Convert.ToInt32(AsistenciaIDnumericUpDown.Value),
                 EstudiantesId: (int)EstudiantecomboBox.SelectedValue,Nombres: GetNombreEstudiante(), Asistencia: VCheckBox() ) );
            Asistencia asistencia = new Asistencia();
            int numlineas = DetalledataGridView.RowCount - 1;
            int contador = 0;
            while (numlineas >= 0)
            {
                contador++;
                numlineas = numlineas - 2;
            }

            asistencia.Cantidad = contador;
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);
            CargarGrid();
            MyerrorProvider.Clear();
            PresentecheckBox.Checked = false;
            EstudiantecomboBox.Text = string.Empty;     
         
        }
        private bool ValidarRemover()
        {
            bool paso = true;
            if (DetalledataGridView.SelectedRows == null)
            {
                paso = false;
            }

            return paso;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;

            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null )
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null )
            {
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
               

                CargarGridCiclo();
            }
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

