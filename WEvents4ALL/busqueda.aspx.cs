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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            fechahoy =DateTime.Now.ToShortTimeString();
            if (Request.QueryString["texto"] != "")
            {
                resultado = new DataSet();
                string fechai = fechaini.Value.ToString();
                string fechaf = fechafin.Value.ToString();
                resultado = esEN.ObtenerEspectaculoBuscAv(DropDownList1.Text, fechai, fechaf,  Request.QueryString["texto"]);
                TextBox1.Text = Request.QueryString["texto"];
            }

        }

        protected void EventoClick_bus_av(Object sender, EventArgs e)
        {
            resultado = new DataSet();
            string fechai = fechaini.Value.ToString();
            string fechaf = fechafin.Value.ToString();

            resultado = esEN.ObtenerEspectaculoBuscAv(DropDownList1.Text, fechai,fechaf, TextBox1.Text);
        }
    }
}