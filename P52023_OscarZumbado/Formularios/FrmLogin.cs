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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Globales.ObjectosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar=true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
              {
                // si hay valores en los cuadros de teto se procede a validarlos
                string usuario = TxtUsuario.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                int idUsuario = Globales.ObjectosGlobales.MiUsuarioGlobal.ValidarIngreso(usuario, contrasennia);

                if (idUsuario > 0)
                {
                    //la validacion es correcta m.ahora creamos el usuario globales y ademas permitimos el ingreso
                    //al sistema
                    Globales.ObjectosGlobales.MiUsuarioGlobal = Globales.ObjectosGlobales.MiUsuarioGlobal.ConsultarPorID(idUsuario);
                    Globales.ObjectosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso denegado!", "Error de validacion...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsuario.Focus();
                    TxtUsuario.SelectAll();
                }
            }      
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Control & e.KeyCode == Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.ObjectosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
