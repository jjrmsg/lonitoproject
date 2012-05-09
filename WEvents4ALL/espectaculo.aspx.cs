using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;


namespace WEvents4ALL
{
    public partial class espectaculo : System.Web.UI.Page
    {
        public DataSet datosEsp = null;
        public DataSet datosCrit = null;   
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            /* Muestra un mensaje */
            MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
            mv.ActiveViewIndex = 1;  
            Label lbTitle = (Label)Master.FindControl("successViewTitle");
            Label lbMsg = (Label)Master.FindControl("successViewMsg");
            lbTitle.Text = "Titulo de mensaje desde espectaculo";
            lbMsg.Text = "Mensaje desde espectaculo";
            /* ----------------- */


            EspectaculosEN espEN = new EspectaculosEN();
            CriticasEN criEn = new CriticasEN();

            try
            {
                datosEsp = espEN.ObtenerEspectaculoPorID(id);
                datosCrit = criEn.getCriticasEspectaculo(id);
            }
            catch
            {
                Response.StatusCode = 404;
            }   
        }

        protected void nuevaCritica_Click(object sender, EventArgs e)
        {
            //CriticasEN criEN = new CriticasEN();
            //criEN.Insertar(Session["IdUsuario"], tbTituloCritica.Text, tbTextoCritica.Text);
            CriticasEN criEn = new CriticasEN();
            try
            {
                criEn.Insertar(Session["IdUsuario"].ToString(), Request.QueryString["ild"], tbTituloCritica.Text, tbTextoCritica.Text);
                Response.Redirect(Request.RawUrl);
            }
            catch (Exception ex) {
                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 0;
                Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                lbTitle.Text = "Ocurrió un error";
                lbMsg.Text = "Ocurrió un error al publicar la crítica.";
            }
        }
    }
}