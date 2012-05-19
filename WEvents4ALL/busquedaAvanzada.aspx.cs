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
            Application["fechahoy"]=fechahoy;
        }

        protected void EventoClick_bus_av(Object sender, EventArgs e)
        {
            resultado = new DataSet();
            resultado = esEN.ObtenerEspectaculoBuscAv(DropDownList1.Text, "", "", TextBox1.Text);
        }
    }
}