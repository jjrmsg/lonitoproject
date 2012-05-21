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
    public partial class acercade : System.Web.UI.Page
    {

        public SalasEN sEN = new SalasEN();
        public DataSet salas = new DataSet();
        public int aforo1 = 0;
        public int aforo2 = 0;
        public int aforo3 = 0;
        public int aforo4 = 0;
        public int[] aforo = new int[100];

        protected void Page_Load(object sender, EventArgs e)
        {
            // Marcamos en la barra de enlaces que estamos en acerca de
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 4;

            int i=1;
            salas = sEN.getSalas();
            foreach (DataRow r in salas.Tables[0].Rows)
            {
                aforo[i] = (int)r["Aforo"];
                i++;
            }
        }
        
    }
}