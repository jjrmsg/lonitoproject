using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using System.Web.UI.WebControls;

namespace WEvents4ALL
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }   

        protected void EventoClick(Object sender, EventArgs e)
        {
            try
            {
                string idsession = "";
                /* idsession=Session["NickUsuario"].ToString();*/
                string tipo = contacto_DropDownList1.SelectedValue.ToString();
                string texto = TextArea1.Value.ToString();
                string mail = TextBox1.Text.ToString();

                MensajesEN mensaje = new MensajesEN();
                mensaje.insertMessageEn(idsession,mail,tipo,texto);

                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 1;
                Label lbTitle = (Label)Master.FindControl("successViewTitle");
                Label lbMsg = (Label)Master.FindControl("successViewMsg");
                lbTitle.Text = "Enviado";
                lbMsg.Text = "Su mensaje se envio correctamente";
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

    }
}