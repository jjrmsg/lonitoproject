using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Collections;
using Entities;

namespace WEvents4ALL.api
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string sJson = "ok";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IdUsuario"] != null && Session["IdUsuario"] != "")
            {
                try
                {
                    string accion = Request.QueryString["accion"].ToString();
                    string asientoVentIN = Request.QueryString["asiento"].ToString();
                    string horaVentIN = Request.QueryString["hora"].ToString();
                    string espVentIN = Request.QueryString["esp"].ToString();
                    string fechaVentIN = Request.QueryString["fecha"].ToString();

                    // Recuperamos la lista de ventas del usuario
                    ArrayList ventasUser = null;
                    if (Session["VentasUser"] != null)
                    {
                        ventasUser = (ArrayList)Session["VentasUser"];
                    }
                    else
                        ventasUser = new ArrayList();

                    Dictionary<string, object> ventData = new Dictionary<string, object>();

                    if (accion == "add")
                    {
                        // Creamos el diccionario que contiene los datos que mostraremos en JSON

                        VentasEN ventEN = new VentasEN();
                        EspectaculosEN espEN = new EspectaculosEN();


                        // Comprobamos si la venta existe en la BD
                        if (ventEN.ExisteVenta(espVentIN, asientoVentIN, horaVentIN, fechaVentIN))
                        {
                            ventData.Add("result", "ocupada");
                        }
                        else
                        {
                            // Si no existe comprobamos si el usuario no la ha añadido ya
                            bool existe = false;
                            foreach (Dictionary<string, string> venta in ventasUser)
                            {
                                if (venta["asiento"] == asientoVentIN &&
                                    venta["espectaculo"] == espVentIN &&
                                    venta["fecha"] == fechaVentIN &&
                                    venta["hora"] == horaVentIN)
                                    existe = true;
                            }

                            if (existe == false)
                            {
                                ventData.Add("result", "ok");
                                Dictionary<string, string> ventaNuevaData = new Dictionary<string, string>();
                                ventaNuevaData.Add("asiento", asientoVentIN);
                                ventaNuevaData.Add("hora", horaVentIN);
                                ventaNuevaData.Add("espectaculo", espVentIN);
                                ventaNuevaData.Add("fecha", fechaVentIN);
                                int precio = Convert.ToInt32(espEN.getPrecioId(Convert.ToInt32(espVentIN)));
                                ventaNuevaData.Add("precio", precio.ToString());
                                ventasUser.Add(ventaNuevaData);
                            }
                            else
                                ventData.Add("result", "reservadaMismoUser");
                        }
                    }
                    else if (accion == "remove")
                    {
                        bool eliminada = false;
                        foreach (Dictionary<string, string> venta in ventasUser)
                        {
                            if (venta["asiento"] == asientoVentIN &&
                                    venta["espectaculo"] == espVentIN &&
                                    venta["fecha"] == fechaVentIN &&
                                    venta["hora"] == horaVentIN)
                            {
                                ventasUser.Remove(venta);
                                eliminada = true;
                                break;
                            }

                        }

                        if (eliminada == true)
                            ventData.Add("result", "eliminada");
                        else
                            ventData.Add("result", "noeliminada");
                    }

                    Session["VentasUser"] = ventasUser;

                    object[] ventas = new object[ventasUser.Count];
                    int contVentas = 0;
                    foreach (object venta in ventasUser)
                    {
                        ventas.SetValue(venta, contVentas);
                        contVentas++;
                    }
                    ventData.Add("ventas", ventas);


                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    sJson = serializer.Serialize((object)ventData);
                    Response.Write(sJson);
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }

            }
            else
            {
                sJson = "NoLogin";
            }
        }
    }
}