using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entities;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WEvents4ALL
{
    public partial class busquedaAvanzada : System.Web.UI.Page
    {
        public string fechahoy;
        
        public EspectaculosEN esEN = new EspectaculosEN();
        public DataSet resultado = null;
        public string cadena="";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Marcamos en la barra de enlaces que estamos en busqueda
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 6;

            fechahoy =DateTime.Now.ToShortTimeString();
            string fechai = fechaini.Value.ToString();
            string fechaf = fechafin.Value.ToString();


            if(Request.QueryString.Count==4)
            {

                    resultado = new DataSet();

                    resultado = esEN.ObtenerEspectaculoBuscAv(Request.QueryString["tipo"], Request.QueryString["fechaini"], Request.QueryString["fechafin"], Request.QueryString["texto"]);
                        
            }
            else if(Request.QueryString.Count==1)
            {
                resultado = esEN.ObtenerEspectaculoBuscAv("", fechai, fechaf, Request.QueryString["texto"]);
            }

        }

        protected void EventoClick_bus_av(Object sender, EventArgs e)
        {

            cadena = "/busqueda.aspx?texto="+TextBox1.Text+"&tipo="+DropDownList1.Text+"&fechaini="+fechaini.Value+"&fechafin="+fechafin.Value;
            Response.Redirect(cadena);
            
        }
    }
}