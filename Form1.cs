using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        List<Propietarios> propietario = new List<Propietarios>();
        List<Propiedades> propiedad = new List<Propiedades>();
        List<Datos> dato = new List<Datos>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            leerPropietarios();
            MostraraPropietarios();
           
            leerPropiedades();
            MostrarPropiedades();
        }
        private void leerPropietarios()
        {
            FileStream stream = new FileStream("Propietarios.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propietarios propietarios = new Propietarios();
                propietarios.Dpi = reader.ReadLine(); ;
                propietarios.Nombre = reader.ReadLine();
                propietarios.Apellido = reader.ReadLine();
                propietario.Add(propietarios);

            }
            reader.Close();
        }

        private void MostraraPropietarios()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietario;
            dataGridView1.Refresh();
        }

        private void leerPropiedades()
        {
            FileStream stream = new FileStream("Propiedades.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Propiedades propiedades = new Propiedades();
                propiedades.NumerodeCasa = reader.ReadLine(); ;
                propiedades.Dpi = reader.ReadLine();
                propiedades.CuotadeMantenimiento = Convert.ToInt32(reader.ReadLine());
                propiedad.Add(propiedades);

            }
            reader.Close();
        }

        private void MostrarPropiedades()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = propiedad;
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < propietario.Count; i++)
            {
                for (int j = 0; j < propiedad.Count; j++)
                {
                    if (propietario[i].Dpi == propiedad[j].Dpi)
                    {
                        Datos datos = new Datos();
                        datos.Nombre = propietario[i].Nombre;
                        datos.Apellido = propietario[i].Apellido;
                        datos.NumerodeCasa = propiedad[j].NumerodeCasa;
                        datos.CuotadeMantenimiento = propiedad[j].CuotadeMantenimiento;
        
                        dato.Add(datos);

                    }
                }
            }
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = dato;
            dataGridView3.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Propiedades mayor = propiedad.OrderByDescending(a => a.CuotadeMantenimiento).First();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            


        }
        
    }
}
