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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public byte[] bImage = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DataSet datosEsp = null;
            EspectaculosEN espEN = new EspectaculosEN();

            try
            {
                datosEsp = espEN.ObtenerEspectaculoPorID(id);
                System.Data.DataRow espectaculo = datosEsp.Tables[0].Rows[0];
                if (espectaculo["Cartel"] != System.DBNull.Value)
                {
                    bImage = (byte[])espectaculo["Cartel"];
                }
                else
                {
                    string direccion = Server.MapPath("../img/layout/eventImage_default.png");
                    System.Drawing.Image im = System.Drawing.Image.FromFile(direccion); ;

                    MemoryStream tmpStream = new MemoryStream();
                    im.Save(tmpStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    tmpStream.Position = 0;
                    bImage = new byte[tmpStream.Length];
                    tmpStream.Read(bImage, 0, System.Convert.ToInt32(tmpStream.Length));
                    bImage = tmpStream.ToArray();
                }
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