using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Entities;
using System.Data;

namespace WEvents4ALL
{
    public partial class ventas : System.Web.UI.Page
    {
        public ArrayList listado = new ArrayList();
        public int mode = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            // No marcamos nada en la barra de enlaces
            MultiView mvLinks = (MultiView)Master.FindControl("LinksAcceso");
            mvLinks.ActiveViewIndex = 0;

            if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
            {
                try
                {
                    ArrayList ventasUser = null;
                    if (Session["VentasUser"] != null)
                    {
                        ventasUser = (ArrayList)Session["VentasUser"];
                    }

                    ArrayList idEspectaculos = new ArrayList();
                    foreach (Dictionary<string, string> venta in ventasUser)
                    {
                        idEspectaculos.Add(venta["espectaculo"]);
                    }
                    EspectaculosEN espEN = new EspectaculosEN();
                    DataSet espectaculos = espEN.getEspectaculosListaID(idEspectaculos);

                    foreach (DataRow espectaculo in espectaculos.Tables[0].Rows)
                    {
                        Dictionary<string, object> datosEsp = new Dictionary<string, object>();
                        datosEsp.Add("titulo", espectaculo["Titulo"].ToString());
                        datosEsp.Add("id", espectaculo["Id"].ToString());

                        ArrayList preventas = new ArrayList();
                        foreach (Dictionary<string, string> venta in ventasUser)
                        {
                            if (venta["espectaculo"] == espectaculo["Id"].ToString())
                            {
                                Dictionary<string, string> ventasEsp = new Dictionary<string, string>();
                                ventasEsp.Add("asiento", venta["asiento"]);
                                ventasEsp.Add("precio", venta["precio"]);
                                ventasEsp.Add("hora", venta["hora"]);
                                ventasEsp.Add("fecha", venta["fecha"]);
                                preventas.Add(ventasEsp);

                            }
                        }
                        datosEsp.Add("preventas", preventas);
                        listado.Add(datosEsp);
                    }
                }
                catch
                {
                    MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                    mv.ActiveViewIndex = 0;
                    Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                    Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                    lbTitle.Text = "No se pudieron mostrar el listado de asientos";
                    lbMsg.Text = "No se pudieron mostrar los asientos seleccionados, asegurese de añadir algún asiento desde la ficha del espectáculo antes de llegar a esta página.";
                    mode = 1;
                }
            }
            else
                Response.Redirect("index.aspx");
        }

        protected void terminarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                VentasEN ventEN = new VentasEN();
                foreach (Dictionary<string, object> espectaculo in listado)
                {
                    foreach (Dictionary<string, string> pventa in (ArrayList)espectaculo["preventas"])
                    {
                        ventEN.Insertar(espectaculo["id"].ToString(), Session["IdUsuario"].ToString(), pventa["fecha"], pventa["hora"], pventa["asiento"], pventa["precio"]);
                     }                  
                }
                ArrayList vacio = new ArrayList();
                Session["VentasUser"] = vacio;

                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 1;
                Label lbTitle = (Label)Master.FindControl("successViewTitle");
                Label lbMsg = (Label)Master.FindControl("successViewMsg");
                lbTitle.Text = "Compra completada";
                lbMsg.Text = "Las venta se ha completado con exito, recuerde llevar su NIF cuando recoja las entradas en taquilla.";
                mode = 2;
            }
            catch 
            {
                MultiView mv = (MultiView)Master.FindControl("MultiViewAlerts");
                mv.ActiveViewIndex = 0;
                Label lbTitle = (Label)Master.FindControl("errorViewTitle");
                Label lbMsg = (Label)Master.FindControl("errorViewMsg");
                lbTitle.Text = "Ocurrió un error";
                lbMsg.Text = "No se pudieron llevas a cabo todas las ventas.";
                mode = 3;
            }          
        }
    }
}