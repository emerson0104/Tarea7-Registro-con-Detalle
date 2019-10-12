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

namespace DetalleEstudiante.UI.Registro
{
    public partial class rEstudiantes : Form
    {
        RepositorioBase<Estudiantes> repositorio;
        public rEstudiantes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            EstudiantetextBox.Text = string.Empty;

        }
        private bool validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyerrorProvider.SetError(EstudiantetextBox, "El Estudiante no puede estar vacio.");
                paso = false;
            }

            return paso;
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.EstudiantesId = Convert.ToInt32(IDnumericUpDown.Value);
            estudiantes.Nombres = EstudiantetextBox.Text;

            return estudiantes;
        }
        private bool Existe()
        {
            repositorio = new RepositorioBase<Estudiantes>();
           Estudiantes Estudiante = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (Estudiante != null);
        }

        private void LlenaCampos(Estudiantes estudiantes)
        {
            IDnumericUpDown.Value = estudiantes.EstudiantesId;
           EstudiantetextBox.Text = estudiantes.Nombres;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiantes;
            bool paso;

            if (!validar())
                return;

            estudiantes= LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(estudiantes);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modifiar porque no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(estudiantes);

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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int Id = Convert.ToInt32(IDnumericUpDown.Value);
            repositorio = new RepositorioBase<Estudiantes>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar datos que  no existen en la base de datos.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Estudiantes>();
           Estudiantes estudiantes;
            int Id = Convert.ToInt32(IDnumericUpDown.Value);

            estudiantes = repositorio.Buscar(Id);

            if (estudiantes != null)
            {
                Limpiar();
                LlenaCampos(estudiantes);
            }
            else
            {
                MessageBox.Show("No encontrada.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

