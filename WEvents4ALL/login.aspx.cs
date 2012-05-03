using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEvents4ALL
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Usuario(object sender, EventArgs e)
        {
            if (tbLoginUser.Text == "neo" && tbLoginPass.Text == "gato")
            {
                Session["IdUsuario"] = "1";
                Session["NickUsuario"] = tbLoginUser.Text;
                Session["RolUsuario"] = "user";
                Response.Redirect("index.aspx");
            }
            else
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