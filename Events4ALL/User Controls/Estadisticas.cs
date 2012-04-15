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
        //private ClientesEN cliEN;
        private Dictionary<string, decimal> diasVentas;
        private Dictionary<string, int> numerosMeses;
        private Dictionary<string, int> tipoVentas;
        private Dictionary<string, int> generoVentas;
        private Dictionary<string, int> tipos;
        private Dictionary<string, int> generos;
        #endregion

        public Estadisticas()
        {
            InitializeComponent();
            //cliEN = new ClientesEN();
            vEN = new VentasEN();
            espEN = new EspectaculosEN();
            diasVentas = new Dictionary<string, decimal>();
            tipoVentas = new Dictionary<string, int>();
            generoVentas = new Dictionary<string, int>();
            tipos = new Dictionary<string, int>() { {"Teatro", 1}, {"Cine", 2}, {"Concierto", 3} };
            generos = new Dictionary<string, int>() { { "Aventura", 1 }, { "Romantica", 2 }, { "Comedia", 3 }, { "Accion", 4 }, { "Terror", 5 } };

            numerosMeses = new Dictionary<string, int>()
            {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4}, {"Mayo", 5}, {"Junio", 6},
                {"julio", 7}, {"Agosto", 8}, {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            };

            comboMes.Text = "Junio";
            LoadEspectaculos();
            LoadRanking();
        }

        private void LoadEspectaculos()
        {
            DataSet espec = new DataSet();
            espec = espEN.ObtenerEspectaculos();

            try
            {

                foreach (DataRow r in espec.Tables[0].Rows)
                {
                    comboTitulo.Items.Add(r["Titulo"].ToString());
                }
            }
            catch
            {
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            mainChart.Series["Euros"].Points.Clear();
            tipoChart.Series["Tipo"].Points.Clear();
            generoChart.Series["Genero"].Points.Clear();
            diasVentas.Clear();
            tipoVentas.Clear();
            generoVentas.Clear();
            
            ValidaDatos();
        }

        private void ValidaDatos()
        {
            if (!string.IsNullOrWhiteSpace(textAnyo.Text))
            {
                if (comboMes.SelectedIndex != -1)
                {
                    errorMes.Clear();
                    errorAnyo.Clear();
                    ObtenerDatosGeneral();
                    ObtenerDatosTipo();
                    ObtenerDatosGenero();
                }
                else
                {
                    errorMes.SetError(comboMes, "Debes seleccionar un mes");
                }
            }
            else
            {
                errorAnyo.SetError(textAnyo, "Debes seleccionar un año");
            }
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
            string anyo = "0";
            string mes = "0";
            string dia = "0";
            foreach (DataRow row in dsVentas.Tables[0].Rows)
            {
                DateTime dt = (DateTime)row["FechaVenta"];
                anyo = dt.Year.ToString();
                mes = dt.Month.ToString();
                dia = dt.Day.ToString();
                string tipo = row["tipo"].ToString();

                if (anyo == textAnyo.Text && mes == numerosMeses[comboMes.SelectedItem.ToString()].ToString())
                {
                    if (tipoVentas.ContainsKey(tipo))
                    {
                        tipoVentas[tipo] = tipoVentas[tipo] + 1;
                    }
                    else
                    {
                        tipoVentas.Add(tipo, 1);
                    }
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
            DataSet dsVentas;

            dsVentas = vEN.getAllEspectaculos();
            string anyo = "0";
            string mes = "0";
            string dia = "0";
            foreach (DataRow row in dsVentas.Tables[0].Rows)
            {
                DateTime dt = (DateTime)row["FechaVenta"];
                anyo = dt.Year.ToString();
                mes = dt.Month.ToString();
                dia = dt.Day.ToString();
                string genero = row["Genero"].ToString();
                genero = genero.Replace("  ", string.Empty);
                
                if (anyo == textAnyo.Text && mes == numerosMeses[comboMes.SelectedItem.ToString()].ToString() && !string.IsNullOrEmpty(genero))
                {
                    
                    if (generoVentas.ContainsKey(genero))
                    {
                        generoVentas[genero] = generoVentas[genero] + 1;
                    }
                    else
                    {
                        generoVentas.Add(genero, 1);
                    }
                }
            }

            foreach (var pair in generoVentas)
            {
                DataPoint p = new DataPoint(generos[pair.Key], (int)pair.Value);
                p.Label = pair.Key;
                generoChart.Series["Genero"].Points.Add(p);
            }
        }

        private void loadButton2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textNIF.Text))
            {
                generoChartCli.Series["Genero"].Points.Clear();
                tipoChartCli.Series["Tipo"].Points.Clear();
                diasVentas.Clear();
                tipoVentas.Clear();
                generoVentas.Clear();

                ObtenerDatosCliente();
                ObtenerDatosCliGenerales();
                ObtenerGeneroPref();
                ObtenerTipoPref();
            }
        }

        private void ObtenerDatosCliente()
        {
            /*DataSet ds = new DataSet();
            ds = cliEN.getClientByNIF();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                labelNombre.Text = row["Nombre"].ToString();
                labelApellidos.Text = row["Apellidos"].ToString();
                labelCiudad.Text = row["Poblacion"].ToString();
            }*/
        }

        private void ObtenerDatosCliGenerales()
        {
            DataSet ds = new DataSet();
            ds = vEN.getEstadisticasCliente(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                decimal d = (decimal)row["Dinero"];
                labelDinero.Text = Math.Round(d, 2)+" €";
                labelEntradas.Text = row["Entradas"].ToString();
            }

            ds = vEN.getEspectaculosCliente(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                labelEspec.Text = row["Espectaculos"].ToString();
            }
        }

        private void ObtenerGeneroPref()
        {
            DataSet ds;

            ds = vEN.getGeneroTipoCli(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string genero = row["Genero"].ToString();
                genero = genero.Replace("  ", string.Empty);

                if (!string.IsNullOrEmpty(genero))
                {
                    if (generoVentas.ContainsKey(genero))
                    {
                        generoVentas[genero] = generoVentas[genero] + 1;
                    }
                    else
                    {
                        generoVentas.Add(genero, 1);
                    }
                }
            }

            foreach (var pair in generoVentas)
            {
                DataPoint p = new DataPoint(generos[pair.Key], (int)pair.Value);
                p.Label = pair.Key;
                generoChartCli.Series["Genero"].Points.Add(p);
            }
        }

        private void ObtenerTipoPref()
        {
            DataSet ds;

            ds = vEN.getGeneroTipoCli(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
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
                tipoChartCli.Series["Tipo"].Points.Add(p);
            }
        }

        private void comboTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTitulo.Items[comboTitulo.SelectedIndex].ToString() != "Espectáculo")
            {
                ObtenerDatosEspectaculo(comboTitulo.Items[comboTitulo.SelectedIndex].ToString());
                ObtenerEstadisticasEspectaculo(comboTitulo.Items[comboTitulo.SelectedIndex].ToString());
                LoadRanking();
            }
        }

        private void ObtenerEstadisticasEspectaculo(string titulo)
        {

            DataSet ds = new DataSet();
            ds = vEN.getVentasEspectaculo(titulo);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                decimal d = (decimal)r["Recaudacion"];
                labelRecaudacion.Text = Math.Round(d, 2)+" €";
                labelVendidas.Text = r["Entradas"].ToString();
            }
        }

        private void ObtenerDatosEspectaculo(string titulo)
        {
            DataSet ds = new DataSet();
            ds = espEN.ObtenerDatosEspectaculo(titulo);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                labelID.Text = r["IDEspectaculo"].ToString();
                labelTipo.Text = r["Tipo"].ToString();
                if (labelTipo.Text == "Cine")
                {
                    labelGenero.Text = r["Genero"].ToString();
                }
                else
                {
                    labelGenero.Text = "NA";
                }
            }

            ds = vEN.ObtenerRanking('d');
            int i=1;

            foreach(DataRow r in ds.Tables[0].Rows)
            {
                if (r["Titulo"].ToString().Equals(titulo))
                {
                    labelRanking.Text = i.ToString()+"º";
                    break;
                }
                i++;
            }
        }

        private void LoadRanking()
        {
            DataSet ds = null;
            ds = vEN.ObtenerRanking('d');
            int numEspectaculos = comboTitulo.Items.Count;

            chartRanking.Series[0]["PieLabelStyle"] = "Disabled";
            chartRanking.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartRanking.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chartRanking.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartRanking.ChartAreas[0].AxisY.MinorGrid.Enabled = false;


            try
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    DataPoint p = new DataPoint(numEspectaculos, (int)r["Entradas"]);
                    p.Label = r["Titulo"].ToString();
                    if (comboTitulo.SelectedIndex != -1)
                    {
                        if (p.Label == comboTitulo.Items[comboTitulo.SelectedIndex].ToString())
                        {
                            p.Color = Color.YellowGreen;
                        }
                    }
                    chartRanking.Series["Entradas"].Points.Add(p);
                    numEspectaculos--;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
