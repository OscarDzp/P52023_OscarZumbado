using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {

        public Usuario() 
        {
            MiUsuarioRol = new UsuarioRol();
        }

        public int UsuarioID { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }

        public string Contrasennia { get; set; }

        public string Telefono { get; set; }

        public string Tipo { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public UsuarioRol MiUsuarioRol { get; set; }

        //comportamientos ,operaciones , funciones, metodos


        public bool Agregar() 
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            //Ahora agregamos todos los parametros que solicuita el sp de agregar

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@UsuarioRolID", this.MiUsuarioRol.UsuarioRolID));

            int resultado = MiCnn.EjecutarDML("SPUsuariosAgregar");
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


            return R;
        }

        public bool ConsultaPorCedula(string pCedula)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", pCedula));
                DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSelect("SPUsuarioConsultarPorCedula");
            if (dt != null && dt.Rows.Count > 0 ) R = true;
            return R;
        }

        public bool ConsultaPorCorreo(string pCorreo)
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pCorreo));
            DataTable dt = new DataTable();
            dt = MiCnn.EjecutarSelect("SPUsuarioConsultarPorCorreo");
            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable ListarActivos() 
        {
        DataTable R = new DataTable();  

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();
            //como el Sp para listar requiere un parametro , hay que agregarlo a la lista
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));
            R = MiCnn.EjecutarSelect("SPUsuariosListar");
            return R;   
        }

        public DataTable ListarInactivos()
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}
