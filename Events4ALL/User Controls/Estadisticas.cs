﻿using System;
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

namespace Events4ALL
{
    public partial class Estadisticas : UserControl
    {

        #region Members
        private VentasEN vEN;
        private EspectaculosEN espEN;
        private Dictionary<string, decimal> diasVentas;
        private Dictionary<string, int> numerosMeses;
        #endregion

        public Estadisticas()
        {
            InitializeComponent();
            vEN = new VentasEN();
            espEN = new EspectaculosEN();
            diasVentas = new Dictionary<string, decimal>();
            numerosMeses = new Dictionary<string, int>()
            {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4}, {"Mayo", 5}, {"Junio", 6},
                {"julio", 7}, {"Agosto", 8}, {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            };
        }

        private void ValidaDatos()
        {
            bool valido = false;

            if (textAnyo.Text != "")
            {
                errorAnyo.SetError(textAnyo, "");
                if (comboMes.SelectedItem != null)
                {
                    errorMes.SetError(comboMes, "");
                    valido = true;
                }
                else
                {
                    errorMes.SetError(comboMes, "Debes seleccionar un mes");
                    valido = false;
                }
            }
            else
            {
                errorAnyo.SetError(textAnyo, "Debes seleccionar un año");
                valido = false;
            }

            if (valido)
            {
                ObtenerDatosGeneral();
            }
           /* if (System.Text.RegularExpressions.Regex.IsMatch("^(19|20)d{2}$", textAnyo.Text))
            {
                errorAnyo.SetError(textAnyo, "Solo números de longitud 4");
                textAnyo.Text="";
            }*/
        }

        private void comboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaDatos();
        }

        private void textAnyo_TextChanged(object sender, EventArgs e)
        {
            ValidaDatos();
        }

        private void textAnyo_Leave(object sender, EventArgs e)
        {
            ValidaDatos();
        }

        private void comboMes_TextChanged(object sender, EventArgs e)
        {
            ValidaDatos();
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
                    MessageBox.Show(dia + " " + precio);
                }
            }
        }
    }
}
