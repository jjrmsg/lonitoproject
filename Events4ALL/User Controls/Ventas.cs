using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Events4ALL.EN;

namespace Events4ALL
{
    public partial class Ventas : UserControl
    {
        public Ventas()
        {
            InitializeComponent();
        }

        // Si marcamos buscar por fecha de espectáculo desbloqueamos el selector de fecha.
        private void cbEspectaculo_CheckedChanged(object sender, EventArgs e)
        {
            dtFechEspectaculo.Enabled = cbEspectaculo.Checked;
        }

        // Si marcamos buscar por fecha de venta desbloqueamos el selector de fecha.
        private void cbVenta_CheckedChanged(object sender, EventArgs e)
        {
            dtFechVenta.Enabled = cbVenta.Checked;
        }

        // Elimina el contenido de los campos del formulario de búsqueda.
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbDni.Text = "";
            tbTitulo.Text = "";
            cbTipo.SelectedIndex = -1;
            dtFechEspectaculo.Value = DateTime.Today;
            dtFechVenta.Value = DateTime.Today;
        }

        // Recoge los datos del formulario, realiza la búqueda y muestra los resultados.
        private void btBuscar_Click(object sender, EventArgs e)
        {
            VentasEN ventasEN = new VentasEN();

            string fechaEsp = "", fechaVent = "";
            if (cbEspectaculo.Checked == true)
                fechaEsp = dtFechEspectaculo.Text;
            if (cbVenta.Checked == true)
                fechaVent = dtFechVenta.Text;

            DataSet ventas = ventasEN.BuscarVenta(tbNombre.Text, tbDni.Text, tbTitulo.Text, cbTipo.Text, fechaEsp, fechaVent);

            dataGridVentas.Rows.Clear();
            foreach (DataRow venta in ventas.Tables[0].Rows)
            {
                string[] row = { venta["IdVenta"].ToString(),
                                 venta["Nombre"].ToString(),
                                 venta["NIF"].ToString(), 
                                 venta["Titulo"].ToString(),
                                 venta["tipo"].ToString(),
                                 venta["Importe"].ToString(),
                                 Convert.ToDateTime(venta["FechaVenta"]).ToShortDateString()};
                dataGridVentas.Rows.Add(row);
            }
        }

        // Al pulsar en una fila de la búsqueda se comprueba si se hizo en el boton de borrar venta.
        private void dataGridVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridVentas.Columns["Eliminar"].Index)
            {
                // Si se ha pulsado en el boton de borrar
                if (MessageBox.Show("¿Desea eliminar la venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                {
                    VentasEN ventasEN = new VentasEN();
                    if (ventasEN.EliminarVenta(dataGridVentas[0, e.RowIndex].Value.ToString()) == true)
                    {
                        dataGridVentas.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar la venta.");
                    }
                }
            }          
        }
    }
}
