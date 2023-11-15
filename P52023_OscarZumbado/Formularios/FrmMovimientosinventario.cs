using Logica.Models;
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
    public partial class FrmMovimientosinventario : Form
    {
        private Logica.Models.Movimiento MiMovimiento { get; set; }

        public FrmMovimientosinventario()
        {
            InitializeComponent();
            MiMovimiento = new Logica.Models.Movimiento();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMovimientosinventario_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaMovimientoTipo();
        }

      

        private void CargarListaMovimientoTipo()
        {
            Logica.Models.MovimientoTipo MiMovimiento = new Logica.Models.MovimientoTipo();

            DataTable dtMovimiento = new DataTable();

            dtMovimiento = MiMovimiento.Listar();

            if (dtMovimiento != null && dtMovimiento.Rows.Count > 0)
            {
                CboxTipoMovimiento.ValueMember = "id";
                CboxTipoMovimiento.DisplayMember = "Descripcion";

                CboxTipoMovimiento.DataSource = dtMovimiento;
                CboxTipoMovimiento.SelectedIndex = -1;
            }
        }
    }
}
