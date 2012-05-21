using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Entities;
using System.Data;

namespace Entities
{
    public class VentasEN
    {
        // Constructor por defecto de la entidad Ventas.
        public VentasEN()
        {

        }

        // Devuelve un DataSet con las id y fechas de las ventas de todos los espectáculos.
        public DataSet getAllEspectaculos()
        {
            VentasCAD vCAD = new VentasCAD();

            DataSet dsVentas;
            dsVentas = vCAD.getAllEspectaculos();
            return dsVentas;
        }

        // Obtiene datos de ventas de un cliente indentificado con su NIF.
        public DataSet getEstadisticasCliente(string nif)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.getEstadisticasCliente(nif);
        }

        // Recoge los espectaculos que tengan una venta asociada a un cliente identificado con su NIF.
        public DataSet getEspectaculosCliente(string nif)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.getEspectaculosCliente(nif);
        }

        // Obtiene los datos necesarios para saber que tipo y género de espectáculos son los favoritos de un cliente.
        public DataSet getGeneroTipoCli(string nif)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.getGeneroTipoCli(nif);
        }

        // Obtiene las ventas aociadas a un espectáculo identificado por su título.
        public DataSet getVentasEspectaculo(string titulo)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.getVentasEspectaculo(titulo);
        }

        // Obtiene el ranking de un espectáculo a partir de sus ventas.
        public DataSet ObtenerRanking(char orden)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.ObtenerRanking(orden);
        }

        //Obtiene el ranking de una determinada categoria(musica,cine,teatro)
        public DataSet ObtenerRankingTipo(string tipo)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.ObtenerRankingTipo(tipo);
        }

        // Busca ventas en la bd que cumplan las restricciones.
        public DataSet BuscarVenta(string nombre, string dni, string titulo, string tipo, string fEsp, string fVenta)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.BuscarVenta(nombre, dni, titulo, tipo, fEsp, fVenta);
        }

        // Elimina una venta de la bd a partir de una id.
        public bool EliminarVenta(string idVenta)
        {
            VentasCAD vCAD = new VentasCAD();
            return vCAD.EliminarVenta(idVenta);
        }

        public DataSet getVentasEspectaculoId(string id, string hora, string fecha)
        {
            VentasCAD ventCAD = new VentasCAD();
            return ventCAD.getVentasEspectaculoId(id, hora, fecha);
        }

        // Comprueba si un asiento está ocupado a partir de un espectaculo, un horario y una plaza indicada 
        public bool ExisteVenta(string idEsp, string asiento, string hora, string fecha)
        {
            VentasCAD ventCAD = new VentasCAD();
            return ventCAD.ExisteVenta(idEsp, asiento, hora, fecha);
        }

        // Comprueba si un asiento está ocupado a partir de un espectaculo, un horario y una plaza indicada 
        public bool Insertar(string idEspectaculo, string idCliente, string fecha, string hora, string numAsiento, string importe)
        {
            VentasCAD ventCAD = new VentasCAD();
            return ventCAD.Insertar(idEspectaculo, idCliente, fecha, hora, numAsiento, importe);
        }
    }
}
