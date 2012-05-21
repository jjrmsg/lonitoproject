using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;

namespace WEvents4ALL.api
{
    public partial class eps_vote : System.Web.UI.Page
    {
        public string sJson = "";
        // Realiza una votacion de un usuario a un espectaculo
        protected void Page_Load(object sender, EventArgs e)
        {
            VotosEN votEn = new VotosEN();

            try
            {
                if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
                {
                    // Comprovamos que en el valor del voto sea correcto
                    int nota = Convert.ToInt32(Request.QueryString["nota"]);
                    if (nota > 0 && nota < 6)
                    {
                        string idEsp = Request.QueryString["esp"];
                        // Efectuamos el voto
                        if (votEn.setVoto(Session["IdUsuario"].ToString(), idEsp, nota))
                        {
                            sJson = "ok";
                        }
                    }
                    else
                    {
                        sJson = "La nota debe ser entre 1 y 5";
                    }
                }
                else
                    sJson = "El usuario debe estar logueado";
            }
            catch (Exception ex)
            {
                sJson = "error";
            }
        }
    }
}