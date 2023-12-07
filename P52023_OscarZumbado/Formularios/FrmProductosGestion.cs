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
    public partial class FrmProductosGestion : Form
    {
        private Logica.Models.Producto MiProductoLocal { get; set; }
        public FrmProductosGestion()
        {
            InitializeComponent();
            MiProductoLocal = new Logica.Models.Producto();
        }

        private void FrmProductosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaProductos();
            CargarListaProductoCategoria();
            CargarListaProductos(CbVerActivos.Checked);

        }


        private void CargarListaProductos()
        {
            Logica.Models.Producto MiProductoLocal = new Logica.Models.Producto();

            DataTable lista = new DataTable();

            lista = MiProductoLocal.Listar();

            DgvListaProductos.DataSource = lista;

        }

        private void CargarListaProductoCategoria()
        {
            Logica.Models.ProductoCategoria MiCategoria = new Logica.Models.ProductoCategoria();

            DataTable lista = new DataTable();

            lista = MiCategoria.Listar();

            if (lista != null && lista.Rows.Count > 0)
            {
                CboxProductoCategoria.ValueMember = "ID";
                CboxProductoCategoria.DisplayMember = "Descripcion";

                CboxProductoCategoria.DataSource = lista;
                CboxProductoCategoria.SelectedIndex = -1;
            }

        }

        private void CargarListaProductos(bool VerActivos) 
        {
            Logica.Models.Producto MiProductoLocal = new Logica.Models.Producto();
            
            DataTable lista = new DataTable();

            if (VerActivos)
            {
                lista = MiProductoLocal.ListarActivos();
                DgvListaProductos.DataSource = lista;
            }
            else
            {
                lista = MiProductoLocal.ListarInactivos();
                DgvListaProductos.DataSource = lista;
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            TxtProductoCodigo.Clear();
            TxtProductoCodigoBarras.Clear();
            TxtProductoNombreProducto.Clear();
            TxtProductoCosto.Clear();
            TxtProductoUtilidad.Clear();
            TxtProductoSubtotal.Clear();
            TxtProductoTasaImpuesto.Clear();
            TxtProductoPrecioUnitario.Clear();
            TxtProductoCantidadStock.Clear();
            CboxProductoCategoria.SelectedIndex = -1;

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoNombreProducto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoSubtotal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()) &&
                CboxProductoCategoria.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                if(string.IsNullOrEmpty(TxtProductoCodigoBarras.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Codigo de barras");
                        return false;
                }
                if (string.IsNullOrEmpty(TxtProductoNombreProducto.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Nombre al Producto");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoCosto.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Costo al producto");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoUtilidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una utilidad");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoSubtotal.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Sub total");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoTasaImpuesto.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una IVA");
                    return false;

                }
                if (string.IsNullOrEmpty(TxtProductoPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Precio Unitario");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoCantidadStock.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar la cantidad de stock");
                    return false;
                }
                if (CboxProductoCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una categoria al producto");
                    return false;
                }
            }
            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiProductoLocal = new Logica.Models.Producto();

                MiProductoLocal.CodigoBarras = TxtProductoCodigoBarras.Text.Trim();
                MiProductoLocal.NombreProducto = TxtProductoNombreProducto.Text.Trim();
                MiProductoLocal.Costo = Convert.ToDecimal(TxtProductoCosto.Text.Trim());
                MiProductoLocal.Utilidad = Convert.ToDecimal(TxtProductoUtilidad.Text.Trim());
                MiProductoLocal.SubTotal = Convert.ToDecimal(TxtProductoSubtotal.Text.Trim());
                MiProductoLocal.TasaImpuesto = Convert.ToDecimal(TxtProductoTasaImpuesto.Text.Trim());
                MiProductoLocal.PrecioUnitario = Convert.ToDecimal(TxtProductoPrecioUnitario.Text.Trim());
                MiProductoLocal.CantidadStock = Convert.ToDecimal(TxtProductoCantidadStock.Text.Trim());
                MiProductoLocal.MiCategoria.ProductoCategoriaID = Convert.ToInt32(CboxProductoCategoria.SelectedValue);

                bool IDValido = MiProductoLocal.ConsultarPorID();
                bool CodigoBarras = MiProductoLocal.ConsultaPorCodigoBarras(MiProductoLocal.CodigoBarras);
                
                if(IDValido == false && CodigoBarras == false)
                {

                    String Pregunta = string.Format("Estas seguro de agregar este producto {0}?", MiProductoLocal.NombreProducto);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmacion", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiProductoLocal.Agregar();

                        if (ok) 
                        {
                            MessageBox.Show("Producto agregado correctamente", "Agregado", MessageBoxButtons.OK);
                        }
                        else 
                        {
                            MessageBox.Show("Producto no se agregado correctamente", "Cancelado", MessageBoxButtons.OK);
                        }

                    }
                    LimpiarForm();
                    CargarListaProductos();
                    CargarListaProductoCategoria();
                  
                }
            }
        }
    }
}
