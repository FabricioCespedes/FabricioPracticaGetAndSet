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
    public partial class frmOctaedro : Form
    {
        public frmOctaedro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Octaedro octaedro = new Octaedro((double)numericUpDown1.Value);

                textBox1.Text = octaedro.area().ToString();

                textBox2.Text = octaedro.volumen(3).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(octaedro);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, ingrese solo números");
            }
        }
    }
}
