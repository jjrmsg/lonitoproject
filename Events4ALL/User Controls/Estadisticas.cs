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
        private ClientesEN cliEN;
        private Dictionary<string, decimal> diasVentas;
        private Dictionary<string, int> numerosMeses;
        private Dictionary<int, decimal> espectaculos;
        private Dictionary<string, int> tipoVentas;
        private Dictionary<string, int> generoVentas;
        private Dictionary<string, int> tipos;
        private Dictionary<string, int> generos;
        #endregion

        public Estadisticas()
        {
            InitializeComponent();
            cliEN = new ClientesEN();
            vEN = new VentasEN();
            espEN = new EspectaculosEN();
            diasVentas = new Dictionary<string, decimal>();
            tipoVentas = new Dictionary<string, int>();
            espectaculos = new Dictionary<int, decimal>();
            generoVentas = new Dictionary<string, int>();
            tipos = new Dictionary<string, int>() { {"Teatro", 1}, {"Cine", 2}, {"Concierto", 3} };
            generos = new Dictionary<string, int>() { { "Aventura", 1 }, { "Romántica", 2 }, { "Comedia", 3 }, { "Acción", 4 }, { "Terror", 5 } };

            numerosMeses = new Dictionary<string, int>()
            {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4}, {"Mayo", 5}, {"Junio", 6},
                {"Julio", 7}, {"Agosto", 8}, {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            };

            comboMes.Text = "Junio";
            LoadEspectaculos();
            LoadRanking();
        }

        //Carga en el combobox todos los espectaculos 
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Realiza la llamada a todos los metodos que se encargan de obtener los datos de la pestaña General
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

        //Realiza la validación de los datos introducidos en la pestaña General
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

        //Obtiene los datos para generar el gráfico de Recaudación de la pestaña General
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
                    precio = (decimal)row["Importe"];
                    
                    if (diasVentas.ContainsKey(dia))
                    {
                        diasVentas[dia] = diasVentas[dia] + precio;
                    }
                    else
                    {
                        diasVentas.Add(dia, precio);
                    }

                    if (espectaculos.ContainsKey(id))
                    {
                        espectaculos[id] = espectaculos[id] + precio;
                    }
                    else
                    {
                        espectaculos.Add(id, 1);
                    }
                }
            }

            foreach (var pair in diasVentas)
            {
                DataPoint p = new DataPoint(int.Parse(pair.Key), (int)pair.Value);
                mainChart.Series["Euros"].Points.Add(p);
            }

            int maxID = 0;
            decimal maxValue=0;
            foreach (var pair in espectaculos)
            {
                if (pair.Value > maxValue)
                {
                    maxID = pair.Key;
                }
            }

            DataSet espect = new DataSet();
            espect = espEN.ObtenerEspectaculoPorID(maxID.ToString());

            Image cartel = espEN.ObtenerImagenEspectaculo(maxID);
            
            if (cartel != null)
            {
                try
                {
                    pictureRentable.Image = cartel;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (DataRow r in espect.Tables[0].Rows)
            {
                labelRentable.Text = r["Titulo"].ToString();
            }
        }

        //Obtiene los datos necesarios para generar el gráfico "Ventas por tipo" de la pestaña General 
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

        //Obtiene los datos necesarios para generar el gráfico "Ventas por género" de la pestaña General
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

        //Se en carga de llamar a los métodos que obtiene los datos de la pestaña Cliente
        private void loadButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textNIF.Text))
            {
                generoChartCli.Series["Genero"].Points.Clear();
                tipoChartCli.Series["Tipo"].Points.Clear();
                diasVentas.Clear();
                tipoVentas.Clear();
                generoVentas.Clear();

                bool existe = false;
                existe = cliEN.ExisteCliente(textNIF.Text);
                if (existe)
                {
                    ObtenerDatosCliente();
                    ObtenerDatosCliGenerales();
                    ObtenerGeneroPref();
                    ObtenerTipoPref();
                }
                else
                {
                    textNIF.Text = "";
                    labelNombre.Text = "-";
                    labelApellidos.Text = "-";
                    labelCiudad.Text = "-";
                    labelEntradas.Text = "-";
                    labelDinero.Text = "-";
                    labelEspec.Text = "-";
                    errorAnyo.SetError(textNIF, "El cliente no existe");
                }
            }
        }

        //Obtiene los datos personales del cliente del cual hemos introducido el NIF y los muestra
        private void ObtenerDatosCliente()
        {
            byte[] bImage = new byte[0];
            Image im = null;
            DataSet ds = new DataSet();
            cliEN.DNI = textNIF.Text;
            ds = cliEN.getClienteByNif();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                labelNombre.Text = row["Nombre"].ToString();
                labelApellidos.Text = row["Apellidos"].ToString();
                labelCiudad.Text = row["Poblacion"].ToString();

                if (row["Foto"] != DBNull.Value)
                {
                    bImage = (byte[])row["Foto"];
                    MemoryStream ms = new MemoryStream(bImage);
                    im = Image.FromStream(ms);
                }

                if (im != null)
                {
                    try
                    {
                        pictureCliente.Image = im;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        //Obtiene datos generales del cliente y los muestra
        private void ObtenerDatosCliGenerales()
        {
            DataSet ds = new DataSet();

            ds = vEN.getEstadisticasCliente(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                decimal d = (decimal)row["Dinero"];
                labelDinero.Text = Math.Round(d, 2) + " €";
                labelEntradas.Text = row["Entradas"].ToString();
            }

            ds = vEN.getEspectaculosCliente(textNIF.Text);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                labelEspec.Text = row["Espectaculos"].ToString();
            }
            
        }

        //Obtiene los datos necesarios para generar una gráfica con el tipo de género favorito del cliente
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

        //Obtiene los datos necesarios para generar una gráfica con los tipos de espectáculos favoritos del cliente
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

        //En la pestaña Espectáculo, se obtienen los datos del espectáculo seleccionado
        private void comboTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTitulo.Items[comboTitulo.SelectedIndex].ToString() != "Espectáculo")
            {
                ObtenerDatosEspectaculo(comboTitulo.Items[comboTitulo.SelectedIndex].ToString());
                ObtenerEstadisticasEspectaculo(comboTitulo.Items[comboTitulo.SelectedIndex].ToString());
                LoadRanking();
            }
        }

        //Se obtienen los datos necesarios para generar las estadisticas del espectaculo seleccionado
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

        //Se obtienen algunos datos generales del espectáculo seleccionado
        private void ObtenerDatosEspectaculo(string titulo)
        {
            DataSet ds = new DataSet();
            ds = espEN.ObtenerDatosEspectaculo(titulo);

            try
            {
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

                    Image cartel = espEN.ObtenerImagenEspectaculo(int.Parse(r["IDEspectaculo"].ToString()));
                    if (cartel != null)
                    {
                        try
                        {
                            pictureBox3.Image = cartel;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ds = vEN.ObtenerRanking('d');
            int i=1;

            try
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    if (r["Titulo"].ToString().Equals(titulo))
                    {
                        labelRanking.Text = i.ToString() + "º";
                        break;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Se obtienen los datos necesarios para generar un gráfico que represente en orden descendente un ranking con los espectaculos mas rentables.
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

        private void Estadisticas_VisibleChanged(object sender, EventArgs e)
        {
            comboTitulo.Items.Clear();
            LoadEspectaculos();
        }
    }
}
