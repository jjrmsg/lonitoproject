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
            try
            {
                datosEsp = espEN.ObtenerEspectaculoPorID(id);
            }
            catch
            {
                Response.StatusCode = 404;
            }   
        }
    }
}