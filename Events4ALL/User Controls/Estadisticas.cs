using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Events4ALL.Auxiliares;
using Events4ALL.EN;
using Events4ALL.User_Controls;
using System.Windows.Forms.DataVisualization.Charting;

namespace Events4ALL
{
    public partial class Estadisticas : UserControl
    {

        #region Members
        private VentasEN vEN;
        private EspectaculosEN espEN;
        private Dictionary<string, decimal> diasVentas;
        private Dictionary<string, int> numerosMeses;
        private Dictionary<string, int> tipoVentas;
        private Dictionary<string, int> tipos;
        #endregion

        public Estadisticas()
        {
            InitializeComponent();
            vEN = new VentasEN();
            espEN = new EspectaculosEN();
            diasVentas = new Dictionary<string, decimal>();
            tipoVentas = new Dictionary<string, int>();
            tipos = new Dictionary<string, int>() { {"Teatro", 1}, {"Cine", 2}, {"Concierto", 3} };

            numerosMeses = new Dictionary<string, int>()
            {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4}, {"Mayo", 5}, {"Junio", 6},
                {"julio", 7}, {"Agosto", 8}, {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            };

            comboMes.Text = "Junio";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            ValidaDatos();
        }

        private void ValidaDatos()
        {
            ObtenerDatosGeneral();
            ObtenerDatosTipo();
            ObtenerDatosGenero();
        }

        private void ObtenerDatosGeneral()
        {
            DataSet dsVentas;

            dsVentas = vEN.getAllEspectaculos();
            string anyo="0";
            string mes="0";
            string dia = "0";
            foreach (DataRow row in dsVentas.Tables[0].Rows)
            {
                int id = (int) row["IDEspectaculo"];
                DateTime dt = (DateTime)row["FechaVenta"];
                anyo = dt.Year.ToString();
                mes = dt.Month.ToString();
                dia = dt.Day.ToString();

                if (anyo == textAnyo.Text && mes == numerosMeses[comboMes.SelectedItem.ToString()].ToString())
                {
                    decimal precio = 0;
                    espEN.idEspectaculo = id;
                    precio = espEN.getPrecioId();
                    
                    if (diasVentas.ContainsKey(dia))
                    {
                        diasVentas[dia] = diasVentas[dia] + precio;
                    }
                    else
                    {
                        diasVentas.Add(dia, precio);
                    }
                }
            }

            foreach (var pair in diasVentas)
            {
                DataPoint p = new DataPoint(int.Parse(pair.Key), (int)pair.Value);
                mainChart.Series["Euros"].Points.Add(p);
            }
        }

        private void ObtenerDatosTipo()
        {
            DataSet dsVentas;

            dsVentas = vEN.getAllEspectaculos();
            foreach (DataRow row in dsVentas.Tables[0].Rows)
            {
                string tipo = row["tipo"].ToString();

                if (tipoVentas.ContainsKey(tipo))
                {
                    tipoVentas[tipo] = tipoVentas[tipo] + 1;
                }
                else
                {
                    tipoVentas.Add(tipo, 1);
                }
            }

            foreach (var pair in tipoVentas)
            {

                DataPoint p = new DataPoint(tipos[pair.Key], (int)pair.Value);
                p.Label = pair.Key;
                tipoChart.Series["Tipo"].Points.Add(p);
            }
        }

        private void ObtenerDatosGenero()
        {
        }
    }
}
