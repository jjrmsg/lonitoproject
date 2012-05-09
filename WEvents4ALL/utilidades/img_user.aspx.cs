using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entities;
using System.IO;

namespace WEvents4ALL.utilidades
{
    public partial class img_user : System.Web.UI.Page
    {
        public byte[] bImage = new byte[0];
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DataSet datosUser = null;
            ClientesEN cliEN = new ClientesEN();

            try
            {
                datosUser = cliEN.ObtenerUsuarioPorID(id);
                System.Data.DataRow usuario = datosUser.Tables[0].Rows[0];
                bImage = (byte[])usuario["Foto"];

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