using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;


namespace Logica.Models
{
    public class Movimiento
    {
        public Movimiento()
        {
            MiTipo = new MovimientoTipo();
            MiUsuario = new Usuario();

            Detalles = new List<MoviminetoDetalle>();
        }
        public int MovimientoId { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroMovimiento { get; set; }

        public string Anotaciones { get; set; }

        //comportamientos ,operaciones , funciones, metodos


        public bool Agregar()
        {
            bool R = false;
            //primero hacemos un insert en el encabezado y recolectamos el ID que se genera
            //esto es indispensable ya que se necesita como FK en la tabla de deatalle
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@Fecha", this.Fecha));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@Anotaciones", this.Anotaciones));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@TipoMovimiento", this.MiTipo.MovimientoTipoID));
            MyCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioID", this.MiUsuario.UsuarioID));

            Object RetornoSPAgregar = MyCnn.EjecutarSELECTEscalar("SPMovimientoAgregarEncabezado");

            int IDMovimientoRecienCreado;

            if (RetornoSPAgregar != null)
            {
                //ESPECIALIZADO
                IDMovimientoRecienCreado = Convert.ToInt32(RetornoSPAgregar.ToString());

                //asiganamos al objecto el ID generado por el sp
                this.MovimientoId = IDMovimientoRecienCreado;

                foreach (MoviminetoDetalle item in this.Detalles)
                { 
                    //por cada iteracion en la lista de detalles hacemos un insert en la
                    //tabla de detalles

                    Conexion MyCnnDetalle = new Conexion();

                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDMovimiento", IDMovimientoRecienCreado));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoId));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.CantidadMovimiento));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Costo", item.Costo));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@SubTotal", item.SubTotal));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@TotalIVA", item.TotalIVA));
                    MyCnnDetalle.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", item.PrecioUnitario));

                    MyCnnDetalle.EjecutarDML("SPMovimientosAgregarDetalle");
                }
                R = true;
            }

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


            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }

        public MovimientoTipo MiTipo { get; set; }

        public Usuario MiUsuario { get; set; }

        // en el caso del detalle, si analizamos el diargama de clases
        //vemos que al lleghar a ala clase de detalle termina en 'muchos'
        // 1..* eso significa que el atribute tiene multiplicidad,
        // o sea   que se puede repetir n veces

        public List<MoviminetoDetalle> Detalles { get; set; }

        public DataTable AsignarEsquemaDelDetalle()
        {
            DataTable R = new DataTable();
            Conexion MyCnn = new Conexion();

            //queremos cargar el esquema del dataatble , no los datos
            R = MyCnn.EjecutarSelect("SPMovimientoCargarDetalle", true);

            //para evitar el identify (1, 1) que esta originalmente en la tabla
            //Me genere numeros unicos que impidan repetir registros
            R.PrimaryKey = null;

            return R;
        }

        public ReportDocument Imprimir(ReportDocument document)
        {
            ReportDocument R = document;
            // hacemos un objecto de tipo crystal (la clase que creamos)
            Tools.Crystal ObjCrystal = new Tools.Crystal(R);

            DataTable datos = new DataTable();

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.MovimientoId));

            datos = MyCnn.EjecutarSelect("SPMovimientoImprimir");

            if(datos != null && datos.Rows.Count > 0)
            {
                ObjCrystal.Datos = datos;

                R = ObjCrystal.GenerarReporte();
            }
            return R;
        }


    }
}
