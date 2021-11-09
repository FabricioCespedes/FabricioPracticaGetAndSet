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
    public partial class frmCilindro : Form
    {
        public frmCilindro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double radio = Convert.ToDouble(numericUpDown1.Text);

                double altura = Convert.ToDouble(numericUpDown2.Text);

                Cilindro cilindro = new Cilindro(radio, altura);

                textBox1.Text = cilindro.area().ToString();

                textBox2.Text = cilindro.volumen().ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(cilindro);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numeros");
            }
        }
    }
}
