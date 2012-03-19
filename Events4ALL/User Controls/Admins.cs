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

namespace Events4ALL
{
    public partial class Admins : UserControl
    {
        private Validaciones validar;

        #region Variables

        private bool nif;
        private bool nombre;
        private bool apellidos;
        private bool CP;
        private bool domicilio;
        private bool localidad;
        private bool telefono;
        private bool movil;
        private bool mail;

        #endregion

        public Admins()
        {
            InitializeComponent();

            // creo el objeto que se encargara de validar
            validar = new Validaciones();

            // inicializo todos los booleanos que indican si son o no correctos sus parametros
            nif = nombre = apellidos = CP = domicilio = false;
            localidad = telefono = movil = mail = false;
        }

        private bool ValidaFormulario()
        {
            if ( nif && nombre && apellidos && CP && domicilio && localidad && telefono && movil && CompruebaSexo() 
                && CompruebaEC() )
            {
                return true;
            }
            else
                return false;
        }

        #region Comprobaciones

        private void CompruebaNif(object sender, EventArgs e)
        {
            //test1.Text = "" + validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text);
            //test2.Text = "" + validar.DevuelveLetra(Admin_Perfil_txtBox_NIF.Text);
            //test3.Text = "" + validar.ObtieneLetra(validar.DevuelveNumero(Admin_Perfil_txtBox_NIF.Text));

            // esta vacio
            if (Admin_Perfil_txtBox_NIF.Text.Length == 0)
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "NIF vacio.");
                //errorProviderNif.Clear();
                nif = false;
            }
            // esta mal
            else if (!validar.CompruebaNIF(Admin_Perfil_txtBox_NIF.Text))
            {
                errorProviderNif.SetError(Admin_Perfil_Label_NIF, "NIF incorrecto.");
                nif = false;
            }
            // esta bien
            else
            {
                errorProviderNif.Clear();
                nif = true;
            }
        }

        private void CompruebaNombre(object sender, EventArgs e)
        { 
            
            // vacio
            if( Admin_Perfil_txtBox_Nombre.Text.Length == 0 )
            {
                nombre = false;
                errorProviderNombre.Clear();
            }
            // la BD solo almacena 50 caracteres
            else if (Admin_Perfil_txtBox_Nombre.Text.Length >= 50)
            {
                nombre = false;
                errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Nombre demasiado largo. Máximo 50 carácteres.");
            }
            // ok
            else
            {
                nombre = true;
                errorProviderNombre.Clear();
            }
        }

        private void CompruebaApellidos(object sender, EventArgs e)
        {
            // vacio
            if (Admin_Perfil_txtBox_Apellidos.Text.Length == 0)
            {
                apellidos = false;
                errorProviderApellidos.Clear();
            }
            // la BD solo almacena 50 caracteres
            else if (Admin_Perfil_txtBox_Apellidos.Text.Length >= 50)
            {
                apellidos = false;
                errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Apellidos demasiado largos. Máximo 50 caracteres.");
            }
            // ok
            else
            {
                apellidos = true;
                errorProviderApellidos.Clear();
            }
        }

        private void CompruebaCP(object sender, EventArgs e)
        {
            // campo vacio
            if(textBox_CP_Perfil.Text.Length == 0)
            {
                CP = false;
                errorProviderCP.Clear();
            }
            // campo erroneo
            else if( !validar.CompruebaCP(textBox_CP_Perfil.Text) )
            {
                CP = false;
                errorProviderCP.SetError(label_CP_Perfil, "CP incorrecto.");
            }
            else
            {
                CP = true;
                errorProviderCP.Clear();
            }
        }

        private void CompruebaLocalidad(object sender, EventArgs e)
        { 
            // vacio
            if( txtBox_Localidad.Text.Length == 0)
            {
                localidad = false;
                errorProviderLocalidad.Clear();
            }
            // falla
            else if( txtBox_Localidad.Text.Length >= 50)
            {
                localidad = false;
                errorProviderLocalidad.SetError(Label_Localidad, "Localidad demasiado larga. Máximo 50 carácteres.");
            }
            // correcto
            else
            {
                localidad = true;
                errorProviderLocalidad.Clear();
            }
        }

        private void CompruebaMail(object sender, EventArgs e)
        { 
            // mail vacio
            if (Admin_Perfil_txtBox_Mail.Text.Length == 0)
            {
                mail = false;
                Admin_Perfil_txtBox_Mail.Text = "usuario@event4all.es";
                errorProviderMail.Clear();
            }
            // mail muy largo
            else if (Admin_Perfil_txtBox_Mail.Text.Length >= 50)
            {
                mail = false;
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Mail demasiado largo. Máximo 50 carácteres.");
            }
            // mail incorrecto
            else if ( !validar.CompruebaMail(Admin_Perfil_txtBox_Mail.Text))
            {
                mail = false;
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Mail incorrecto.");
            }
            else
            {
                mail = true;
                errorProviderMail.Clear();
            }
        }

        private void CompruebaTelefono(object sender, EventArgs e)
        { 
            // vacio
            if (Admin_Perfil_txtBox_Tel1.Text.Length == 0)
            {
                telefono = false;
                Admin_Perfil_txtBox_Tel1.Text = "000 000000";
                errorProviderTEL.Clear();
            }
            // no tiene 9 numeros o esta mal.
            else if ( !validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel1.Text))
            {
                telefono = false;
                errorProviderTEL.SetError(Admin_Perfil_Label_Tel1, "Teléfono incorrecto.");
            }
            else 
            {
                telefono = true;
                errorProviderTEL.Clear();
            }
        }

        private void CompruebaMovil(object sender, EventArgs e)
        {
            // vacio
            if (Admin_Perfil_txtBox_Tel2.Text.Length == 0)
            {
                Admin_Perfil_txtBox_Tel2.Text = "000 000000";
                movil = false;
                errorProviderMov.Clear();
            }
            // no tiene 9 numeros o esta mal.
            else if (!validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel2.Text))
            {
                movil = false;
                errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Móvil incorrecto.");
            }
            else
            {
                movil = true;
                errorProviderMov.Clear();
            }
        }

        private void CompruebaDomicilio(object sender, EventArgs e)
        { 
            // vacio
            if( Admin_Perfil_txtBox_Domicilio.Text.Length == 0 )
            {
                domicilio = false;
                errorProviderDomicilo.Clear();
            }
            // Demasiado largo
            else if (Admin_Perfil_txtBox_Domicilio.Text.Length > 42)
            {
                domicilio = false;
                errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Dirección demasiado larga.");
            }
            // ok
            else
            {
                domicilio = true;
                errorProviderDomicilo.Clear();
            }
        }

        private bool CompruebaSexo()
        {
            if (Admin_Perfil_rButom_H.Checked == false && Admin_Perfil_rButom_M.Checked == false)
                return false;
            else
                return true;
        }

        private bool CompruebaEC()
        {
            if (Admin_Perfil_rButom_Soltero.Checked == false &&
                Admin_Perfil_rButom_Viudo.Checked == false &&
                Admin_Perfil_rButom_Divorciado.Checked == false &&
                Admin_Perfil_rButom_Casado.Checked == false)
                return false;
            else
                return true;
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

        private void Admin_Perfil_boton_Anadir_Click(object sender, EventArgs e)
        {
            // borra nif
            Admin_Perfil_txtBox_NIF.Text = "";
            errorProviderNif.Clear();
            nif = false;
            
            // borra nombre
            Admin_Perfil_txtBox_Nombre.Text = "";
            errorProviderNombre.Clear();
            nombre = false;
            
            // borra apellido
            Admin_Perfil_txtBox_Apellidos.Text = "";
            errorProviderApellidos.Clear();
            apellidos = false;
            
            // borra telefono
            Admin_Perfil_txtBox_Tel1.Text = "000 000000";
            errorProviderTEL.Clear();
            telefono = false;
            
            // borra movil
            Admin_Perfil_txtBox_Tel2.Text = "000 000000";
            errorProviderMov.Clear();
            movil = false;
            
            // borra mail
            Admin_Perfil_txtBox_Mail.Text = "usuario@event4all.es";
            errorProviderMail.Clear();
            mail = false;

            // borra localidad
            txtBox_Localidad.Text = "";
            errorProviderLocalidad.Clear();
            localidad = false;

            // borra domicilio
            Admin_Perfil_txtBox_Domicilio.Text = "";
            errorProviderDomicilo.Clear();
            domicilio = false;

            // borra CP
            textBox_CP_Perfil.Text = "";
            errorProviderCP.Clear();
            CP = false;

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

            // falta la inicializacion de la fecha
        }

        private void Admin_Perfil_boton_Guardar_Click(object sender, EventArgs e)
        {
            // Comrpuebo que todos los campos estan rellenos
            if (ValidaFormulario() && Admin_Perfil_comboBox_Pais.Text != "" && comboBox_Provincia.Text != "")
            {
                // creo el EN y toda la pedazo de basura posterior
                MessageBox.Show("Todo Ok");
            }
            else
            {
                if(comboBox_Provincia.Text == "")
                    errorProviderProvincia.SetError(Label_Provincia_Perfil, "Debe seleccionar una provincia.");

                if (Admin_Perfil_comboBox_Pais.Text == "")
                    errorProviderPais.SetError(Admin_Perfil_Label_Pais,"Debe seleccionar su país de nacimiento.");

                if (!CompruebaEC() )
                    errorProviderEC.SetError(Admin_Perfil_Label_EstCivil, "Debe seleccionar un Estado Civil.");

                if (!CompruebaSexo())
                    errorProviderSexo.SetError(Admin_Perfil_Label_Sexo, "Debe seleccionar un sexo.");

                if( !nif )
                    errorProviderNif.SetError(Admin_Perfil_Label_NIF,"Debe de rellenar el NIF.");
               
                if( !Admin_Perfil_rButom_H.Checked && !Admin_Perfil_rButom_M.Checked)
                    errorProviderSexo.SetError(Admin_Perfil_Label_Sexo, "Seleccione un campo del Sexo.");
                
                if( !nombre )
                    errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Debe de rellenar el Nombre.");
                
                if( !apellidos )
                    errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Debe de rellenar los Apellidos.");
                
                if( !CP )
                    errorProviderCP.SetError(label_CP_Perfil, "Debe de introducir un Código Postal.");
                
                if( !domicilio )
                    errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Debe introducir un domicilio.");
                
                if( !Admin_Perfil_rButom_Soltero.Checked 
                    && !Admin_Perfil_rButom_Viudo.Checked
                    && !Admin_Perfil_rButom_Casado.Checked 
                    && !Admin_Perfil_rButom_Divorciado.Checked )
                    errorProviderEC.SetError(Admin_Perfil_Label_EstCivil, "Seleccione un Estado Civil.");
                
                if( !localidad )
                    errorProviderLocalidad.SetError(Label_Localidad, "Debe introducir una Localidad.");
                
                if( !telefono )
                    errorProviderTEL.SetError(Admin_Perfil_Label_Tel1, "Debe introducir un Teléfono de contacto.");
                
                if( !movil )
                    errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Debe introducir un Móvil de contacto.");
                
                if( !mail )
                    errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Debe de introducir un E-Mail de contacto.");
            }
        }

        #endregion
    }
}
