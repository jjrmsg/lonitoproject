﻿using System;
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
        public int idEspectaculo { get; set; }

        public EspectaculosEN()
        {

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
            EspectaculosCAD espCAD;espCAD = new EspectaculosCAD();
            return espCAD.getPrecioId(idEspectaculo);
        }

        public bool Insertar(string salaReserva)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Insertar(titulo, descripcion, precio.ToString(), genero, fechIni, fechFin, salaReserva);
        }

        public bool Eliminar(string idEspectaculo)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            return espCAD.Eliminar(idEspectaculo);
        }

        public DataSet Buscar(string tit, string sala, string tipo, string modFecha, string valFecha, string modPrecio, string valPrecio)
        {
            EspectaculosCAD espCAD = new EspectaculosCAD();
            DataSet espectaculos = espCAD.Buscar(tit, sala, tipo, modFecha, valFecha, modPrecio, valPrecio);
            return espectaculos;
        }
    }
}
