using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using Entities;
using System.Data;

namespace WEvents4ALL.api
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string sJson = "";
        protected void Page_Load(object sender, EventArgs e)
        {            
            SalasEN salaEn = new SalasEN();
            DataSet salaRecuperar = new DataSet();

            try
            {
                string idSalaIN = Request.QueryString["id"];
                salaRecuperar = salaEn.RecuperarSala(idSalaIN);
                int nSecciones = Convert.ToInt16(salaRecuperar.Tables[0].Rows[0][3].ToString());

                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict.Add("idSala", idSalaIN);
                dict.Add("numSecciones", nSecciones);

                object[] secciones = new object[nSecciones];

                for (int i = 0; i < nSecciones; i++)
                {
                    Dictionary<string, object> seccData = new Dictionary<string, object>();
                    seccData.Add("filas", salaRecuperar.Tables[0].Rows[i][6].ToString());
                    seccData.Add("columnas", salaRecuperar.Tables[0].Rows[i][7].ToString());

                    secciones.SetValue(seccData, i);
                }
                dict.Add("secciones", secciones);

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                sJson = serializer.Serialize((object)dict);


            }
            catch (Exception ex)
            {
                sJson = "error";
            }
        }
    }
}