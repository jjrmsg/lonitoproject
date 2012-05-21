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
        public int puntUser = 3; 
        protected void Page_Load(object sender, EventArgs e)
        {
            // No marcamos nada en la barra de enlaces
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 0;

            string id = Request.QueryString["id"];

            EspectaculosEN espEN = new EspectaculosEN();
            CriticasEN criEN = new CriticasEN();
            ClientesEN cliEN = new ClientesEN();

            try
            {
                datosEsp = espEN.ObtenerEspectaculoPorID(id);
                datosCrit = criEN.getCriticasEspectaculo(id);
                puntUser = cliEN.getPuntuacionEsp("3", id);

                // Carga los horarios del espectaculo en la lista de la venta
                string[] listahorarios = datosEsp.Tables[0].Rows[0]["Horarios"].ToString().Split(',');
                foreach(string h in listahorarios)
                    DropDownHorarios.Items.Add(h);


                List<DateTime> rv = new List<DateTime>();
                DateTime tmpDate = Convert.ToDateTime(datosEsp.Tables[0].Rows[0]["FechaIni"].ToString());
                DateTime EndingDate = Convert.ToDateTime(datosEsp.Tables[0].Rows[0]["FechaFin"].ToString());
                while (tmpDate <= EndingDate)
                {
                    DropDownFechas.Items.Add(tmpDate.ToShortDateString());
                    tmpDate = tmpDate.AddDays(1);
                } 

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
            bool error = false;
            string errorMsg = "Ocurrió un error al publicar la crítica.";
            try
            {
                if (tbTituloCritica.Text != "" && tbTextoCritica.Text != "")
                {
                    criEn.Insertar(Session["IdUsuario"].ToString(), Request.QueryString["id"], tbTituloCritica.Text, tbTextoCritica.Text);
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    error = true;
                    errorMsg = "No puede dejar ninguno de los campos vacios";
                }
            }
            catch (Exception ex)
            {
                error = true;
            }
            finally
            {
                if (error == true)
                {
                    MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                    mv.ActiveViewIndex = 0;
                    Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                    Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                    lbTitle.Text = "Ocurrió un error";
                    lbMsg.Text = errorMsg;
                }
            }
        }

        protected void confirmCompraButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ventas.aspx");
        }
    }
}