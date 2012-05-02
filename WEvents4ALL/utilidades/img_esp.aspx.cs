using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;

namespace WEvents4ALL.utilidades
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public byte[] bImage = new byte[0];
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DataSet datosEsp = null;
            EspectaculosEN espEN = new EspectaculosEN();

            try
            {
                datosEsp = espEN.ObtenerEspectaculoPorID(id);
                System.Data.DataRow espectaculo = datosEsp.Tables[0].Rows[0];
                bImage = (byte[])espectaculo["Cartel"];

                Response.ContentType = "image/png";
                Response.BinaryWrite(bImage);
            }
            catch
            {
                Response.StatusCode = 404;
            }  
        }
    }
}