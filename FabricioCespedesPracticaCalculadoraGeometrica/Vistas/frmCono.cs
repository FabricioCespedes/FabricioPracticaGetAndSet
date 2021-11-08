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
    public partial class frmCono : Form
    {
        public frmCono()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(numericUpDown1.Text);

                double gene = Convert.ToDouble(numericUpDown2.Text);

                double radio = Convert.ToDouble(numericUpDown3.Text);

                Cono cono = new Cono(altura,gene,radio);

                textBox1.Text = cono.area(gene,radio,altura).ToString();

                textBox2.Text = cono.volumen(gene, radio, altura).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(cono);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numeros");
            }
        }
    }
}
