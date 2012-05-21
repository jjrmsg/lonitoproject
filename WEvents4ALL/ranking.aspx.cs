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
        public VotosEN vot = new VotosEN();
       

        public void Page_Load(object sender, EventArgs e)
        {
            // Marcamos en la barra de enlaces que estamos en reanking
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 3;

            string tipo = Request.QueryString["tipo"];
            if (tipo != "Concierto" && tipo!="Teatro")
                tipo = "Cine";
            resultado = vot.SacarVotosEn(tipo);
        }

    }
}