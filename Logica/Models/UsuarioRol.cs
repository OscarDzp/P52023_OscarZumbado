using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //primero digitamos las propiedades de la clase 

        public int UsuarioRolID { get; set; }
        //esta forma de escribir una propieda autoimplementada es mas sencilla
        // pero se pierde control en las funciones get y set
        public string Rol { get; set; }
        //luego de escirbir las props  se digitan las funciones

        public DataTable Listar()
        {
            DataTable R = new DataTable();
         
            Conexion MiCnn = new Conexion();
            R = MiCnn.EjecutarSelect("SPUsuariosRolListar");

            return R;
        }
    }
}
