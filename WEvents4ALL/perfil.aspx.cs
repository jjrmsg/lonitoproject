using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using System.Data;

namespace WEvents4ALL
{
    public partial class perfil : System.Web.UI.Page
    {
        ClientesEN cliente = new ClientesEN();
        DataSet perfilCliente = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            perfilCliente = cliente.ObtenerUsuarioPorID("3");
            // En un principio, sin meter valor predeterminado, seria de la siguiente forma
            //perfilCliente = cliente.ObtenerUsuarioPorID(Session["idCliente"].ToString());

            foreach (System.Data.DataRow r in perfilCliente.Tables[0].Rows)
            {
                // Grupo de TextBoxes
                TextBox_Nombre.Text = r["Nombre"].ToString();
                TextBox_Apellido.Text = r["Apellidos"].ToString();
                TextBox_CP.Text = r["CP"].ToString();
                TextBox_Domicilio.Text = r["Direccion"].ToString();
                TextBox_Localidad.Text = r["Poblacion"].ToString();
                TextBox_Mail.Text = r["Mail"].ToString();
                TextBox_Movil.Text = r["TfnoMovil"].ToString();
                TextBox_NIF.Text = r["NIF"].ToString();
                TextBox_Telefono.Text = r["TfnoFijo"].ToString();

                // Listas de mierda
                DropDownList_Pais.Text = r["Pais"].ToString();
                DropDownList_Prov.Text = r["Provincia"].ToString();

                if (r["Sexo"].ToString() == "0")
                    DropDownList_Sexo.Text = "Hombre";
                if (r["Sexo"].ToString() == "1")
                    DropDownList_Sexo.Text = "Mujer";

                // Fecha Provisional
                string fecha = r["FechaNac"].ToString();
                string dia = fecha[0].ToString() + fecha[1];
                string mes = fecha[3].ToString() + fecha[4];
                string ano = fecha[6].ToString() + fecha[7] + fecha[8] + fecha[9];
                TextBox_FN.Text = dia + '/' + mes + '/' + ano;
                    
            }
        }
    }
}