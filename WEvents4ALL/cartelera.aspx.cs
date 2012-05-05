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
    public partial class cartelera : System.Web.UI.Page
    {
        public EspectaculosEN esEN = new EspectaculosEN();
        public DataSet resultado = new DataSet();
        public EspectaculosEN esp = new EspectaculosEN();

        protected void Page_Load(object sender, EventArgs e)
        {
            string tipo = Request.QueryString["tipo"];
            if (tipo != "Concierto" && tipo != "Teatro")
            {
                tipo = "Cine";
            }
            resultado = esp.ObtenerEspectaculoPorTipo(tipo);
        }
    }
}