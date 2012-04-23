using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Events4ALL.Auxiliares;
using Events4ALL.EN;
using System.Configuration;
using System.Collections.Specialized;
using System.Globalization;
using System.Threading;
using System.Drawing.Imaging;

namespace Events4ALL
{
    public partial class Admins : UserControl
    {
        // generador de DNI's para hacer pruebas http://niednicifgenerador.appspot.com/
        
        #region Variables

        private Validaciones validar;
        private bool edicion;
        private AdminEN en_admin;
        private DataSet muestraAdmin;
        private DataTable tAdmin;
        private int idActual;
        private bool imagenCambiada;

        #endregion

        // Inicializa el formulario Admin con algunos valores por defecto e imagen, 
        // y establece los valores de las variables internas.
        public Admins()
        {
            string lang = ConfigurationManager.AppSettings.Get("Lenguaje");
            if (lang == "en")
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            
            InitializeComponent();

            MuestraAdmins();

            dateTimePicker1.Value = DateTime.Parse(IniciaFechaHoy());

            if (!edicion)
            {
                label_ID.Visible = false;
            }

            textBox_filtro_busqueda.Visible = false;
            comboBox_filtro_busqueda.Visible = false;

            // creo el objeto que se encargara de validar
            //validar = new Validaciones();
            //en_admin = new AdminEN();

            textBox_anterior_pass.Enabled = false;

            edicion = false;

            idActual = -1;
            //boton_eliminar.Enabled = false;

            imagenCambiada = false;

            Admin_Perfil_boton_Guardar.Text = "Insertar";
            Admin_Perfil_boton_Anadir.Text = "Limpiar";
            Admin_Perfil_boton_Anadir.Image = Events4ALL.Properties.Resources.clear_2;

        }

        #region Comprobaciones

        // Establece mediante un errorProvider en el formulario, si el apartado NIF es correcto.
        // La comprobación del NIF se realiza mediante la separacion de los numeros y las letras,
        // seguidamente se genera la letra a partir de los numeros, si coinciden, es correcto.
        private bool CompruebaNif()
        {
            validar = new Validaciones();

            //test1.Text = "" + validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text);
            //test2.Text = "" + validar.DevuelveLetra(Admin_Perfil_txtBox_NIF.Text);
            //test3.Text = "" + validar.ObtieneLetra(validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text));

            // esta vacio
            if (Admin_Perfil_txtBox_NIF.Text.Length == 0)
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "Debe de rellenar el NIF.");
                return false;
            }
            // esta mal
            else if (!validar.CompruebaNIF(Admin_Perfil_txtBox_NIF.Text))
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "NIF incorrecto.");
                return false;
            }
            // esta bien
            else
            {
                errorProviderNif.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Nombre es correcto.
        private bool CompruebaNombre()
        {
            validar = new Validaciones();
            // vacio
            if( Admin_Perfil_txtBox_Nombre.Text.Length == 0 )
            {
                errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Debe de rellenar el Nombre.");
                return false;
            }
            // la BD solo almacena 50 caracteres
            else if (Admin_Perfil_txtBox_Nombre.Text.Length >= 50)
            {
                errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Nombre demasiado largo. Máximo 50 carácteres.");
                return false;
            }
            if(!validar.CompruebaTexto(Admin_Perfil_txtBox_Nombre.Text))
            {
                errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Carácteres incorrectos.");
                return false;
            }
            // ok
            else
            {
                errorProviderNombre.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Apellidos es correcto.
        private bool CompruebaApellidos()
        {
            validar = new Validaciones();

            // vacio
            if (Admin_Perfil_txtBox_Apellidos.Text.Length == 0)
            {
                errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Debe de rellenar los Apellidos.");
                return false;
            }
            // la BD solo almacena 50 caracteres
            else if (Admin_Perfil_txtBox_Apellidos.Text.Length >= 50)
            {
                errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Apellidos demasiado largos. Máximo 50 caracteres.");
                return false;
            }
            if(!validar.CompruebaTexto(Admin_Perfil_txtBox_Apellidos.Text))
            {
                errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Carácteres incorrectos.");
                return false;
            }
            // ok
            else
            {
                errorProviderApellidos.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado designado al 
        // codigo postal es correcto.
        private bool CompruebaCP()
        {
            validar = new Validaciones();

            // campo vacio
            if(textBox_CP_Perfil.Text.Length == 0)
            {
                errorProviderCP.SetError(label_CP_Perfil, "Debe de introducir un Código Postal.");
                return false;
            }
            // campo erroneo
            else if( !validar.CompruebaCP(textBox_CP_Perfil.Text) )
            {
                errorProviderCP.SetError(label_CP_Perfil, "CP incorrecto.");
                return false;
            }
            else
            {
                errorProviderCP.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Localidad es correcto.
        private bool CompruebaLocalidad()
        {
            validar = new Validaciones();

            // vacio
            if( txtBox_Localidad.Text.Length == 0)
            {
                errorProviderLocalidad.SetError(Label_Localidad, "Debe introducir una Localidad.");
                return false;
            }
            // falla
            else if( txtBox_Localidad.Text.Length >= 50)
            {
                errorProviderLocalidad.SetError(Label_Localidad, "Localidad demasiado larga. Máximo 50 carácteres.");
                return false;
            }
            if (!validar.CompruebaTexto(txtBox_Localidad.Text))
            {
                errorProviderLocalidad.SetError(Label_Localidad, "Carácteres incorrectos.");
                return false;
            }
            // correcto
            else
            {
                errorProviderLocalidad.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Mail es correcto.
        private bool CompruebaMail()
        {
            validar = new Validaciones();

            // mail vacio
            if ((Admin_Perfil_txtBox_Mail.Text.Length == 0) || (Admin_Perfil_txtBox_Mail.Text == "usuario@event4all.es"))
            {
                Admin_Perfil_txtBox_Mail.Text = "usuario@event4all.es";
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Debe de introducir un E-Mail de contacto válido.");
                return false;
            }
            // mail muy largo
            else if (Admin_Perfil_txtBox_Mail.Text.Length >= 50)
            {
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Mail demasiado largo. Máximo 50 carácteres.");
                return false;
            }
            // mail incorrecto
            else if ( !validar.CompruebaMail(Admin_Perfil_txtBox_Mail.Text))
            {
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Mail incorrecto.");
                return false;
            }
            else
            {
                errorProviderMail.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Telefono es correcto.
        private bool CompruebaTelefono()
        {
            validar = new Validaciones();

            // vacio
            if ((Admin_Perfil_txtBox_Tel1.Text.Length == 0) || (Admin_Perfil_txtBox_Tel1.Text == "000 000000"))
            {
                Admin_Perfil_txtBox_Tel1.Text = "000 000000";
                errorProviderTEL.SetError(Admin_Perfil_Label_Tel1, "Debe introducir un Teléfono de contacto válido.");
                return false;
            }
            // no tiene 9 numeros o esta mal.
            else if ( !validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel1.Text))
            {
                errorProviderTEL.SetError(Admin_Perfil_Label_Tel1, "Teléfono incorrecto.");
                return false;
            }
            else 
            {
                errorProviderTEL.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Movil es correcto.
        private bool CompruebaMovil()
        {
            validar = new Validaciones();

            // vacio
            if ( (Admin_Perfil_txtBox_Tel2.Text.Length == 0) || (Admin_Perfil_txtBox_Tel2.Text == "000 000000") )
            {
                Admin_Perfil_txtBox_Tel2.Text = "000 000000";
                errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Debe introducir un Móvil de contacto válido.");
                return false;
            }
            // no tiene 9 numeros o esta mal.
            else if (!validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel2.Text))
            {
                errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Móvil incorrecto.");
                return false;
            }
            else
            {
                errorProviderMov.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Domicilio es correcto.
        private bool CompruebaDomicilio()
        { 
            validar = new Validaciones();
            // vacio
            if( Admin_Perfil_txtBox_Domicilio.Text.Length == 0 )
            {
                errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Debe introducir un domicilio.");
                return false;
            }
            // Demasiado largo
            else if (Admin_Perfil_txtBox_Domicilio.Text.Length > 42)
            {
                errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Dirección demasiado larga.");
                return false;
            }
            if (!validar.CompruebaTexto(Admin_Perfil_txtBox_Domicilio.Text))
            {
                errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Carácteres incorrectos.");
                return false;
            }
            // ok
            else
            {
                errorProviderDomicilo.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Sexo es correcto, asegurando
        // que exista un elemento seleccionado.
        private bool CompruebaSexo()
        {
            if (Admin_Perfil_rButom_H.Checked == false && Admin_Perfil_rButom_M.Checked == false)
            {
                errorProviderSexo.SetError(Admin_Perfil_Label_Sexo, "Seleccione un campo del Sexo.");
                return false;
            }
            else
            {
                errorProviderSexo.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Estado Civil es correcto,
        // asegurando que algun campo este marcado.
        private bool CompruebaEC()
        {
            if (Admin_Perfil_rButom_Soltero.Checked == false &&
                Admin_Perfil_rButom_Viudo.Checked == false &&
                Admin_Perfil_rButom_Divorciado.Checked == false &&
                Admin_Perfil_rButom_Casado.Checked == false)
            {
                errorProviderEC.SetError(Admin_Perfil_Label_EstCivil, "Seleccione un Estado Civil.");
                return false;
            }
            else
            {
                errorProviderEC.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Provincia es correcto, 
        // asegurando que se haya seleccionado una provincia.
        private bool CompruebaProvincia()
        {
            if (comboBox_Provincia.Text == "")
            {
                errorProviderProvincia.SetError(Label_Provincia_Perfil, "Debe seleccionar una provincia.");
                return false;
            }
            else
            {
                errorProviderProvincia.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Pais es correcto, asegurando
        // que haya sido seleccionado un pais.
        private bool CompruebaPais()
        {
            if (Admin_Perfil_comboBox_Pais.Text == "")
            {
                errorProviderPais.SetError(Admin_Perfil_Label_Pais, "Debe seleccionar su país de nacimiento.");
                return false;
            }
            else
            {
                errorProviderPais.Clear();
                return true;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Nick es correcto, comrpobando
        // que no exista otro usuario con el mismo Nick.
        private bool CompruebaNick()
        {
            validar = new Validaciones();

            if (textBox_NombreUsuario.Text.Length == 0)
            {
                errorProviderNick.SetError(label_NombreUsuario, "Introduzca un nombre de usuario.");
                return false;
            }
            else if (textBox_NombreUsuario.Text.Length <= 25 ) // tambien he de comprobar que no existe en la BD
            {
                errorProviderNick.Clear();
                return true;
            }
            if (!validar.CompruebaTexto(textBox_NombreUsuario.Text))
            {
                errorProviderNick.SetError(label_NombreUsuario, "Carácteres incorrectos");
                return false;
            }
            else
            {
                errorProviderNick.SetError(label_NombreUsuario, "Introduzca un nombre de usuario.");
                return false;
            }
        }

        // Establece mediante un errorProvider en el formulario, si el apartado Conntraseña es correcto, 
        // asegurando que sean iguales y que cumplan unos minimos de seguridad establecidos ( una minuscula, 
        // una mayuscula y un numero).
        private bool CompruebaPass()
        {
            validar = new Validaciones();

            string error = validar.CompruebaPass(textBox_pass1.Text);

            if (textBox_pass1.Text.Length == 0)
            {
                errorProviderPassInv.SetError(label_pass1, "Introduzca una Contraseña.");
                errorProviderPassDif.Clear();
                return false;
            }
            else if (error == "")
            {
                if (textBox_pass1.Text == textBox_pass2.Text)
                {
                    errorProviderPassDif.Clear();
                    errorProviderPassInv.Clear();
                    return true;
                }
                else
                {
                    errorProviderPassDif.SetError(label_pass2, "Las contraseñas no coinciden.");
                    errorProviderPassInv.Clear();
                    return false;
                }
            }
            else
            {
                errorProviderPassInv.SetError(label_pass1, error);
                errorProviderPassDif.Clear();
                return false;
            }
        }

        // Comprueba que todos los campos del formulario sean correctos.
        private bool ValidaCampos()
        {
            bool error = true;

            if (!CompruebaNick())
                error = false;

            if (!CompruebaNif())
                error = false;

            if (!CompruebaNombre())
                error = false ;

            if (!CompruebaApellidos())
                error = false;

            if (!CompruebaCP())
                error = false;

            if (!CompruebaLocalidad())
                error = false;

            if (!CompruebaMail())
                error = false;

            if (!CompruebaTelefono())
                error = false;
            
            if (!CompruebaMovil())
                error = false;
            
            if (!CompruebaDomicilio())
                error = false;
           
            if (!CompruebaSexo())
                error = false;
            
            if (!CompruebaEC())
                error = false;

            if (!CompruebaProvincia())
                error = false;
            
            if (!CompruebaPais())
                error = false;

            return error;
        }

        // rellena el formulario de Admin con un ejemplo predefinido para comprobar errores.
        private void RellenaDatos()
        {
            textBox_NombreUsuario.Text = "Pepe";
            //textBox_pass1.Text = "123456";
            //textBox_pass2.Text = "123456";

            Admin_Perfil_txtBox_Nombre.Text = "Pepe";
            Admin_Perfil_txtBox_Apellidos.Text = "El de los Huevos Repe";
            Admin_Perfil_txtBox_NIF.Text = "45836991S";
            Admin_Perfil_comboBox_Pais.Text = "España";
            comboBox_Provincia.Text = "Alicante";
            textBox_CP_Perfil.Text = "03610";
            txtBox_Localidad.Text = "Petrer";
            comboBoxDirec.Text = "C/";
            Admin_Perfil_txtBox_Domicilio.Text = "Random";

            Admin_Perfil_txtBox_Tel1.Text = "123456789";
            Admin_Perfil_txtBox_Tel2.Text = "987654321";
            Admin_Perfil_txtBox_Mail.Text = "random@hotmail.com";

            Admin_Perfil_rButom_H.Checked = true;
            Admin_Perfil_rButom_Divorciado.Checked = true;

        }

        #endregion

        #region Limpiadores

        // devuelve un string con la ficha del dia actual.
        private string IniciaFechaHoy()
        {
            string fechaHoy = DateTime.Now.Date.ToString();
            string aux = "";
            for (int i = 0; i < 10; i++)
                aux = aux + fechaHoy[i];

            return aux;
        }

        // Borra el valor del campo telefono y establece el valor por defecto.
        private void LimpiaTelefono(object sender, EventArgs e)
        {
            if(Admin_Perfil_txtBox_Tel1.Text == "000 000000")
                Admin_Perfil_txtBox_Tel1.Text = "";
        }

        // Borra el valor del campo movil y establece el valor por defecto.
        private void LimpiaMovil(object sender, EventArgs e)
        {
            if(Admin_Perfil_txtBox_Tel2.Text == "000 000000")
                Admin_Perfil_txtBox_Tel2.Text = "";
        }

        // Borra el valor del campo mail y establece el valor por defecto.
        private void LimpiaMail(object sender, EventArgs e)
        {
            if (Admin_Perfil_txtBox_Mail.Text == "usuario@event4all.es")
                Admin_Perfil_txtBox_Mail.Text = "";
        }

        // Limpia todos los errorProviders del formulario.
        public void LimpiaError(object sender, EventArgs e)
        {
            // limpia el error de sexo
            if (CompruebaSexo())
                errorProviderSexo.Clear();

            // limpia el error de EC
            if (CompruebaEC())
                errorProviderEC.Clear();

            // limpia el error de provincia
            if (comboBox_Provincia.Text != "")
                errorProviderProvincia.Clear();

            // limpia el error de pais
            if (Admin_Perfil_comboBox_Pais.Text != "")
                errorProviderPais.Clear();
        }

        // Limpia los valores introducidos en la busqueda.
        public void LimpiaBusqueda()
        {
            textBox_filtro_busqueda.Visible = false;
            comboBox_filtro_busqueda.Visible = false;

            comboBox_filtro.Text = "Mostrar Todos";

            MuestraAdmins();

            /*textBox_Nombre_Busqueda.Text = "";
            textBox_Apellidos_Busqueda.Text = "";
            comboBox_provincia_busqueda.Text = "";
            comboBox_Pais_BA.Text = "";
            textBox_Loc1_BA.Text = "";
            textBox_CP_busqueda.Text = "";
            textBox_DNI_Busqueda.Text = "";
            textBox_Nick_busqueda.Text = "";
            textBox_ID_busqueda.Text = "";
            textBox_mail_busqueda.Text = "";
            textBox_tele_busqueda.Text = "";
            textBox_movil_busqueda.Text = "";
            textBox_domicilio_busqueda.Text = "";

            radioButton_Hombre_Sexo.Checked = false;
            radioButton_Mujer_Sexo.Checked = false;

            radioButton_Cas_EC.Checked = false;
            radioButton_Divo_EC.Checked = false;
            radioButton_Sol_EC.Checked = false;
            radioButton_Viud_EC.Checked = false;

            numericUpDown_Fec1.Value = 16;
            numericUpDown_Fec2.Value = 16;

            radioButton_edad_no.Checked = true;*/
        }

        // Limpia los valores introducidos en el formulario principal y las variables del sistema,
        // dejando el formulario igual que la primera vez que hemos accedido.
        private void LimpiarDatos()
        {
            #region Datos Personales

            //Admin_Perfil_txtBox_NIF.Enabled = true;
            edicion = false;
            //en_admin.LimpiaEN();

            // borra nif
            Admin_Perfil_txtBox_NIF.Text = "";
            errorProviderNif.Clear();

            // borra nombre
            Admin_Perfil_txtBox_Nombre.Text = "";
            errorProviderNombre.Clear();

            // borra apellido
            Admin_Perfil_txtBox_Apellidos.Text = "";
            errorProviderApellidos.Clear();

            // borra telefono
            Admin_Perfil_txtBox_Tel1.Text = "000 000000";
            errorProviderTEL.Clear();

            // borra movil
            Admin_Perfil_txtBox_Tel2.Text = "000 000000";
            errorProviderMov.Clear();

            // borra mail
            Admin_Perfil_txtBox_Mail.Text = "usuario@event4all.es";
            errorProviderMail.Clear();

            // borra localidad
            txtBox_Localidad.Text = "";
            errorProviderLocalidad.Clear();

            // borra domicilio
            comboBoxDirec.Text = "";
            Admin_Perfil_txtBox_Domicilio.Text = "";
            errorProviderDomicilo.Clear();

            // borra CP
            textBox_CP_Perfil.Text = "";
            errorProviderCP.Clear();

            // borro EC
            Admin_Perfil_rButom_Soltero.Checked = false;
            Admin_Perfil_rButom_Viudo.Checked = false;
            Admin_Perfil_rButom_Divorciado.Checked = false;
            Admin_Perfil_rButom_Casado.Checked = false;
            errorProviderEC.Clear();

            // borro sexo
            Admin_Perfil_rButom_H.Checked = false;
            Admin_Perfil_rButom_M.Checked = false;
            errorProviderSexo.Clear();

            // borro provincia
            comboBox_Provincia.Text = "";
            errorProviderProvincia.Clear();

            // borro pais
            Admin_Perfil_comboBox_Pais.Text = "";
            errorProviderPais.Clear();

            //Admin_Perfil_Label_FecNacimiento.Text =S DateTime.Now.Date.Totring();
            //dateTimePicker1.Value = DateTime.Parse(IniciaFechaHoy());
            dateTimePicker1.Value = DateTime.Today;

            #endregion
            #region Datos de Usuario

            // limpia foto
            Admin_Perfil_Foto.Image = Events4ALL.Properties.Resources.Events4All;

            // borra y esconde ID
            label_ID.Text = "";
            label_ID.Visible = false;

            // borra Nick
            textBox_NombreUsuario.Text = "";
            errorProviderNick.Clear();

            // borra Pass 
            textBox_pass1.Text = "";
            textBox_pass2.Text = "";
            errorProviderPassDif.Clear();
            errorProviderPassInv.Clear();

            edicion = false;
            textBox_anterior_pass.Enabled = false;
            idActual = -1;
            //boton_eliminar.Enabled = false;
            errorProviderPassAnt.Clear();
            textBox_anterior_pass.Text = "";

            #endregion

            Admin_Perfil_boton_Guardar.Text = "Insertar";
            Admin_Perfil_boton_Anadir.Text = "Limpiar";
            Admin_Perfil_boton_Anadir.Image = Events4ALL.Properties.Resources.clear_2;
        }

        #endregion

        #region Seccion Perfil

        // Elimina el usuario cargado a partir de la busqueda.
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            BorrarAdmin();
        }
        
        // Llama a la funcion LimpiarDatos() para limpiar el formulario.
        private void Admin_Perfil_boton_Anadir_Click(object sender, EventArgs e)
        {
            if (edicion)
            {
                if (MessageBox.Show("¿Desea ir al formulario de inserción y perder los cambios no guardados?", "Los cambios no guardados se perderan", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    LimpiarDatos();
                }
            }
            else
                LimpiarDatos();
            
        }

        // Comprueba los datos introducidos en el formulario, los valida mediante llamadas a
        // metodos anteriores y los almacena o edita en la BD.
        private void Admin_Perfil_boton_Guardar_Click(object sender, EventArgs e)
        {
            //RellenaDatos();
            //45836991S
            en_admin = new AdminEN();

            // Comrpuebo que todos los campos estan rellenos
            if (ValidaCampos())
            {
                System.Diagnostics.Debug.Write("nuevo");
                // creo el EN y toda la pedazo de basura posterior

                // ambos metodos hacen la misma puta basura, simplemente relleno el EN de distintas maneras.... por que me sale del nabo
                //AltaAdminEN_Directo();
                //AltaAdminEN_PorPasos();
                
                // NUEVO 
                if (!edicion && CompruebaPass())
                {
                    if (AltaAdminEN_PorPasos())
                    {
                        //idActual = ObtieneID(textBox_NombreUsuario.Text);
                        // Una vez insertado mostramos el ID que se le ha asignado
                        //label_ID.Text = "ID de Usuario : " + idActual;
                        //label_ID.Visible = true;

                        // Establecemos edicion a true, ya que si se realiza un modificacion del admin, tendremos que realizar
                        // un update y no un insert
                        //edicion = true;

                        //textBox_pass1.Text = "";
                        //textBox_pass2.Text = "";

                        //textBox_anterior_pass.Enabled = true;
                        //boton_eliminar.Enabled = true;

                        //Admin_Perfil_boton_Guardar.Text = "Guardar";
                        //Admin_Perfil_boton_Anadir.Text = "Nuevo";

                        LimpiarDatos();
                    }
                }
                // ACTUALIZAR
                else if(edicion)
                {
                    System.Diagnostics.Debug.Write("Edicion");
                    int sexo = -1;

                    if (Admin_Perfil_rButom_H.Checked == true)
                        sexo = 0;
                    else if (Admin_Perfil_rButom_M.Checked == true)
                        sexo = 1;

                    string ec = "";

                    if (Admin_Perfil_rButom_Soltero.Checked == true)
                        ec = Admin_Perfil_rButom_Soltero.Text;
                    else if (Admin_Perfil_rButom_Casado.Checked == true)
                        ec = Admin_Perfil_rButom_Casado.Text;
                    else if (Admin_Perfil_rButom_Divorciado.Checked == true)
                        ec = Admin_Perfil_rButom_Divorciado.Text;
                    else if (Admin_Perfil_rButom_Viudo.Checked == true)
                        ec = Admin_Perfil_rButom_Viudo.Text;

                    int error = en_admin.CompruebaPass(textBox_anterior_pass.Text, textBox_pass1.Text, textBox_pass2.Text, idActual);

                    // pass vacio, pero se realiza edicion
                    if (error == 1 && ValidaCampos())
                    {
                        errorProviderPassAnt.Clear();
                        errorProviderPassDif.Clear();
                        error = en_admin.ActualizarAdmin(idActual, Admin_Perfil_txtBox_NIF.Text, Admin_Perfil_txtBox_Nombre.Text,
                                                Admin_Perfil_txtBox_Apellidos.Text, Admin_Perfil_comboBox_Pais.Text,
                                                comboBox_Provincia.Text, txtBox_Localidad.Text,
                                                comboBoxDirec.Text + " " + Admin_Perfil_txtBox_Domicilio.Text, textBox_CP_Perfil.Text,
                                                Admin_Perfil_txtBox_Tel1.Text, Admin_Perfil_txtBox_Tel2.Text,
                                                Admin_Perfil_txtBox_Mail.Text, ec, Admin_Perfil_Foto.Image, sexo, textBox_NombreUsuario.Text,
                                                textBox_pass1.Text, textBox_pass2.Text, dateTimePicker1.Value,imagenCambiada);

                        System.Diagnostics.Debug.Write("El error en actualizar 1." + error);

                        if (error == 4) MessageBox.Show("No se ha podido realizar la actualización.");
                        else if (error == 5) MessageBox.Show("No se ha realizado ninguna modificación.");
                        else MessageBox.Show("Se ha realizado la actualizacion.");
                        
                    }
                    // Todo ok, y cambio en el pass
                    else if (error == 0 && CompruebaPass() && ValidaCampos())
                    {
                        errorProviderPassAnt.Clear();
                        errorProviderPassDif.Clear();
                        error = en_admin.ActualizarAdmin(idActual, Admin_Perfil_txtBox_NIF.Text, Admin_Perfil_txtBox_Nombre.Text,
                                                Admin_Perfil_txtBox_Apellidos.Text, Admin_Perfil_comboBox_Pais.Text,
                                                comboBox_Provincia.Text, txtBox_Localidad.Text,
                                                comboBoxDirec.Text + " " + Admin_Perfil_txtBox_Domicilio.Text, textBox_CP_Perfil.Text,
                                                Admin_Perfil_txtBox_Tel1.Text, Admin_Perfil_txtBox_Tel2.Text,
                                                Admin_Perfil_txtBox_Mail.Text, ec, Admin_Perfil_Foto.Image, sexo, textBox_NombreUsuario.Text,
                                                textBox_pass1.Text, textBox_pass2.Text, dateTimePicker1.Value, imagenCambiada);

                        System.Diagnostics.Debug.Write("El error en actualizar 2." + error);

                        if (error == 4) MessageBox.Show("No se ha podido realizar la actualizacion.");
                        else if (error == 5) MessageBox.Show("No se ha realizado ninguna modificación.");
                        else MessageBox.Show("Se ha realizado la actualizacion.");
                    }
                    else if (error == 2)
                        errorProviderPassDif.SetError(label_pass1, "Error, contraseñas direfentes.");
                    else if (error == 3)
                        errorProviderPassAnt.SetError(label_anterior_pass, "La constraseña anterior no es correcta.");
                    else if (error == 4)
                        errorProviderPassAnt.SetError(label_anterior_pass, "Debe introducir la contraseña anterior para poder cambiarla.");
                    else
                        MessageBox.Show("Dafaq !?");
                }
            }
            else 
            {
                //MessageBox.Show("Fail.");
            }
        }

        // Abre el dialogo necesario para seleccionar la imagen que deseamos establecer al administrador.
        private void Admin_Perfil_boton_Foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFich = new OpenFileDialog();
            OFich.ShowHelp = true;

            OFich.Filter = "Archivos de imagen (*.bmp;*.jpg;*.gif)|*.bmp;*.jpg;*.gif|Todos los archivos|*.*";
            Admin_Perfil_Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (OFich.ShowDialog() == DialogResult.OK)
            {
                Admin_Perfil_Foto.Image = Image.FromFile(OFich.FileName);
                imagenCambiada = true;
            } 
        }

        #endregion

        #region Trabajo con EN

        // Muestra mediando un MessageBox los datos introducidos en el formulario.
        private void MuestraEN(AdminEN muestra)
        {
            MessageBox.Show("Nombre : "+muestra.Nombre+
                            " \nApellidos : "+muestra.Apellidos+
                            " \nDNI : "+muestra.DNI+
                            " \nPais : "+muestra.Pais+
                            " \nProvincia : "+muestra.Provincia+
                            " \nLocalidad : "+muestra.Localidad+
                            " \nDireccion : "+muestra.Domicilio+
                            " \nCP : "+muestra.CP+
                            " \nSexo : "+muestra.Sexo+
                            " \nTelefono : "+muestra.Telefono+
                            " \nMovil : "+muestra.Movil+
                            " \nMail : "+muestra.Mail+
                            " \nEC : "+muestra.EC+
                            " \nNick : "+muestra.Nick+
                            " \nPASS : "+muestra.Pass+
                            " \nFoto : "+muestra.Foto+
                            " \nFecha : "+muestra.Fecha);
        }

        // Establece la llamada a la funcion de almacenaje del Admin en el EN y pasa los datos
        // del formulario al constructor sobrecargado.
        // NO OPERATIVO
        private bool AltaAdminEN_Directo()
        {
            int sexo = -1;
            string ec = "";

            if (Admin_Perfil_rButom_H.Checked == true)
                sexo = 0;
            else if (Admin_Perfil_rButom_M.Checked == true)
                sexo = 1;

            // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
            if (Admin_Perfil_rButom_Soltero.Checked == true)
                ec = Admin_Perfil_rButom_Soltero.Text;
            else if (Admin_Perfil_rButom_Casado.Checked == true)
                ec = Admin_Perfil_rButom_Casado.Text;
            else if (Admin_Perfil_rButom_Divorciado.Checked == true)
                ec = Admin_Perfil_rButom_Divorciado.Text;
            else if (Admin_Perfil_rButom_Viudo.Checked == true)
                ec = Admin_Perfil_rButom_Viudo.Text;

            en_admin = new AdminEN(Admin_Perfil_txtBox_NIF.Text,
                                        Admin_Perfil_txtBox_Nombre.Text,
                                        Admin_Perfil_txtBox_Apellidos.Text,
                                        Admin_Perfil_comboBox_Pais.Text,
                                        comboBox_Provincia.Text,
                                        txtBox_Localidad.Text,
                                        comboBoxDirec.Text + " " + Admin_Perfil_txtBox_Domicilio.Text,
                                        textBox_CP_Perfil.Text,
                                        Admin_Perfil_txtBox_Tel1.Text,
                                        Admin_Perfil_txtBox_Tel2.Text,
                                        Admin_Perfil_txtBox_Mail.Text,
                                        ec, 
                                        Admin_Perfil_Foto.Image,
                                        sexo,
                                        textBox_NombreUsuario.Text,
                                        textBox_pass1.Text,
                                        dateTimePicker1.Value);

            //MuestraEN(nuevo);

            // -1 = No se sabe // 0 = todo Ok // 1 = DNI Existente // 2 = Nick Existente // 3 = Nick y DNI existen
            int error = en_admin.InsertarAdmin();

            if (error == 0)
            {
                MessageBox.Show("Se ha insertado con éxito.");
                errorProviderNif.Clear();
                errorProviderNick.Clear();
                return true;
            }
            else if (error == 1)
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "El DNI ya está registrado.");
                errorProviderNick.Clear();
                return false;
            }
            else if (error == 2)
            {
                errorProviderNick.SetError(label_NombreUsuario, "El Nombre de Usuario ya existe.");
                errorProviderNif.Clear();
                return false;
            }
            else if (error == 3)
            {
                errorProviderNick.SetError(label_NombreUsuario, "El Nombre de Usuario ya existe.");
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "El DNI ya está registrado.");
                return false;
            }
            else
            {
                MessageBox.Show("Se ha producido un error desconocido.");
                errorProviderNif.Clear();
                errorProviderNick.Clear();
                return false;
            }
        }

        // Establecela llamada a la funcion de almacenaje del Admin en el EN, creando un EN de Admin,
        // estableciendo sus valores, y seguidamente almacenandolos.
        private bool AltaAdminEN_PorPasos()
        {
            en_admin = new AdminEN();

            en_admin.DNI = Admin_Perfil_txtBox_NIF.Text;
            en_admin.Nombre = Admin_Perfil_txtBox_Nombre.Text;
            en_admin.Apellidos = Admin_Perfil_txtBox_Apellidos.Text;
            en_admin.Domicilio = comboBoxDirec.Text + " " + Admin_Perfil_txtBox_Domicilio.Text;
            en_admin.CP = textBox_CP_Perfil.Text;
            en_admin.Pais = Admin_Perfil_comboBox_Pais.Text;
            en_admin.Provincia = comboBox_Provincia.Text;
            en_admin.Localidad = txtBox_Localidad.Text;
            en_admin.Telefono = Admin_Perfil_txtBox_Tel1.Text;
            en_admin.Movil = Admin_Perfil_txtBox_Tel2.Text;
            en_admin.Mail = Admin_Perfil_txtBox_Mail.Text;

            en_admin.Fecha = dateTimePicker1.Value;

            if (Admin_Perfil_rButom_H.Checked == true)
                en_admin.Sexo = 0;
            else if (Admin_Perfil_rButom_M.Checked == true)
                en_admin.Sexo = 1;

            // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
            if (Admin_Perfil_rButom_Soltero.Checked == true)
                en_admin.EC = Admin_Perfil_rButom_Soltero.Text;
            else if (Admin_Perfil_rButom_Casado.Checked == true)
                en_admin.EC = Admin_Perfil_rButom_Casado.Text;
            else if (Admin_Perfil_rButom_Divorciado.Checked == true)
                en_admin.EC = Admin_Perfil_rButom_Divorciado.Text;
            else if (Admin_Perfil_rButom_Viudo.Checked == true)
                en_admin.EC = Admin_Perfil_rButom_Viudo.Text;

            en_admin.Nick = textBox_NombreUsuario.Text;
            en_admin.Pass = textBox_pass1.Text;

            //MuestraEN(nuevo);

            if (imagenCambiada)
            {
                imagenCambiada = false;
                en_admin.Foto = Admin_Perfil_Foto.Image;
            }
            else
                en_admin.Foto = null;

            // -1 = No se sabe // 0 = todo Ok // 1 = DNI Existente // 2 = Nick Existente // 3 = Nick y DNI existen
            int error = en_admin.InsertarAdmin();

            if (error == 0)
            {
                MessageBox.Show("Se ha insertado con éxito.","",MessageBoxButtons.OK,MessageBoxIcon.Information
                                ,MessageBoxDefaultButton.Button1);
                errorProviderNif.Clear();
                errorProviderNick.Clear();
                return true;
            }
            else if (error == 1)
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "El DNI ya está registrado.");
                errorProviderNick.Clear();
                return false;
            }   
            else if (error == 2)
            {
                errorProviderNick.SetError(label_NombreUsuario, "El Nombre de Usuario ya existe.");
                errorProviderNif.Clear();
                return false;
            }
            else if (error == 3)
            {
                errorProviderNick.SetError(label_NombreUsuario, "El Nombre de Usuario ya existe.");
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "El DNI ya está registrado.");
                return false;
            }
            else
            {
                MessageBox.Show("Se ha producido un error desconocido.");
                errorProviderNif.Clear();
                errorProviderNick.Clear();
                return false;
            }
        }

        // Obtiene la id de un administrador mediante el nick del usuario.
        private int ObtieneID(string usuario)
        {
            en_admin = new AdminEN();
            return en_admin.ObtieneID(usuario);
        }

        // Metodo que establece la llamada para borrar el Admin mediante el pase del ID de este.
        private void BorrarAdmin()
        {
            en_admin = new AdminEN();

            if (MessageBox.Show("¿Desea eliminar este administrador? \nEste cambio se realizará de forma permanente.",
                                    "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                                    == DialogResult.Yes)
            {
                if (!en_admin.BorraAdmin(idActual))
                {
                    MessageBox.Show("No se ha podido eliminar el Administrador.");
                }
                else
                {
                    LimpiarDatos();
                }
            }
        }

        #endregion

        #region Seccion Busqueda

        // Boton que realiza la llamada para limpiar los datos introducidos para realizar la busqueda.
        private void boton_limpia_busqueda_Click(object sender, EventArgs e)
        {
            LimpiaBusqueda();
        }

        // Boton que realiza la busqueda en base al filtro seleccionado y muestra en el datagrid el 
        // resultado de esta.
        private void buttom_Buscar_Click(object sender, EventArgs e)
        {
            en_admin = new AdminEN();
            // mostrar todos, o lo que es lo mismo, no se ha establecido ningun filtro de busqueda
            //MuestraAdmins();

            if (comboBox_filtro.Text == "Mostrar Todos")
            {
                MuestraAdmins();
            }
            else if (comboBox_filtro.Text == "NIF")
            {
                MuestraDataSet(en_admin.Busqueda("NIF",textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Nombre")
            {
                MuestraDataSet(en_admin.Busqueda("Nombre", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Apellido")
            {
                MuestraDataSet(en_admin.Busqueda("Apellidos", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Nombre de Usuario")
            {
                MuestraDataSet(en_admin.Busqueda("Usuario", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "ID")
            {
                MuestraDataSet(en_admin.Busqueda("ID", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Pais")
            {
                MuestraDataSet(en_admin.Busqueda("Pais", comboBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Provincia")
            {
                MuestraDataSet(en_admin.Busqueda("Provincia", comboBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Localidad")
            {
                MuestraDataSet(en_admin.Busqueda("Poblacion", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Domicilio")
            {
                MuestraDataSet(en_admin.Busqueda("Direccion", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Código Postal")
            {
                MuestraDataSet(en_admin.Busqueda("CP", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Correo Electrónico")
            {
                MuestraDataSet(en_admin.Busqueda("Mail", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Teléfono o Móvil")
            {
                MuestraDataSet(en_admin.Busqueda("TM", textBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Estado Civil")
            {
                if(comboBox_filtro_busqueda.Text != "")
                    MuestraDataSet(en_admin.Busqueda("Estado", comboBox_filtro_busqueda.Text));
            }
            else if (comboBox_filtro.Text == "Sexo")
            {
                if(comboBox_filtro_busqueda.Text == "Hombre")
                    MuestraDataSet(en_admin.Busqueda("Sexo", "0"));
                else if(comboBox_filtro_busqueda.Text == "Mujer")
                    MuestraDataSet(en_admin.Busqueda("Sexo", "1"));
            }
        }

        // Muestra todos los Administradores dados de alta en el sistema en el Datagrid de la busqueda.
        public void MuestraAdmins()
        {
            en_admin = new AdminEN();

            muestraAdmin = new DataSet();
            muestraAdmin = en_admin.getAdmins();
            tAdmin = new DataTable();

            try
            {
                Resultados_Busqueda.Rows.Clear();
                foreach(DataRow administrador in muestraAdmin.Tables[0].Rows)
                {
                    string[] row = { administrador["ID"].ToString(),
                                     administrador["NIF"].ToString(), 
                                     administrador["Usuario"].ToString(),
                                     administrador["Nombre"].ToString(),
                                     administrador["Apellidos"].ToString(),
                                     administrador["Mail"].ToString()};
                    Resultados_Busqueda.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show("PWNDED, petada hermosa :D");
            }
        }

        // Muestra los datos en el formulario del administrados que se ha seleccionado en el Datagrid. 
        private void Resultados_Busqueda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                en_admin = new AdminEN();

                if (e.ColumnIndex == Resultados_Busqueda.Columns["editar"].Index)
                {
                    System.Diagnostics.Debug.Write("\nSelecciono = " + Resultados_Busqueda[0, e.RowIndex].Value.ToString() + "\n");

                    RellenaDatos_AdminSeleccionado(sender, e);
                    LimpiaBusqueda();
                }
                else if (e.ColumnIndex == Resultados_Busqueda.Columns["borrar"].Index)
                {
                    if (MessageBox.Show("¿Desea eliminar este administrador? \nEste cambio se realizará de forma permanente.",
                                    "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                                    == DialogResult.Yes)
                    {
                        en_admin.BorraAdmin(Convert.ToInt16(Resultados_Busqueda[0, e.RowIndex].Value.ToString()));
                        MuestraAdmins();
                    }
                }
            }
        }

        // Rellena los datos del formulario principal en base al admin que se le indique.
        private void RellenaDatos_AdminSeleccionado(object sender, DataGridViewCellMouseEventArgs e)
        {
            en_admin = new AdminEN();
            
            LimpiarDatos();
            
            idActual = Convert.ToInt16(Resultados_Busqueda[0, e.RowIndex].Value.ToString());
            muestraAdmin = en_admin.getAdmin(idActual);

            System.Diagnostics.Debug.Write("\nID del Admin seleccionado = " + idActual + "\n");

            #region Rellenando Datos

            string aux = "";
            bool espacio = false;
        
            Admin_Perfil_txtBox_NIF.Text = muestraAdmin.Tables[0].Rows[0][0].ToString();
            Admin_Perfil_txtBox_Nombre.Text = muestraAdmin.Tables[0].Rows[0][1].ToString();
            Admin_Perfil_txtBox_Apellidos.Text = muestraAdmin.Tables[0].Rows[0][2].ToString();
            textBox_NombreUsuario.Text = muestraAdmin.Tables[0].Rows[0][3].ToString();
            // muestraAdmin.Tables[0].Rows[0][4] es el pass

            dateTimePicker1.Value = (DateTime) muestraAdmin.Tables[0].Rows[0][5];

            txtBox_Localidad.Text = muestraAdmin.Tables[0].Rows[0][6].ToString();
            comboBox_Provincia.Text = muestraAdmin.Tables[0].Rows[0][7].ToString();
            Admin_Perfil_comboBox_Pais.Text = muestraAdmin.Tables[0].Rows[0][8].ToString();

            aux = muestraAdmin.Tables[0].Rows[0][9].ToString();
            
            comboBoxDirec.Text = "";
            Admin_Perfil_txtBox_Domicilio.Text = "";

            espacio = false;
            
            for (int i = 0; i < aux.Length; i++)
            {   
                if (aux[i] == ' ' && !espacio)
                {
                    espacio = true;
                }
                else if (!espacio)
                {
                    comboBoxDirec.Text = comboBoxDirec.Text + aux[i];
                }
                else if (espacio)
                {
                    Admin_Perfil_txtBox_Domicilio.Text = Admin_Perfil_txtBox_Domicilio.Text + aux[i];
                }
            }

            string auxTel = muestraAdmin.Tables[0].Rows[0][10].ToString();
            string tel = "";

            for(int i = 0; i < auxTel.Length; i++)
            {
                if(i == 3)
                    tel = tel + " ";

                tel = tel + auxTel[i];
            }

            Admin_Perfil_txtBox_Tel1.Text = tel;

            auxTel = muestraAdmin.Tables[0].Rows[0][11].ToString();
            tel = "";

            for (int i = 0; i < auxTel.Length; i++)
            {
                if (i == 3)
                    tel = tel + " ";

                tel = tel + auxTel[i];
            }

            Admin_Perfil_txtBox_Tel2.Text = tel;


            Admin_Perfil_txtBox_Mail.Text = muestraAdmin.Tables[0].Rows[0][12].ToString();

            idActual = Convert.ToInt16(muestraAdmin.Tables[0].Rows[0][13].ToString());
            label_ID.Text = "ID de usuario : " + idActual;
            label_ID.Visible = true;

            aux = muestraAdmin.Tables[0].Rows[0][14].ToString();

            if (aux[0] == 'S')
            {
                Admin_Perfil_rButom_Casado.Checked = false;
                Admin_Perfil_rButom_Viudo.Checked = false;
                Admin_Perfil_rButom_Divorciado.Checked = false;
                Admin_Perfil_rButom_Soltero.Checked = true;
            }
            else if (aux[0] == 'C')
            {
                Admin_Perfil_rButom_Soltero.Checked = false;
                Admin_Perfil_rButom_Viudo.Checked = false;
                Admin_Perfil_rButom_Divorciado.Checked = false;
                Admin_Perfil_rButom_Casado.Checked = true;
            }
            else if (aux[0] == 'D')
            {
                Admin_Perfil_rButom_Soltero.Checked = false;
                Admin_Perfil_rButom_Casado.Checked = false;
                Admin_Perfil_rButom_Viudo.Checked = false;
                Admin_Perfil_rButom_Divorciado.Checked = true;
            }
            else if (aux[0] == 'V')
            {
                Admin_Perfil_rButom_Soltero.Checked = false;
                Admin_Perfil_rButom_Casado.Checked = false;
                Admin_Perfil_rButom_Divorciado.Checked = false;
                Admin_Perfil_rButom_Viudo.Checked = true;
            }
            else
                MessageBox.Show("Se ha localizado un error con los estados en la BD.");

            textBox_CP_Perfil.Text = muestraAdmin.Tables[0].Rows[0][16].ToString();

            if (muestraAdmin.Tables[0].Rows[0][17].ToString() == "0")
            {
                Admin_Perfil_rButom_H.Checked = true;
                Admin_Perfil_rButom_M.Checked = false;
            }
            else if (muestraAdmin.Tables[0].Rows[0][17].ToString() == "1")
            {
                Admin_Perfil_rButom_H.Checked = false;
                Admin_Perfil_rButom_M.Checked = true;
            }
            else
                MessageBox.Show("Se ha localizado un error con el sexo en la BD.");

            #endregion

            edicion = true;
            //boton_eliminar.Enabled = true;
            textBox_anterior_pass.Enabled = true; 
            
            Admin_Perfil_boton_Guardar.Text = "Guardar";
            Admin_Perfil_boton_Anadir.Text = "Nuevo";
            Admin_Perfil_boton_Anadir.Image = Events4ALL.Properties.Resources.mas;

            Image im;

            im = en_admin.ObtieneImagen(idActual);

            if (im != null)
                Admin_Perfil_Foto.Image = im;
            else
                Admin_Perfil_Foto.Image = Events4ALL.Properties.Resources.Events4All;



            tabControl1.SelectTab("Perfil");
        }

        // Muestra en el datragrid de busqueda aquel Dataset que se le pase por parametro.
        private void MuestraDataSet(DataSet muestrame)
        {
            tAdmin = new DataTable();

            try
            {
                Resultados_Busqueda.Rows.Clear();
                foreach (DataRow administrador in muestrame.Tables[0].Rows)
                {
                    string[] row = { administrador["ID"].ToString(),
                                     administrador["NIF"].ToString(), 
                                     administrador["Usuario"].ToString(),
                                     administrador["Nombre"].ToString(),
                                     administrador["Apellidos"].ToString(),
                                     administrador["Mail"].ToString()};
                    Resultados_Busqueda.Rows.Add(row);
                }
            }
            catch
            {
                MessageBox.Show("PWNDED, petada hermosa :D");
            }
        }

        // Muestra o oculta campos en base al filtro seleccionado en la busqueda.
        private void comboBox_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_filtro.Text == "Mostrar Todos")
            {
                textBox_filtro_busqueda.Visible = false;
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "NIF")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Nombre")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Apellido")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Nombre de Usuario")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "ID")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Pais")
            {
                textBox_filtro_busqueda.Visible = false;
                comboBox_filtro_busqueda.Visible = true;

                comboBox_filtro_busqueda.Items.Clear();

                for (int i = 0; i < Admin_Perfil_comboBox_Pais.Items.Count; i++ )
                {
                    comboBox_filtro_busqueda.Items.Add(Admin_Perfil_comboBox_Pais.Items[i]);
                }
            }
            else if (comboBox_filtro.Text == "Provincia")
            {
                textBox_filtro_busqueda.Visible = false;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = true;

                comboBox_filtro_busqueda.Items.Clear();

                for (int i = 0; i < comboBox_Provincia.Items.Count; i++)
                {
                    comboBox_filtro_busqueda.Items.Add(comboBox_Provincia.Items[i]);
                }
            }
            else if (comboBox_filtro.Text == "Localidad")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Domicilio")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Código Postal")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Correo Electrónico")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Teléfono o Móvil")
            {
                textBox_filtro_busqueda.Visible = true;
                textBox_filtro_busqueda.Text = "";
                comboBox_filtro_busqueda.Visible = false;
            }
            else if (comboBox_filtro.Text == "Estado Civil")
            {
                textBox_filtro_busqueda.Visible = false;
                comboBox_filtro_busqueda.Visible = true;
                
                comboBox_filtro_busqueda.Items.Clear();

                comboBox_filtro_busqueda.Items.Add("Soltero/a");
                comboBox_filtro_busqueda.Items.Add("Casado/a");
                comboBox_filtro_busqueda.Items.Add("Divorciado/a");
                comboBox_filtro_busqueda.Items.Add("Viudo/a");
            }
            else if (comboBox_filtro.Text == "Sexo")
            {
                textBox_filtro_busqueda.Visible = false;
                comboBox_filtro_busqueda.Visible = true;
                
                comboBox_filtro_busqueda.Items.Clear();

                comboBox_filtro_busqueda.Items.Add("Hombre");
                comboBox_filtro_busqueda.Items.Add("Mujer");
            }
        }

        #endregion

        #region Basura que da pereza Borrar XD

        private void textBox_movil_busqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Busqueda_Enter(object sender, EventArgs e)
        {

        }

        private void Resultados_Busqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Basura xD
        private void radioButton_edad_no_CheckedChanged(object sender, EventArgs e)
        {
            //numericUpDown_Fec1.Enabled = false;
            //numericUpDown_Fec2.Enabled = false;
        }

        private void radioButton_edad_si_CheckedChanged(object sender, EventArgs e)
        {
            //numericUpDown_Fec1.Enabled = true;
            //numericUpDown_Fec2.Enabled = true;
        }

        #endregion

        #region Cerdada hermosa

        // Carga y muestra todos administradores del sistema al entrar en el pestaña de busqueda.
        private void tabControl1_Click(object sender, EventArgs e)
        {
            MuestraAdmins();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            MuestraAdmins();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //MuestraAdmins();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            MuestraAdmins();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //MuestraAdmins();
        }

        #endregion

    }
}
