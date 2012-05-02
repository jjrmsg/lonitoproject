using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEvents4ALL
{
    public partial class espectaculo : System.Web.UI.Page
    {
        public string gato = "gagagato";
        protected void Page_Load(object sender, EventArgs e)
        {
            gato = "pollo";
        }
    }
}