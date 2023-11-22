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
        public Logica.Models.Movimiento MiMovimientoLocal { get; set; }

        public DataTable DtListaDetalleProductos { get; set; }

        public FrmMovimientosinventario()
        {
            InitializeComponent();
            MiMovimientoLocal = new Logica.Models.Movimiento();
            DtListaDetalleProductos = new DataTable();
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
            LimpiarFormulario();
        }

      private void LimpiarFormulario()
        {
            DtpFecha.Value = DateTime.Now.Date;
            CboxTipoMovimiento.SelectedIndex = -1;
            TxtAnotaciones.Clear();

            //en este caso particular el datatable que alimenta el dgv
            //debe tener estructura , pero no datos inicialmente
            //cosiderando eso, llenaremos el datatable con el esquemas
            //de la consulta del sp SPMovimientocagardetalle
            //esto permite tener el dt sin filas, pero con estructuras
            //que permite agregar filas posteriormente

            DtListaDetalleProductos = MiMovimientoLocal.AsignarEsquemaDelDetalle();

            DgvListaDetalle.DataSource = DtListaDetalleProductos;

            //limpianos los totales
            LblTotalCosto.Text = "0";
            LblTotalGranTotal.Text = "0";
            LblTotalImpuestos.Text = "0";
            LblTotalSubTotal.Text = "0";

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            // el formulario que muestra la lista de items , se debe mostrar en este
            //caso particular en formato de dialogo, ya que queremos coratar
            // temporalemnete el funcionamiento del form actuial, hacer algo en
            // el otro form y esperar un respuesta


            Form FormDetalleProducto = new Formularios.FrmMoviminetosinventarioDetalleProducto();

            DialogResult resp = FormDetalleProducto.ShowDialog();

            if (resp == DialogResult.OK) 
            {
            // TODO agregar la nueva linea de detalle



            }
        }
    }
}
