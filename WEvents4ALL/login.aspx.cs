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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Usuario(object sender, EventArgs e)
        {

            /*nick, pass*/
            ClientesEN cliEN = new ClientesEN();
            DataSet ds = cliEN.ExisteUsuarioNickPass(tbLoginUser.Text, tbLoginPass.Text);

            try
            {
                DataRow usuario = ds.Tables[0].Rows[0];
                Session.Clear();
                Session["IdUsuario"] = usuario["idCliente"].ToString();
                Session["NickUsuario"] = usuario["Usuario"].ToString();
                Session["RolUsuario"] = "user";
                Response.Redirect("index.aspx");
            }
            catch (Exception ex)
            {
                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 0;
                Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                lbTitle.Text = "Ocurrió un error";
                lbMsg.Text = "El usuario o la contraseña introducida no son validas.";
            }
        }
    }
}