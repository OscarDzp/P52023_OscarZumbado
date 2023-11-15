using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_OscarZumbado.Globales
{
    public static class ObjectosGlobales
    {
        //definir un objecto global para el form principal
        public static Form MiFormularioPrincipal = new Formularios.FrmPrincipal();

        public static Formularios.FrmUsuariosGestion MiFormularioDeGestionDeUsuarios = new Formularios.FrmUsuariosGestion();

        //este sera el usuario valido en el login, tendra un scope global
        //ent toda la aplicacio
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        //formulario de movimientos de productos
        public static Formularios.FrmMovimientosinventario MiFormularioMovimientos = new Formularios.FrmMovimientosinventario();

    }
}
