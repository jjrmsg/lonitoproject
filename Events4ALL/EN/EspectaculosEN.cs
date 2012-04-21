using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using System.Data;
using System.Drawing;

namespace Events4ALL.EN
{
    public class EspectaculosEN
    {
        private string titulo;
        private string descripcion;
        private string fechIni;
        private string fechFin;
        private decimal precio;
        private string genero;
        private Image cartel;
        public int idEspectaculo { get; set; }

        // Constructor por defecto de la entidad Espectáculos.
        public EspectaculosEN()
        {

        }

        // Constructor de la entidad Espectáculos.
        public EspectaculosEN(string titulo, string descripcion, decimal precio, string genero, string fechIni, string fechFin, Image cartel)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fechIni = fechIni;
            this.fechFin = fechFin;
            this.precio = precio;
            this.genero = genero;
            this.cartel = cartel;
        }

        // Recoge el precio de un espectáculo.
        public decimal getPrecioId()
        {
            EspectaculosCAD espCAD; espCAD = new EspectaculosCAD();
            return espCAD.getPrecioId(idEspectaculo);
        }

        // Inserta el espectáculo en la bd.
        public bool Insertar(string salaReserva)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Insertar(titulo, descripcion, precio.ToString(), genero, fechIni, fechFin, salaReserva, cartel);
        }

        // Edita un espectáculo en la bd.
        public bool Editar(string salaReserva, int idEspectaculo)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Editar(titulo, descripcion, precio.ToString(), genero, fechIni, fechFin, salaReserva, cartel, idEspectaculo);
        }

        // Elimina un espectáculo de la bd a partir de una id.
        public bool Eliminar(string idEspectaculo)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Eliminar(idEspectaculo);
        }

        // Busca espectáculos en la bd que cumplan las restricciones.
        public DataSet Buscar(string tit, string sala, string tipo, string modFecha, string valFecha, string modPrecio, string valPrecio)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            DataSet espectaculos = espCAD.Buscar(tit, sala, tipo, modFecha, valFecha, modPrecio, valPrecio);
            return espectaculos;
        }

        // Obtiene todos los espectáculos de la bd.
        public DataSet ObtenerEspectaculos()
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.ObtenerEspectaculos();
        }

        // Obtiene los datos de un espectáculo a partir de su título.
        public DataSet ObtenerDatosEspectaculo(string titulo)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.ObtenerDatosEspectaculo(titulo);
        }

        //Obtiene los espectaculos en cartelera y los proximos espectaculos, descarta los que ya han finalizado
        public DataSet ObtenerEspectaculosNuevos(string fecha)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.ObtenerEspectaculosNuevos(fecha);
        }

        // Obtiene los datos de un espectáculo a partir de su id.
        public DataSet ObtenerEspectaculoPorID(string id)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.ObtenerEspectaculoPorID(id);
        }

        // Obtiene la imagen de un espectáculo a partir de su id.
        public Image ObtenerImagenEspectaculo(int id)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.ObtenerImagenEspectaculo(id);
        }
    }
}
