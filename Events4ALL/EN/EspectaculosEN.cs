using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;

namespace Events4ALL.EN
{
    public class EspectaculosEN
    {
        private string titulo;
        private string descripcion;
        private string fechIni;
        private string fechFin;
        private float precio;
        private string genero;
        private EspectaculosCAD espCAD;
        public int idEspectaculo { get; set; }

        public EspectaculosEN()
        {
            espCAD = new EspectaculosCAD();
        }

        public decimal getPrecioId()
        {
            return espCAD.getPrecioId(idEspectaculo);
        }
    }
}
