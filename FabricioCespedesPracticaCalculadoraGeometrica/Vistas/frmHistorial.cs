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
    public partial class frmHistorial : Form
    {
        Logica logica = new Logica();

        public frmHistorial()
        {
            InitializeComponent();

            
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {

            foreach (Figura figura in logica.devolverLista())
            {
                ListViewItem item = new ListViewItem();               

                item = listView1.Items.Add(figura.ToString());


            }


        }
    }
}
