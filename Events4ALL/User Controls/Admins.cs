using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.Auxiliares;

namespace Events4ALL
{
    public partial class Admins : UserControl
    {
        private Validaciones validar;

        private bool nif;
        private bool nombre;
        private bool apellidos;
        private bool pais;
        private bool CP;
        private bool domicilio;
        private bool provincia;
        private bool localidad;
        private bool telefono;
        private bool movil;
        private bool mail;
        private bool fnac;
        
        public Admins()
        {
            InitializeComponent();

            // creo el objeto que se encargara de validar
            validar = new Validaciones();

            // inicializo todos los booleanos que indican si son o no correctos sus parametros
            nif = nombre = apellidos = pais = CP = domicilio = provincia = false;
            localidad = telefono = movil = mail = fnac = false;
        }

        private bool ValidaFormulario()
        {
            if (nif && nombre && apellidos && pais && CP && domicilio && provincia && localidad
                 && telefono && movil && fnac)
            {
                return true;
            }
            else
                return false;
        }

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
            else if( validar.CompruebaCP(label_CP_Perfil.Text) )
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
                errorProviderMail.Clear();
            }
            // mail muy largo
            else if (Admin_Perfil_txtBox_Mail.Text.Length >= 50)
            {
                mail = false;
                errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Mail demasiado largo. Máximo 50 carácteres.");
            }
            // mail incorrecto
            else if ( validar.CompruebaMail(Admin_Perfil_txtBox_Mail.Text))
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
                errorProviderTEL.Clear();
            }
            // no tiene 9 numeros o esta mal.
            else if (Admin_Perfil_txtBox_Tel1.Text.Length != 9 && validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel1.Text))
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
                movil = false;
                errorProviderMov.Clear();
            }
            // no tiene 9 numeros o esta mal.
            else if (Admin_Perfil_txtBox_Tel2.Text.Length != 9 && validar.CompruebaTelefono(Admin_Perfil_txtBox_Tel2.Text))
            {
                movil = false;
                errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Teléfono incorrecto.");
            }
            else
            {
                movil = true;
                errorProviderMov.Clear();
            }
        }
       
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
            Admin_Perfil_txtBox_Tel1.Text = "";
            errorProviderTEL.Clear();
            telefono = false;
            
            // borra movil
            Admin_Perfil_txtBox_Tel2.Text = "";
            errorProviderMov.Clear();
            movil = false;
            
            // borra mail
            Admin_Perfil_txtBox_Mail.Text = "";
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
            if ( ValidaFormulario() )
            {
                // creo el EN y toda la pedazo de basura posterior
                MessageBox.Show("Todo Ok");
            }
            else
            { 
                if( !nif )
                    errorProviderNif.SetError(Admin_Perfil_Label_NIF,"Debe de rellenar el NIF.");
               
                if( !Admin_Perfil_rButom_H.Checked && !Admin_Perfil_rButom_M.Checked)
                    errorProviderSexo.SetError(Admin_Perfil_Label_Sexo, "Seleccione un campo del Sexo.");
                
                if( !nombre )
                    errorProviderNombre.SetError(Admin_Perfil_Label_Nombre, "Debe de rellenar el Nombre.");
                
                if( !apellidos )
                    errorProviderApellidos.SetError(Admin_Perfil_Label_Apellidos, "Debe de rellenar los Apellidos.");
                
                if( !pais )
                    errorProviderPais.SetError(Admin_Perfil_Label_Pais, "Seleccione un País.");
                
                if( !CP )
                    errorProviderCP.SetError(label_CP_Perfil, "Debe de introducir un Código Postal.");
                
                if( !domicilio )
                    errorProviderDomicilo.SetError(Admin_Perfil_Label_Domicilio, "Debe introducir un domicilio.");
                
                if( !Admin_Perfil_rButom_Soltero.Checked 
                    && !Admin_Perfil_rButom_Viudo.Checked
                    && !Admin_Perfil_rButom_Casado.Checked 
                    && !Admin_Perfil_rButom_Divorciado.Checked )
                    errorProviderEC.SetError(Admin_Perfil_Label_EstCivil, "Seleccione un Estado Civil.");
                
                if( !provincia )
                    errorProviderProvincia.SetError(Label_Provincia_Perfil, "Debe introducir una Provincia.");
                
                if( !localidad )
                    errorProviderLocalidad.SetError(Label_Localidad, "Debe introducir una Localidad.");
                
                if( !telefono )
                    errorProviderTEL.SetError(Admin_Perfil_Label_Tel1, "Debe introducir un Teléfono de contacto.");
                
                if( !movil )
                    errorProviderMov.SetError(Admin_Perfil_Label_Tel2, "Debe introducir un Móvil de contacto.");
                
                if( !mail )
                    errorProviderMail.SetError(Admin_Perfil_Label_Mail, "Debe de introducir un E-Mail de contacto.");
                
                if (!fnac)
                    errorProviderFNAC.SetError(Admin_Perfil_Label_FecNacimiento, "Introduzca una Fecha de Nacimiento.");
            }
        }
    }
}
