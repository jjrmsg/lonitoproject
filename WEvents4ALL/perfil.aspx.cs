using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using Auxiliares;
using System.Data;

namespace WEvents4ALL
{
    public partial class perfil : System.Web.UI.Page
    {
        ClientesEN cliente = new ClientesEN();
        DataSet perfilCliente = new DataSet();
        Validaciones valida;

        protected void Page_Load(object sender, EventArgs e)
        {
            // obtengo los datos del cliente bastardo
            perfilCliente = cliente.ObtenerUsuarioPorID("3");

            // En un principio, sin meter valor predeterminado, seria de la siguiente forma
            //perfilCliente = cliente.ObtenerUsuarioPorID(Session["idCliente"].ToString());

            // Relleno los datos del cliente a partir del DataSet recibido.
            RellenaDatos();
        }

        // Valida los datos :
        // 1 - Si estan correctos, ejecuta la SQL de la actualizacion en la BD
        // 2 - Si es un Fail, ya vere...
        protected void bGuardar_Click(object sender, EventArgs e)
        {
            TextBox_NIF.Text = "Pene";

            /*if(ValidaDatos())
            {
                ClientesEN actualiza = new ClientesEN(TextBox_NIF.Text,TextBox_Nombre.Text,TextBox_Apellido.Text,
                                                      DropDownList_Pais.Text, DropDownList_Prov.Text, TextBox_Localidad.Text,
                                                      TextBox_Domicilio.Text, TextBox_CP.Text, TextBox_Telefono.Text,
                                                      TextBox_Movil.Text,TextBox_Mail.Text, null, null,
                                                      0,Fecha(),null,null);


            }
            */
            // Valida Pass Ojo.
        }

        // Restaura los datos del Dataset actual.
        protected void bCancelar_Click(object sender, EventArgs e)
        {
            // Restauro los datos a partir del DataSet de la carga.
            RellenaDatos();
        }

        // Valida los datos y establece los mensajes de error pertinentes en la pagina.
        // Retorna un booleano si son correctos o no.
        protected bool ValidaDatos()
        {
            valida = new Validaciones();
            bool error = false;

            return error;
        }

        // Rellena los datos a partir del DataSet de la carga.
        // Ojo, me falta la parte de la imagen !!!!!!!!!!!!!!!!!!!!!!!!!!
        protected void RellenaDatos()
        {
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
                else
                    DropDownList_Sexo.Text = "";

                // Fecha Provisional... que ya veremos si cambio.... xD
                string fecha = r["FechaNac"].ToString();
                string dia = fecha[0].ToString() + fecha[1];
                string mes = fecha[3].ToString() + fecha[4];
                string ano = fecha[6].ToString() + fecha[7] + fecha[8] + fecha[9];
                TextBox_FN.Text = dia + '/' + mes + '/' + ano;

                // Carga de la imagen

                // Borro los passwords.
                TextBox_PASS_1.Text = "";
                TextBox_PASS_2.Text = "";
                TextBox_PASS_3.Text = "";
            }
        }

        protected DateTime Fecha()
        {
            string dia, mes, ano;
            string txtFecha = TextBox_FN.Text;

            dia = txtFecha[0].ToString() + txtFecha[1];
            mes = txtFecha[3].ToString() + txtFecha[4];
            ano = txtFecha[6].ToString() + txtFecha[7] + txtFecha[8] + txtFecha[9];

            return Convert.ToDateTime(mes+'/'+dia+'/'+ano);
        }
    }
}