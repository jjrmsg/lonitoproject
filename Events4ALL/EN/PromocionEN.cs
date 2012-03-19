using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events4ALL.EN
{
    class PromocionEN
    {
        private int idPromocion;
        private string nombre;
        private int descuento;

        public int IdPromocion
        {
            get { return idPromocion; }
            set { idPromocion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
    }
}
