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