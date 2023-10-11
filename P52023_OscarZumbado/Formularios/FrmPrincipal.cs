using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_OscarZumbado.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // en este caso quiero que la ventana se muestre solo unavez
            //en la aplicacion (que no se abran varias veces) para esto
            //hay que revisar si la ventana esta o no visible

            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeUsuarios.Visible)
            {
                //hago una reinstanca del objecto para asegurar que iniciamos en limpio
                Globales.ObjectosGlobales.MiFormularioDeGestionDeUsuarios = new FrmUsuariosGestion();

                Globales.ObjectosGlobales.MiFormularioDeGestionDeUsuarios.Show();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
