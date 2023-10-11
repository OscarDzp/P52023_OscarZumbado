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
    }
}
