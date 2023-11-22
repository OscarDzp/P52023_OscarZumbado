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
    public partial class FrmMoviminetosinventarioDetalleProducto : Form
    {
        DataTable ListaProductos { get; set; }

        DataTable ListaProductosConFiltro { get; set; }

        Logica.Models.Producto MiProducto { get; set; }

        public FrmMoviminetosinventarioDetalleProducto()
        {
            InitializeComponent();

            ListaProductos = new DataTable();
            ListaProductosConFiltro = new DataTable();

            MiProducto = new Logica.Models.Producto();
        }

        private void FrmMoviminetosinventarioDetalleProducto_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

        private void LlenarLista()
        {
            ListaProductos = MiProducto.ListarEnMovimientoDetalleProducto();

            DgvLista.DataSource = ListaProductos;
            DgvLista.ClearSelection();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                // el dgv(parte grafica) tiene de fondo un datatable que lo alimenta
                //como se ocultatron 3 columnas en el dgv, no se podra obtenerr el dato que
                // contienen. en este caso se usara el datatable para obteneer dichos datos
                // (costo,s ub total, %iva)
                DataGridViewRow MiDgvFila = DgvLista.SelectedRows[0];
                int IDProducto = Convert.ToInt32(MiDgvFila.Cells["CProductoID"].Value);

                //una vez que tenemos el ID del producto, recorremos el datatable
                //buscando dicho ID

                foreach (DataRow item in ListaProductos.Rows)
                {
                    if (IDProducto == Convert.ToInt32(item["ProductoID"]))
                    {
                        //cuando la compraracion es correcta , tenemos todo lo necesario para
                        //crear la nueva fila en el formulario de movimiento de inventario
                        DataRow NuevaFila = Globales.ObjectosGlobales.MiFormularioMovimientos.DtListaDetalleProductos.NewRow();

                        NuevaFila["ProductoID"] = IDProducto;
                        NuevaFila["NombreProducto"] = item["NombreProducto"].ToString();
                        NuevaFila["CantidadMovimiento"] = Convert.ToDecimal(NtxtCantidad.Value);
                        NuevaFila["Costo"] = Convert.ToDecimal(item["Costo"]);
                        NuevaFila["SubTotal"] = Convert.ToDecimal(item["SubTotal"]);

                        decimal TasaIva = Convert.ToDecimal(item["TasaImpuesto"]);
                        decimal SubTotal = Convert.ToDecimal(item["SubTotal"]);
                        decimal TotalIva = SubTotal * TasaIva / 100;

                        NuevaFila["TotalIVA"] = TotalIva;

                        NuevaFila["PrecioUnitario"] = Convert.ToDecimal(item["PrecioUnitario"]);
                        NuevaFila["CodigoBarras"] = item["CodigoBarras"].ToString();

                        //una vez quie tenemos la nuevafila cargada con data se procede a adjuntarla
                        //al datatable del detalle del movimiento y cerramos este form con respuesta ok

                        Globales.ObjectosGlobales.MiFormularioMovimientos.DtListaDetalleProductos.Rows.Add(NuevaFila);
                        DialogResult = DialogResult.OK;


                        break;
                    }
                }
            }
        }

        private bool Validar()
        {
            bool R = false;
            if (DgvLista.SelectedRows.Count == 1 && NtxtCantidad.Value > 0)
            {
                R = true;
            }
            else
            {
                //si no se seleciono algo lista
                if (DgvLista.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un producto de la lista", "Error de validar", MessageBoxButtons.OK);
                    return false;
                }
                if (NtxtCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero o negativa", "Error de validar", MessageBoxButtons.OK);
                    return false;
                }
            }
            return R;
        }

    }
}
