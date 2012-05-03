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

    public partial class index : System.Web.UI.Page
    {
        public EspectaculosEN esEN = new EspectaculosEN();
        public DataSet esp = new DataSet();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            esp = esEN.ObtenerEspectaculos();
        }
    }
}