using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Auxiliares;
using System.Data;
using System.Text.RegularExpressions;

namespace WEvents4ALL
{
    public partial class registro : System.Web.UI.Page
    {
        public ClientesEN en_cliente;
        public DataSet fichaCliente = new DataSet();
        public Validaciones valida;
        bool introducido;

        protected void Page_Load(object sender, EventArgs e)
        {
            // No marcamos nada en la barra de enlaces
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 0;
        }

        // Registro el usuario en la BD
        protected void Registro_Cliente(object sender, EventArgs e)
        {
            ClientesEN nuevoCliente = new ClientesEN();
            MultiView mvc = (MultiView)Master.FindControl("MultiViewAlerts");
            mvc.ActiveViewIndex = 0;
            Label lbTittle = (Label)Master.FindControl("errorViewTitle");
            Label lbMsg = (Label)Master.FindControl("errorViewMsg");

            if ((ValidaCamposCliente()) && (!nuevoCliente.CompruebaExistenciaNif(textbox_NIFC.Text)))
            {

                nuevoCliente.DNI = textbox_NIFC.Text;
                nuevoCliente.Nombre = textbox_nombreC.Text;
                nuevoCliente.Apellidos = textbox_apellidosC.Text;
                nuevoCliente.Domicilio = textbox_domicilioC.Text;
                nuevoCliente.Pais = DropDownList_Pais.Text;
                nuevoCliente.Provincia = DropDownList_Prov.Text;
                nuevoCliente.Localidad = textbox_localidadC.Text;
                nuevoCliente.CP = textbox_CodigoPostalC.Text;
                nuevoCliente.Movil = textbox_movilC.Text;
                nuevoCliente.Telefono = textbox_telefonoC.Text;
                nuevoCliente.Mail = textbox_emailC.Text;
                nuevoCliente.Fecha = Convert.ToDateTime(textbox_fechaN.Text);
                nuevoCliente.Nick = textbox_usuario.Text;
                nuevoCliente.Password = textbox_pass.Text;

                if (DropDownList_Sexo.Text == "Hombre")
                    nuevoCliente.Sexo = 0;
                else if (DropDownList_Sexo.Text == "Mujer")
                    nuevoCliente.Sexo = 1;
                else
                    nuevoCliente.Sexo = -1;

                introducido = nuevoCliente.InsertarCliente();

                if (introducido == true)
                {
                    //MessageBox.Show("Los datos se han introducido satisfactoriamente.");
                    //Response.StatusCode = 404;
                    lbTittle.Text = "OK - TODO CORRECTO";
                    lbMsg.Text = "Datos introducidos con exito";

                }
                else if (introducido == false)
                {
                    //MessageBox.Show("Error. Se ha producido un fallo cuando se intentaba insertar el Cliente.");
                    lbTittle.Text = "ERROR - FALLO";
                    lbMsg.Text = "Ocurrió un error al insertar los datos";

                }

            }

        }

        #region Validar Datos

        string patronNombre = @"[a-zA-Z\s]{3,50}";
        string patronTelefono = @"\d{9}";
        string patronFecha = @"^([0-9]{1,2})\/([0-9]{1,2})\/[0-9][0-9][0-9][0-9]$";
        string patronCP = @"^\d{5}$";
        string patronMail = @"^(.+\@.+\..+)$";
        string patronPass = @"^([a-zA-Z0-9]{3,50})$";

        private bool ValidaCamposCliente()
        {
            bool error = true;

            // Nombre
            if (!Regex.Match(textbox_nombreC.Text, patronNombre).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Nombre incorrecto");
            }

            if (!CompruebaNif(textbox_NIFC.Text))
            {
                error = false;
                System.Diagnostics.Debug.Write("\n NIF incorrecto");
            }

            if (DropDownList_Pais.Text == "")
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Rellene el campo Pais, por favor");
            }

            if (!Regex.Match(textbox_localidadC.Text, patronNombre).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Localidad incorrecta");
            }

            if (!Regex.Match(textbox_domicilioC.Text, patronNombre).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Domicilio incorrecto");
            }

            if (!Regex.Match(textbox_telefonoC.Text, patronTelefono).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Telefono incorrecto");
            }

            if (!CompruebaSexo(DropDownList_Sexo.Text))
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Sexo incorrecto");
            }

            if (!Regex.Match(textbox_fechaN.Text, patronFecha).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Fecha Incorrecta");
            }

            if (DropDownList_Prov.Text == "")
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Por favor, seleccione una provincia");
            }

            if (!Regex.Match(textbox_CodigoPostalC.Text, patronCP).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Codigo Postal incorrecto");
            }

            if (!Regex.Match(textbox_emailC.Text, patronMail).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Email incorrecto");
            }

            if (!Regex.Match(textbox_movilC.Text, patronTelefono).Success)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Movil incorrecto");

            }

            if (textbox_pass.Text != textbox_rePass.Text)
            {
                error = false;
                System.Diagnostics.Debug.Write("\n Password incorrecto");
            }

            return error;
        }

        private bool CompruebaSexo(string texto)
        {
            if (texto == "" || texto == "Hombre" || texto == "Mujer")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool CompruebaNif(string texto)
        {
            valida = new Validaciones();

            if (!valida.CompruebaNIF(texto))
            {
                return false;
            }

            else if (texto == "")
            {
                return false;
            }

            else
            {
                return true;
            }

        }

        #endregion 
    }
}