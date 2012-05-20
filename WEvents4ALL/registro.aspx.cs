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
        bool introducido;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Registro el usuario en la BD
        protected void Registro_Cliente(object sender, EventArgs e)
        {
            ClientesEN nuevoCliente = new ClientesEN();
            MultiView mvc = (MultiView)Master.FindControl("MultiViewAlerts");
            mvc.ActiveViewIndex = 0;
            Label lbTittle = (Label)Master.FindControl("errorViewTitle");
            Label lbMsg = (Label)Master.FindControl("errorViewMsg");

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
}