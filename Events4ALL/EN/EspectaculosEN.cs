using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using System.Data;

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
        private EspectaculosCAD espCAD;
        public int idEspectaculo { get; set; }

        public EspectaculosEN()
        {
            espCAD = new EspectaculosCAD();
        }

        public EspectaculosEN(string titulo, string descripcion, decimal precio, string genero, string fechIni, string fechFin)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fechIni = fechIni;
            this.fechFin = fechFin;
            this.precio = precio;
            this.genero = genero;
        }

        public decimal getPrecioId()
        {
            return espCAD.getPrecioId(idEspectaculo);
        }

        public bool Insertar(string salaReserva)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Insertar(titulo, descripcion, precio.ToString(), genero, fechIni, fechFin, salaReserva);
        }

        public DataSet Buscar()
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            DataSet espectaculos = espCAD.Buscar();
            return espectaculos;
        }
    }
}
