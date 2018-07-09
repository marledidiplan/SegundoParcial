using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial2.Entidades;
using Parcial2.UI.Registro;


namespace Parcial2
{
    public partial class mPrincipal : Form
    {
        public mPrincipal()
        {
            InitializeComponent();
        }

        private void rArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro Articulos
            RegistroA ra = new RegistroA();
            ra.MdiParent = this;
            ra.Show();
        }

        private void rEntradaAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro Entrada Articulo
            RegistroE re = new RegistroE();
            re.MdiParent = this;
            re.Show();


        }

        private void rTalleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro Talleres
            RegistroT rt = new RegistroT();
            rt.MdiParent = this;
            rt.Show();
        }

        private void rVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro Vehiculo
            RegistroV rv = new RegistroV();
            rv.MdiParent = this;
            rv.Show();
        }

        private void registroMantenimietoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroM rm = new RegistroM();
            rm.MdiParent = this;
            rm.Show();
        }
    }
}
