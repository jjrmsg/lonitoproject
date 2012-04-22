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

        public Admins()
        {
            string lang = ConfigurationManager.AppSettings.Get("Lenguaje");
            if (lang == "en")
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            
            InitializeComponent();

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
            boton_eliminar.Enabled = false;

            imagenCambiada = false;
        }

        // Carga los todos administradores al entrar en el panel de busqueda.
        // Limitar a 20 !!!
        private void tabControl1_Click(object sender, EventArgs e)
        {
            MuestraAdmins();
        }

        #region Comprobaciones

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

        private bool CompruebaNombre()
        { 
            
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
            // ok
            else
            {
                errorProviderNombre.Clear();
                return true;
            }
        }

        private bool CompruebaApellidos()
        {
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
            // ok
            else
            {
                errorProviderApellidos.Clear();
                return true;
            }
        }

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
            // correcto
            else
            {
                errorProviderLocalidad.Clear();
                return true;
            }
        }

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

        private bool CompruebaDomicilio()
        { 
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
            // ok
            else
            {
                errorProviderDomicilo.Clear();
                return true;
            }
        }

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

        private bool CompruebaNick()
        {
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
            else
            {
                errorProviderNick.SetError(label_NombreUsuario, "Introduzca un nombre de usuario.");
                return false;
            }
        }

        // comprueba la seguridad de PASS
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

        // rellena el formulario de Admin con un ejemplo predefinido
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

        private string IniciaFechaHoy()
        {
            string fechaHoy = DateTime.Now.Date.ToString();
            string aux = "";
            for (int i = 0; i < 10; i++)
                aux = aux + fechaHoy[i];

            return aux;
        }

        private void LimpiaTelefono(object sender, EventArgs e)
        {
            if(Admin_Perfil_txtBox_Tel1.Text == "000 000000")
                Admin_Perfil_txtBox_Tel1.Text = "";
        }

        private void LimpiaMovil(object sender, EventArgs e)
        {
            if(Admin_Perfil_txtBox_Tel2.Text == "000 000000")
                Admin_Perfil_txtBox_Tel2.Text = "";
        }

        private void LimpiaMail(object sender, EventArgs e)
        {
            if (Admin_Perfil_txtBox_Mail.Text == "usuario@event4all.es")
                Admin_Perfil_txtBox_Mail.Text = "";
        }

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
            boton_eliminar.Enabled = false;
            errorProviderPassAnt.Clear();
            textBox_anterior_pass.Text = "";

            #endregion
        }

        #endregion

        #region Seccion Perfil

        // Elimina el Admin seleccionado
        private void boton_eliminar_Click(object sender, EventArgs e)
        {
            BorrarAdmin();
        }
        
        // boton Limpiar
        private void Admin_Perfil_boton_Anadir_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            //RellenaDatos();
        }

        // Boton Guardar
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
                        idActual = ObtieneID(textBox_NombreUsuario.Text);
                        // Una vez insertado mostramos el ID que se le ha asignado
                        label_ID.Text = "ID de Usuario : " + idActual;
                        label_ID.Visible = true;

                        // Establecemos edicion a true, ya que si se realiza un modificacion del admin, tendremos que realizar
                        // un update y no un insert
                        edicion = true;

                        textBox_pass1.Text = "";
                        textBox_pass2.Text = "";

                        textBox_anterior_pass.Enabled = true;
                        boton_eliminar.Enabled = true;
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
                                                textBox_pass1.Text, textBox_pass2.Text, dateTimePicker1.Value);

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
                                                textBox_pass1.Text, textBox_pass2.Text, dateTimePicker1.Value);

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

        // boton Foto
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

        private int ObtieneID(string usuario)
        {
            en_admin = new AdminEN();
            return en_admin.ObtieneID(usuario);
        }

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

        // boton limpiar
        private void boton_limpia_busqueda_Click(object sender, EventArgs e)
        {
            LimpiaBusqueda();
        }

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

        private bool BusquedaVacia()
        { 
            return true;
        }

        // botoncejo buscar
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

        private void Resultados_Busqueda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            en_admin = new AdminEN();
            
            if (e.RowIndex < 0 || e.ColumnIndex != Resultados_Busqueda.Columns["borrar"].Index)
            {
                LimpiaBusqueda();
                RellenaDatos_AdminSeleccionado(sender, e);
            }
            else
            {
                en_admin.BorraAdmin(Convert.ToInt16(Resultados_Busqueda[0, e.RowIndex].Value.ToString()));
                MuestraAdmins();
            }
        }

        private void RellenaDatos_AdminSeleccionado(object sender, DataGridViewCellMouseEventArgs e)
        {
            en_admin = new AdminEN();
            
            LimpiarDatos();
            
            idActual = Convert.ToInt16(Resultados_Busqueda[0, e.RowIndex].Value.ToString());
            muestraAdmin = en_admin.getAdmin(idActual);

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

            // = muestraAdmin.Tables[0].Rows[0][15] es la foto

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
            boton_eliminar.Enabled = true;
            textBox_anterior_pass.Enabled = true;

            Image im;

            im = en_admin.ObtieneImagen(idActual);

            if (im != null)
                Admin_Perfil_Foto.Image = im;
            else
                Admin_Perfil_Foto.Image = Events4ALL.Properties.Resources.Events4All;

            tabControl1.SelectTab("Perfil");
        }

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

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            // MuestraAdmins();
        }
        #endregion

    }
}
