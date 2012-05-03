using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Entities;
using System.Web.UI.WebControls;

namespace WEvents4ALL
{
    public partial class contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EventoClick(Object sender, EventArgs e)
        {
            try
            {
                string tipo = contacto_DropDownList1.SelectedValue.ToString();
                string texto = TextArea1.Value.ToString();
                MensajesEN mensaje = new MensajesEN();
                mensaje.insertMessageEn(tipo,texto);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }

    }
}