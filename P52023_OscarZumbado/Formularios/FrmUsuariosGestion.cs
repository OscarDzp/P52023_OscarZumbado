using System;
using System.Data;
using System.Windows.Forms;

namespace P52023_OscarZumbado.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        //objecto local de tipo usuario 
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;

            CargarComboRolesDeUsuario();

            CargarListaUsuarios();

            ActivarBotonAgregar();
        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores los "dibujos" en el combnos
                CboxUsuarioTipoRol.ValueMember = "id";
                CboxUsuarioTipoRol.DisplayMember = "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;
                CboxUsuarioTipoRol.SelectedIndex = -1;
            }
        }




        //todas  las funcionalidades especificas y que se puedan reutilizar deben 
        // ser encapsuladas
        private void CargarListaUsuarios()
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();

            lista = miusuario.ListarActivos();
            DgvListaUsuarios.DataSource = lista;
        }

        private bool ValidarDatosRequeridos(bool OmitirContrasenia = false)
        {
            //validar que se hayan digitado valores en los campos obligatorios
            bool R = false;
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&

                CboxUsuarioTipoRol.SelectedIndex > -1
                )
            {
                if (OmitirContrasenia)
                {
                    //si se omite la contrase;a entonces se pasa a true 
                    R = true;
                }
                else
                {
                    //si no se omite la contrasela debemos validar tambien ese campo


                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                        {

                            MessageBox.Show("Debe digitar la contraseña", "Error de validacion", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar la cedula", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar el nombre", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {

                    MessageBox.Show("Debe digitar el correo", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }



                if (CboxUsuarioTipoRol.SelectedIndex == -1)
                {

                    MessageBox.Show("Debe de seleccionar un rol de usuario", "Error de validacion", MessageBoxButtons.OK);
                    return false;
                }

            }
            return R;
        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Lo primero que debemos hacer es validar los datos minimos requeridos,
            //Esto hace para evitar que queden registros sin datos a nivel db
            //Pero tambien porque se un campo de base de datos no se acpeta valores null
            // y se llama al INSET, dara error.

            //luego de esto y tomando en consideracion el diagrama de cassos de uso expandido
            //de usuario , hay que hacer validar que NO exista un usuario con la cedulay/o
            //correo que se digitaron (no se puedan repetir estos datos en distintas)
            //filas en la tabla usuario.

            // si ambas validaciones son  negativas entonces se procede a agregar() el usuario.

            //------------------------------------------------//

            //usaremos un objecto local de tipo Usuario que sera al que daremos forma para luego
            //usar las funciones como agregar, actualizar, elimar, etc.

            if (ValidarDatosRequeridos())
            {
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();



                // con el combo rol hay que extraer el valuemember selecccionado
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);

                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                bool CedulaOk = MiUsuarioLocal.ConsultaPorCedula(MiUsuarioLocal.Cedula);

                bool CorreoOk = MiUsuarioLocal.ConsultaPorCorreo(MiUsuarioLocal.Correo);

                if (CedulaOk == false && CorreoOk == false)
                {
                    //se solicita confirmacion por parte del usuario 
                    string Pregunta = string.Format("¿Esta seguro de agregar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "????", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiUsuarioLocal.Agregar();

                        //procedemos a agregar el usuario
                        if (ok)
                        {
                            MessageBox.Show("Usuario ingresado correctamente!!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }


                    }
                }
            }
        }
        private void LimpiarForm()
        {
            TxtUsuarioCodigo.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioContrasennia.Clear();
            TxtUsuarioDireccion.Clear();

            CboxUsuarioTipoRol.SelectedIndex = -1;

            CbUsuarioActivo.Checked = false;
        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //validamos que se haya selececionado una linea de DGV, u que sea solo una
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarForm();
                //ColUsuarioID
                //Como necesito consultar por el id del usuario se debe extraer el valor de la columna
                //correspodiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaUsuarios.SelectedRows[0];
                int IDUsuario = Convert.ToInt32(MiDgvFila.Cells["ColUsuarioID"].Value);
                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuario);

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //una vez que se ha asegurado que eixte el usuario y que tiene datos se "Dibujan" eso
                    //Datos en los controles correspodientes del formulario

                    TxtUsuarioCodigo.Text = MiUsuarioLocal.UsuarioID.ToString();
                    TxtUsuarioCedula.Text = MiUsuarioLocal.Cedula;
                    TxtUsuarioNombre.Text = MiUsuarioLocal.Nombre;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.Correo;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.Direccion;


                    //en este caso no quiere que se muestre la contrase;a ya que esta encriptada y no se
                    //requiere actuzalizar y se deja en blanco el camp texto

                    CboxUsuarioTipoRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.UsuarioRolID;
                    CbUsuarioActivo.Checked = MiUsuarioLocal.Activo;

                    ActivarBotonesModificarYEliminar();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //esto limpia la seleccion de fila automatica que es el comporamiento estandar del control
            DgvListaUsuarios.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //al igual que con el agregar , se deben validar los datos requeridos pero,
            //el cmapo de la contrase;a debe ser opcional en este caso

            if (ValidarDatosRequeridos(true))
            {
                //transferimos al objecto local los posibles cambios que se hayan hecho en los datos delusuario
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                //depenmde de si digito o no una transe;a habran dos distitntos UPDATE en los SPs
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();

                //en el diagrama expandido de casos de uso para el tema usuario se indica

                //que para modificar o eliminar primero se debe consultar por el id
                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar el usuario?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiUsuarioLocal.Actualizar())
                        {
                            MessageBox.Show("Usuario modificado correctamenete !", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaUsuarios();
                            ActivarBotonAgregar();

                        }



                    }
                    //preceedemos a modificar el registro del usuario

                }
            }
        }
    }
}
