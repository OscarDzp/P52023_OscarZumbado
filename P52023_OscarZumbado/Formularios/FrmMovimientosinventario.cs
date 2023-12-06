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

                DgvListaDetalle.DataSource = DtListaDetalleProductos;
                Totalizar();

            }




        }
        private void Totalizar()
        {

            decimal TotalCosto = 0;
            decimal TotalSubtotal = 0;
            decimal TotalImpuestos = 0;
            decimal Total = 0;

            if (DtListaDetalleProductos != null && DtListaDetalleProductos.Rows.Count > 0)
            {
                foreach (DataRow item in DtListaDetalleProductos.Rows)
                {
                    decimal Cantidad = Convert.ToDecimal(item["CantidadMovimiento"]);
                    TotalCosto += Convert.ToDecimal(item["Costo"]);
                    TotalSubtotal += Convert.ToDecimal(item["SubTotal"]) * Cantidad;
                    TotalImpuestos += Convert.ToDecimal(item["TotalIVa"]) * Cantidad;
                    Total += TotalSubtotal + TotalImpuestos;

                }
            }

            LblTotalCosto.Text = string.Format("{0:C2}", TotalCosto);
            LblTotalSubTotal.Text = string.Format("{0:C2}", TotalSubtotal);
            LblTotalImpuestos.Text = string.Format("{0:C2}", TotalImpuestos);
            LblTotalGranTotal.Text = string.Format("{0:C2}", Total);

        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            //debemos validar que esten los datos minimos necesarios
            if (ValidarMovimiento())
            {
                DialogResult respuesta = MessageBox.Show("Dese continuar?", "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {

                    // una vez que tenemos los requisitos completos, se procede a "dar forma"
                    // al objecto de moviento local.

                    //primero los atributos simples y compuestos del encabezado.
                    //luego a asginacion de los detalles
                    MiMovimientoLocal.Fecha = DtpFecha.Value.Date;
                    MiMovimientoLocal.Anotaciones = TxtAnotaciones.Text.Trim();

                    MiMovimientoLocal.MiTipo.MovimientoTipoID = Convert.ToInt32(CboxTipoMovimiento.SelectedValue);

                    // a nivel de funcionalidad solo necesitamos el FK o sea ID del tipo,
                    //la parte del texto no es necesario

                    MiMovimientoLocal.MiUsuario = Globales.ObjectosGlobales.MiUsuarioGlobal;


                    //llenar la lista de detalles en el objecto local
                    //del datatable de detalles.
                    TransladarDetalles();

                    //ahora que tenemos todo listo, procedemos a agregar el movimiento
                    if (MiMovimientoLocal.Agregar())
                    {
                        MessageBox.Show("El movimiento se ha agregado correctamente",
                            ":)", MessageBoxButtons.OK);

                        //GENERAR REPORTE 
                        //1. Crear un objecto de tipo documento
                        CrystalDecisions.CrystalReports.Engine.ReportDocument MiReporte = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

                        //2. crear objecto del reporte que se quiere usar
                        MiReporte = new Reportes.RptMovimiento();

                        //3. llamar a la funcion que extrae los datos de la base de datos
                        MiReporte = MiMovimientoLocal.Imprimir(MiReporte);

                        //4. dibujar el reporte en pantalla
                        FrmVisualizadorReportes MiVisualizador = new FrmVisualizadorReportes();

                        MiVisualizador.CrvVisualizador.ReportSource = MiReporte;

                        MiVisualizador.Show();

                        //TODO: Limpiar formulario
                    }
                }
            }
        }

        private void TransladarDetalles()
        {
            foreach (DataRow item in DtListaDetalleProductos.Rows)
            {
                //en cada iteracion creamos un nuevo objecto de movimiento detalle que luego
                //sera agregado a la lista de detalles del objecto local

                Logica.Models.MoviminetoDetalle NuevoDetalle = new Logica.Models.MoviminetoDetalle();
                NuevoDetalle.CantidadMovimiento = Convert.ToDecimal(item["CantidadMovimiento"]);
                NuevoDetalle.Costo = Convert.ToDecimal(item["Costo"]);
                NuevoDetalle.PrecioUnitario = Convert.ToDecimal(item["PrecioUnitario"]);
                NuevoDetalle.SubTotal = Convert.ToDecimal(item["SubTotal"]);
                NuevoDetalle.TotalIVA = Convert.ToDecimal(item["TotalIVA"]);

                //atributo compuesto simple
                NuevoDetalle.MiProducto.ProductoId = Convert.ToInt32(item["ProductoID"]);

                //Agregar el detalle nuevo a la lista del objecto local
                MiMovimientoLocal.Detalles.Add(NuevoDetalle);


            }
        }

        private bool ValidarMovimiento()
        {
            bool R = false;

            if (DtpFecha.Value.Date <= DateTime.Now.Date &&
                CboxTipoMovimiento.SelectedIndex > -1 &&
                DtListaDetalleProductos.Rows.Count > 0)
            {
                R = true;
            }
            else
            {
                if (DtpFecha.Value.Date > DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha del movimiento no puede" +
                        "Ser superior a la fecha actual", "Error de Validacion",
                        MessageBoxButtons.OK);
                    return false;
                }
                if (CboxTipoMovimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe de seleccionar el tipo de movimiento",
                      "Error de Validacion", MessageBoxButtons.OK);
                    return false;
                }
                if (DtListaDetalleProductos == null || DtListaDetalleProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No se puede procesar un movimiento sin detalles", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;
        }
    }
}
