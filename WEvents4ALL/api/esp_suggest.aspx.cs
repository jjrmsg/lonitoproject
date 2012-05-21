using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using System.Data;
using System.Web.Script.Serialization;

namespace WEvents4ALL.api
{
    public partial class esp_suggest : System.Web.UI.Page
    {
        public string sJson = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            EspectaculosEN espectaculoEN = new EspectaculosEN();

            try
            {
                // Buscamos espectaculos que coincidan con el texto indicado
                string texto = Request.QueryString["texto"];
                DataSet espectaculos = espectaculoEN.Buscar(texto, "", "", "", "", "", "");
                int numResults = espectaculos.Tables[0].Rows.Count;
                int numSuggest = 8;
                if (numResults < numSuggest)
                {
                    numSuggest = espectaculos.Tables[0].Rows.Count;
                }
                object[] resultados = new object[numSuggest];
                // Limitamos las sugerencias a 10 y añadimos al array de resultados
                for (int i = 0; i < 10 && i < numSuggest; i++)
                {
                    DataRow r = espectaculos.Tables[0].Rows[i];
                    Dictionary<string, object> resData = new Dictionary<string, object>();
                    resData.Add("id", r["Id"].ToString());
                    resData.Add("titulo", r["Titulo"].ToString());
                    resData.Add("tipo", r["Tipo"].ToString());
                    resultados.SetValue(resData, i);
                }

                // Mostramos en formato json
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                sJson = serializer.Serialize(resultados);
            }
            catch (Exception ex)
            {
                sJson = "error";
            }
        }
    }
}