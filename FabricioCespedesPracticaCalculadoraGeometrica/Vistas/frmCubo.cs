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
    public partial class frmCubo : Form
    {
        public frmCubo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cubo cubo = new Cubo((double)numericUpDown1.Value);

                textBox1.Text = cubo.area(cubo.obtenerDato1()).ToString();

                textBox2.Text = cubo.volumen(cubo.obtenerDato1()).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(cubo);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, ingrese solo números");
            }
        }
    }
}
