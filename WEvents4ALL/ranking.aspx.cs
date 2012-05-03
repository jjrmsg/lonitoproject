using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using System.Data;
using System.Web.UI.WebControls;

namespace WEvents4ALL
{

    public partial class ranking : System.Web.UI.Page
    {
        public DataSet resultado = new DataSet();
        public VentasEN vent = new VentasEN();

        public void Page_Load(object sender, EventArgs e)
        {
            string tipo = Request.QueryString["tipo"];
            if (tipo != "Concierto" && tipo!="Teatro")
                tipo = "Cine";
            resultado = vent.ObtenerRankingTipo(tipo);
        }

    }
}