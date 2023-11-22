using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        MovimientoTipo MiTipo { get; set; }

        Usuario MiUsuario { get; set; }

        // en el caso del detalle, si analizamos el diargama de clases
        //vemos que al lleghar a ala clase de detalle termina en 'muchos'
        // 1..* eso significa que el atribute tiene multiplicidad,
        // o sea   que se puede repetir n veces

        List<MoviminetoDetalle> Detalles { get; set; }

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


    }
}
