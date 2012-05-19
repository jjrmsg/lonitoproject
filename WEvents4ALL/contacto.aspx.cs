using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using System.Collections;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;

namespace WEvents4ALL
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count > 0)
            {
                ClientesEN cli=new ClientesEN();
                DataSet ds = new DataSet();
                ds = cli.ObtenerUsuarioPorID(Session["IdUsuario"].ToString());
                TextBox1.Text=ds.Tables[0].Rows[0][13].ToString();
            }
        }   

        protected void EventoClick(Object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string dni = "";
                string id = "";

                //Caso de que usuario este iniciado le cargamos el mail que facilito en el registro
                if (Session.Count>0)
                {
                    id = Session["IdUsuario"].ToString();
                    ClientesEN cli = new ClientesEN();
                    ds = cli.ObtenerUsuarioPorID(id);
                    dni = ds.Tables[0].Rows[0][5].ToString();
                }


                string tipo = contacto_DropDownList1.SelectedValue.ToString();
                string texto = TextArea1.Value.ToString();
                string mail = TextBox1.Text.ToString();

                //validacion en el lado del servidor
                if (valido(tipo, mail) == true)
                {
                    MensajesEN mensaje = new MensajesEN();
                    mensaje.insertMessageEn(dni, mail, tipo, texto);

                    MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                    mv.ActiveViewIndex = 1;
                    Label lbTitle = (Label)Master.FindControl("successViewTitle");
                    Label lbMsg = (Label)Master.FindControl("successViewMsg");
                    lbTitle.Text = "Enviado";
                    lbMsg.Text = "Su mensaje se envio correctamente";
                }
                else
                {
                    MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                    mv.ActiveViewIndex = 0;
                    Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                    Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                    lbTitle.Text = "Ocurrió un error";
                    lbMsg.Text = "Su mensaje no fue enviado, es incorrecto";
                }
            }
            catch (Exception ex)
            {
                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 0;
                Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                lbTitle.Text = "Ocurrió un error";
                lbMsg.Text = "Su mensaje no fue enviado, intentelo mas tarde";
            }
        }

        private bool valido(string tema,string mail)
        {
            bool valido = true;
            string patron = @"^[A-Za-z0-9]+@[A-Za-z]+\.[a-z]{2,4}";

            if (tema == "")
                valido = false;

            if (!Regex.Match(mail,patron).Success)
                valido = false;

            return valido;
        }
    }
}