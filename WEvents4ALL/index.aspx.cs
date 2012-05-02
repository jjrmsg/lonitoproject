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
        EspectaculosEN esEN = new EspectaculosEN();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet d = new DataSet();
            d = esEN.ObtenerDatosEspectaculo("El lago de los cisnes");


                foreach (DataRow da in d.Tables[0].Rows)
                {
                    Application["Peli"] = da["IDEspectaculo"].ToString();
                }

        }
    }
}