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
    public partial class frmTetraedro : Form
    {
        public frmTetraedro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Tetraedro tetraedro = new Tetraedro((double)numericUpDown1.Value);

                textBox1.Text = tetraedro.area(tetraedro.obtenerDato1()).ToString();

                textBox2.Text = tetraedro.volumen(12).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(tetraedro);
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, ingrese solo números");
            }
        }
    }
}
