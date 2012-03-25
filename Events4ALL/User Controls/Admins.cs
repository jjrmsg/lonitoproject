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

namespace Events4ALL
{
    public partial class Admins : UserControl
    {
        private Validaciones validar;

        #region Variables

        bool nuevoAdmin;

        #endregion

        public Admins()
        {
            InitializeComponent();

            nuevoAdmin = true;

            if (nuevoAdmin)
            {
                label_ID.Visible = false;
            }

            // creo el objeto que se encargara de validar
            validar = new Validaciones();
        }

        #region Comprobaciones

        private bool CompruebaNif()
        {
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
                return true;
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

        // comprueba que en la BD no hay un nick igual
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
            if (textBox_pass1.Text.Length == 0)
            {
                errorProviderPassInv.SetError(label_pass1, "Introduzca una Contraseña.");
                errorProviderPassDif.Clear();
                return false;
            }
            else if (validar.CompruebaPass(textBox_pass1.Text) || textBox_pass1.Text.Length <= 25)
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
                errorProviderPassInv.SetError(label_pass1, "Contraseña Invalida.");
                errorProviderPassDif.Clear();
                return false;
            }
        }

        private bool ValidaCampos()
        {
            bool error = true;

            if (!CompruebaPass())
                error = false;

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

        #endregion

        #region Limpiadores

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

        #endregion

        #region Accion Botones

        // boton Limpiar
        private void Admin_Perfil_boton_Anadir_Click(object sender, EventArgs e)
        {
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

            // falta la inicializacion de la fecha
        }

        // Boton Guardar
        private void Admin_Perfil_boton_Guardar_Click(object sender, EventArgs e)
        {
            // Comrpuebo que todos los campos estan rellenos
            if (ValidaCampos())
            {
                // creo el EN y toda la pedazo de basura posterior
                MessageBox.Show("Todo Ok.");
                AltaAdminEN_Directo();
                //AltaAdminEN_PorPasos();
            }
            else 
            {
                //MessageBox.Show("Fail.");
            }
        }

        #endregion

        #region Trabajo con EN

        private void AltaAdminEN_Directo()
        {
            int sexo = -1;
            int ec = -1;

            if (Admin_Perfil_rButom_H.Checked == true)
                sexo = 0;
            else if (Admin_Perfil_rButom_M.Checked == true)
                sexo = 1;

            // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
            if (Admin_Perfil_rButom_Soltero.Checked == true)
                ec = 0;
            else if (Admin_Perfil_rButom_Casado.Checked == true)
                ec = 1;
            else if (Admin_Perfil_rButom_Divorciado.Checked == true)
                ec = 2;
            else if (Admin_Perfil_rButom_Viudo.Checked == true)
                ec = 3;

            AdminEN nuevo = new AdminEN(Admin_Perfil_txtBox_NIF.Text, Admin_Perfil_txtBox_Nombre.Text, Admin_Perfil_txtBox_Apellidos.Text,
                                        Admin_Perfil_comboBox_Pais.Text, comboBox_Provincia.Text, txtBox_Localidad.Text,
                                        comboBoxDirec + " " + Admin_Perfil_txtBox_Domicilio.Text, textBox_CP_Perfil.Text,
                                        Admin_Perfil_txtBox_Tel1.Text, Admin_Perfil_txtBox_Tel2.Text, Admin_Perfil_txtBox_Mail.Text, ec, 
                                        "VACIO !!", sexo, textBox_NombreUsuario.Text, textBox_pass1.Text);
        }

        private void AltaAdminEN_PorPasos()
        {
            AdminEN nuevo = new AdminEN();

            nuevo.DNI = Admin_Perfil_txtBox_NIF.Text;
            nuevo.Nombre = Admin_Perfil_txtBox_Nombre.Text;
            nuevo.Apellidos = Admin_Perfil_txtBox_Apellidos.Text;
            nuevo.Domicilio = comboBoxDirec + " " + Admin_Perfil_txtBox_Domicilio.Text;
            nuevo.CP = textBox_CP_Perfil.Text;
            nuevo.Pais = Admin_Perfil_comboBox_Pais.Text;
            nuevo.Provincia = comboBox_Provincia.Text;
            nuevo.Localidad = txtBox_Localidad.Text;
            nuevo.Telefono = Admin_Perfil_txtBox_Tel1.Text;
            nuevo.Movil = Admin_Perfil_txtBox_Tel2.Text;
            nuevo.Mail = Admin_Perfil_txtBox_Mail.Text;

            nuevo.Fecha = dateTimePicker1.Value;

            if (Admin_Perfil_rButom_H.Checked == true)
                nuevo.Sexo = 0;
            else if (Admin_Perfil_rButom_M.Checked == true)
                nuevo.Sexo = 1;

            // estado civil // 0 - Soltero // 1 - Casado // 2 - Divorciado // 3 - Viudo
            if (Admin_Perfil_rButom_Soltero.Checked == true)
                nuevo.EC = 0;
            else if (Admin_Perfil_rButom_Casado.Checked == true)
                nuevo.EC = 1;
            else if (Admin_Perfil_rButom_Divorciado.Checked == true)
                nuevo.EC = 2;
            else if (Admin_Perfil_rButom_Viudo.Checked == true)
                nuevo.EC = 3;

            nuevo.Foto = "VACIA !!";

            nuevo.Nick = textBox_NombreUsuario.Text;
            nuevo.Pass = textBox_pass1.Text;
        }

        #endregion

    }
}
