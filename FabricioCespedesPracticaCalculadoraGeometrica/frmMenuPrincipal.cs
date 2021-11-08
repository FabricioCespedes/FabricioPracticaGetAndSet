using FabricioCespedesPracticaCalculadoraGeometrica.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricioCespedesPracticaCalculadoraGeometrica
{
    public partial class frmMenuPrincipal : Form
    {
        frmEsfera frm ;

        frmHistorial frmHistorial;

        frmPiramide frmP;

        frmTetraedro frmT;

        frmOctaedro frmO;

        frmCubo frmC;

        frmCilindro frmCili;

        frmOrtoedro frmOrto;

        frmPrisma frmPri;

        frmCono frmCon;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            frm = null;

            frmHistorial = null;

            frmP = null;

            frmO = null;

            frmT = null;

            frmC = null;

            frmCili = null;

            frmOrto = null;

            frmPri = null;

            frmCon = null;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new frmEsfera();

                frm.MdiParent = this;

                frm.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frm.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            
            if (frmHistorial == null)
            {
                frmHistorial = new frmHistorial();

                frmHistorial.MdiParent = this;

                frmHistorial.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmHistorial.Show();
            }
            else
            {
                frmHistorial.Activate();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (frmP == null)
            {
                frmP = new frmPiramide();

                frmP.MdiParent = this;

                frmP.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmP.Show();
            }
            else
            {
                frmHistorial.Activate();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (frmT == null)
            {
                frmT = new frmTetraedro();

                frmT.MdiParent = this;

                frmT.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmT.Show();
            }
            else
            {
                frmT.Activate();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (frmO == null)
            {
                frmO = new frmOctaedro();

                frmO.MdiParent = this;

                frmO.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmO.Show();
            }
            else
            {
                frmO.Activate();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (frmC == null)
            {
                frmC = new frmCubo();

                frmC.MdiParent = this;

                frmC.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmC.Show();
            }
            else
            {
                frmC.Activate();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (frmCili == null)
            {
                frmCili = new frmCilindro();

                frmCili.MdiParent = this;

                frmCili.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmCili.Show();
            }
            else
            {
                frmCili.Activate();
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (frmOrto == null)
            {
                frmOrto = new frmOrtoedro();

                frmOrto.MdiParent = this;

                frmOrto.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmOrto.Show();
            }
            else
            {
                frmOrto.Activate();
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            if (frmPri == null)
            {
                frmPri = new frmPrisma();

                frmPri.MdiParent = this;

                frmPri.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmPri.Show();
            }
            else
            {
                frmPri.Activate();
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (frmCon == null)
            {
                frmCon = new frmCono();

                frmCon.MdiParent = this;

                frmCon.FormClosed += new FormClosedEventHandler(cerrarFormulario);

                frmCon.Show();
            }
            else
            {
                frmCon.Activate();
            }
        }
    }
}
