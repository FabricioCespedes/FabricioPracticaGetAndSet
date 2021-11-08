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
    public partial class frmOrtoedro : Form
    {
        public frmOrtoedro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(numericUpDown1.Text);

                double b = Convert.ToDouble(numericUpDown2.Text);

                double c = Convert.ToDouble(numericUpDown3.Text);

                Ortoedro ortoedro = new Ortoedro(a, b, c);

                textBox1.Text = ortoedro.area(a, b, c).ToString();

                textBox2.Text = ortoedro.volumen(a, b,c).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(ortoedro);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numeros");
            }
        }
    }
}
