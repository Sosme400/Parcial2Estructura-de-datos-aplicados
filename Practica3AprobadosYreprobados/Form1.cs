using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AprobadosReprobadosApp
{
    public partial class Form1 : Form
    {
        // Listas para almacenar alumnos
        private List<Alumno> listaAlumnos = new List<Alumno>();
        private List<Alumno> listaAprobados = new List<Alumno>();
        private List<Alumno> listaReprobados = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para agregar alumnos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && double.TryParse(txtCalificacion.Text, out double calificacion))
            {
                Alumno nuevoAlumno = new Alumno(txtNombre.Text, calificacion);
                listaAlumnos.Add(nuevoAlumno);
                MessageBox.Show($"{nuevoAlumno.Nombre} agregado con éxito.");
                txtNombre.Clear();
                txtCalificacion.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre y una calificación válida.");
            }
        }

        // Método para mostrar resultados (Aprobados/Reprobados con colores)
        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            listaAprobados.Clear();
            listaReprobados.Clear();
            lstAprobados.Items.Clear();
            lstReprobados.Items.Clear();

            // Clasificar alumnos y aplicar colores
            foreach (var alumno in listaAlumnos)
            {
                ListViewItem item = new ListViewItem(alumno.ToString());

                if (alumno.Calificacion >= 7)
                {
                    listaAprobados.Add(alumno);
                    item.ForeColor = System.Drawing.Color.Blue;  // Aprobados en azul
                    lstAprobados.Items.Add(item);
                }
                else
                {
                    listaReprobados.Add(alumno);
                    item.ForeColor = System.Drawing.Color.Red;  // Reprobados en rojo
                    lstReprobados.Items.Add(item);
                }
            }
        }
    }
}