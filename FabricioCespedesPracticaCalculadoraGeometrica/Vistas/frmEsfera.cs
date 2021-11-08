using FabricioCespedesPracticaCalculadoraGeometrica.Clases;
using FabricioCespedesPracticaCalculadoraGeometrica.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricioCespedesPracticaCalculadoraGeometrica.Vistas
{
    public partial class frmEsfera : Form
    {
        public frmEsfera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Esfera esfera = new Esfera((double)numericUpDown1.Value);

                textBox1.Text = esfera.area(esfera.obtenerDato1()).ToString();

                textBox2.Text = esfera.volumen(esfera.obtenerDato1()).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(esfera);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, ingrese solo números");
            }
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
