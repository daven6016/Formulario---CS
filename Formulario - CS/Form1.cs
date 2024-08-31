using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Formulario___CS
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEdad.Clear();
            tbNum.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            rbOtro.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombres = tbNombre.Text;
            string Apellidos = tbApellidos.Text;
            string Edad = tbEdad.Text;
            string Telefono = tbNum.Text;

            string Genero = " ";
            if (rbHombre.Checked)
                    { Genero = "Hombre"; }
            else if (rbMujer.Checked)
                    { Genero = "Mujer"; }
            else if (rbOtro.Checked)
                    { Genero = "Otro"; }

            String datos = $"Formulario - CS ~~~~ \n\nNombres: {Nombres} \r\n Apellidos: {Apellidos}\r\n Edad: {Edad}\r\n Telefono: {Telefono}\r\n Genero: {Genero}";

            string rutaArchivo = "C:/Users/Admin/Documents/Guardado.txt";
            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter Writer = new StreamWriter(rutaArchivo, true))
            {
                {
                    if (archivoExiste)
                    {
                        Writer.WriteLine();
                    }
                    Writer.WriteLine(datos);
                }
                MessageBox.Show( "Datos capturados correctamente:\n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
