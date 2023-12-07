using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }

        public string CodigoBarras { get; set; }

        public string NombreProducto { get; set; }

        public decimal Costo { get; set; }

        public decimal Utilidad { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TasaImpuesto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal CantidadStock { get; set; }

        public bool  Activo { get; set; } 

        public ProductoCategoria MiCategoria { get; set; }
        public Producto()
        { 
            MiCategoria = new ProductoCategoria();
        }

        //comportamientos ,operaciones , funciones, metodos
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@NombreProducto", this.NombreProducto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Costo", this.Costo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Utilidad", this.Utilidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@SubTotal", this.SubTotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TasaImpuesto", this.TasaImpuesto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CantidadStock", this.CantidadStock));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoCategoriaID", this.MiCategoria.ProductoCategoriaID));
            int resultado = MiCnn.EjecutarDML("SPProductoAgregar");
            if (resultado > 0) R = true; 

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;


            return R;
        }

        public bool Eliminar()
        {
            bool R = false;


            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoId));
            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.EjecutarSelect("SPProductoConsultarPorID");
            if(DatosProducto != null && DatosProducto.Rows.Count > 0)
            {
                R = true;
            }
            return R;
        }

        public bool ConsultaPorCodigoBarras(String CodigoBarras)
        {
            bool R = false;
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@CodigoBarras", this.CodigoBarras));
            DataTable DatosProducto = new DataTable();
            DatosProducto = MyCnn.EjecutarSelect("SPProductoConsultarPorCodigoBarras");
            if (DatosProducto != null && DatosProducto.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSelect("SPProductoListar");

            return R;
        }


        public DataTable ListarActivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSelect("SPProductoListar");

            return R;
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", false));

            R = MiCnn.EjecutarSelect("SPProductoListar");

            return R;
        }

        public DataTable ListarEnMovimientoDetalleProducto(bool VerActivos = true, string Filtro = "")
        {
            DataTable R = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", VerActivos));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", Filtro));

            R = MyCnn.EjecutarSelect("SPProductosListar");

            return R;
        }
    }
}
