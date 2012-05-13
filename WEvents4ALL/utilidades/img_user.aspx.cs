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
        public byte[] bImage = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DataSet datosUser = null;
            ClientesEN cliEN = new ClientesEN();

            try
            {
                datosUser = cliEN.ObtenerUsuarioPorID(id);
                System.Data.DataRow usuario = datosUser.Tables[0].Rows[0];
                if (usuario["Foto"] != System.DBNull.Value)
                {
                    bImage = (byte[])usuario["Foto"];
                }
                else
                {
                    string direccion = Server.MapPath("../img/layout/user_default.jpg");
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