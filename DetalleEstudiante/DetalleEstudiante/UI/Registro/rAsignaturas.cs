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

namespace DetalleEstudiante.UI
{
    public partial class rAsignaturas : Form
    {RepositorioBase<Asignaturas> repositorio;
        public rAsignaturas()
        {
            
            InitializeComponent();
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            AsignaturatextBox.Text = string.Empty;

        }
        private bool validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(AsignaturatextBox.Text))
            {
                MyerrorProvider.SetError(AsignaturatextBox, "La asignatura no puede estar vacia.");
                paso = false;
            }

            return paso;
        }
        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturasId = Convert.ToInt32(IDnumericUpDown.Value);
            asignatura.Nombre = AsignaturatextBox.Text;

            return asignatura;
        }
        private bool Existe()
        {
            repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (asignatura != null);
        }

        private void LlenaCampos(Asignaturas asi)
        {
            IDnumericUpDown.Value = asi.AsignaturasId;
            AsignaturatextBox.Text = asi.Nombre;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas;
            bool paso;

            if (!validar())
                return;

            asignaturas = LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(asignaturas);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modifiar porque no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asignaturas);

            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas;
            int Id = Convert.ToInt32(IDnumericUpDown.Value);

            asignaturas = repositorio.Buscar(Id);

            if (asignaturas != null)
            {
                Limpiar();
                LlenaCampos(asignaturas);
            }
            else
            {
                MessageBox.Show("No encontrada.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int Id = Convert.ToInt32(IDnumericUpDown.Value);
            repositorio = new RepositorioBase<Asignaturas>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar datos que  no existe en la base de datos.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                paso = repositorio.Eliminar(Id);

                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Elimando ", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    }
    

