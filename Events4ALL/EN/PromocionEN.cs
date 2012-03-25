using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events4ALL.EN
{
    class PromocionEN
    {

        #region variables
        private int idPromocion;
        private string nombre;
        private int descuento;
        #endregion

        #region gets/sets
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
        #endregion

        #region constructor vacio
        public PromocionEN()
        {
        }
        #endregion

        #region constructor
        public PromocionEN(int id, string nom, int des)
        {
            idPromocion = id;
            nombre = nom;
            descuento = des;
        }
        #endregion
    }
}
