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
    public partial class frmPrisma : Form
    {
        public frmPrisma()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = Convert.ToDouble(numericUpDown1.Text);

                double apotema = Convert.ToDouble(numericUpDown2.Text);

                Prisma prisma = new Prisma(altura,apotema);

                textBox2.Text = prisma.volumen(altura, apotema).ToString();

                Logica logica = new Logica();

                logica.ingresarHistorial(prisma);
            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese solo numeros");
            }
        }
    }
}
