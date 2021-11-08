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
    public partial class frmPiramide : Form
    {
        public frmPiramide()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double baseP = Convert.ToDouble(numericUpDown1.Text);

                double altura = Convert.ToDouble(numericUpDown2.Text);

                double altura2 = Convert.ToDouble(numericUpDown3.Text);

                Piramide pira = new Piramide(baseP, altura, altura2);

                textBox1.Text = pira.area(altura, baseP, altura2).ToString();

                textBox2.Text = pira.volumen(altura, baseP).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(pira);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numeros");
            }
        }
    }
}
