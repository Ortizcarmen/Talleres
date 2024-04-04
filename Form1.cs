using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talleres
{
    public partial class Form1 : Form
    {
        
        List<Allumnos> alumno1 = new List<Allumnos>();
        List<Taller> taller1 = new List<Taller>();
        List<Reporte> reporte1 = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CargarAlumnos();
            CargarTaller();
            comboBoxAlumnos.DisplayMember = "Nombre";
            comboBoxAlumnos.ValueMember = "Direccion";
            comboBoxAlumnos.DataSource = alumno1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
            CargarTaller();
            MostrarTalleres();
        }
        public void CargarAlumnos()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Alumnos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //Leer los datos de un empleado
                Allumnos alumno = new Allumnos();
                alumno.dpi = Convert.ToInt32(reader.ReadLine());
                alumno.nombre = reader.ReadLine();
                alumno.direccion = reader.ReadLine();

                //Guardar el empleado a la lista de empleados
                alumno1.Add(alumno);
            }
            reader.Close();

        }
        public void MostrarAlumnos()
        {
            //Mostrar la lista de empleados en el Gridview
            dataGridViewEstudiantes.DataSource = null;
            dataGridViewEstudiantes.DataSource = alumno1;
            dataGridViewEstudiantes.Refresh();
        }

        public void CargarTaller()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Talleres.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //Leer los datos de un empleado
                Taller talleres = new Taller();
                talleres.codigo = Convert.ToInt16(reader.ReadLine());
                talleres.dpiestudiante1 = Convert.ToInt16(reader.ReadLine());
                talleres.nombretaller = reader.ReadLine();
                talleres.codigo = Convert.ToInt16(reader.ReadLine());

                //Guardar el empleado a la lista de empleados
                taller1.Add(talleres);
            }
            reader.Close();
        }
        public void MostrarTalleres()
        {
            //Mostrar la lista de empleados en el Gridview
            dataGridViewTalleres.DataSource = null;
            dataGridViewTalleres.DataSource = taller1;
            dataGridViewTalleres.Refresh();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            foreach ( Allumnos alumno in alumno1)
            {
                foreach (Taller talleres in taller1)
                {
                    if (alumno.dpi == talleres.dpiestudiante1)
                    {
                        Reporte reporte = new Reporte();
                        reporte.dpiestudiante    = alumno.dpi;
                        reporte.codigotaller = talleres.codigo;
                        reporte.fecha = 

                        reporte1.Add(reporte);
                    }
                }
            }
            dataGridViewInscripciones.DataSource = null;
            dataGridViewInscripciones.DataSource = reporte1;
            dataGridViewInscripciones.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dpiestudiante = Convert.ToInt16(comboBoxAlumnos.SelectedValue);
            //Buscar por medio de Find
            Allumnos alumnoEncontrado = alumno1.Find(c => c.NoEmpleado == noEmpleado);
            Taller tallerEncontrada = taller1.Find(c => c.NoEmpleado == noEmpleado);

            

            label4.Text = empleadoEncontrado.Nombre;
            label5.Text = sueldo.ToString();
        }
    }
}
