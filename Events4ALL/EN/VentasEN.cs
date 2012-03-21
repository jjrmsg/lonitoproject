using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Events4ALL.CAD;
using System.Data;

namespace Events4ALL.EN
{
    public class VentasEN
    {
        #region members
        private VentasCAD vCAD;
        #endregion

        public VentasEN()
        {
            vCAD = new VentasCAD();
        }

        //Devuelve un DataSet con las id y fechas de las ventas de todos los espectaculos
        public DataSet getAllEspectaculos()
        {
            DataSet dsVentas;
            dsVentas = vCAD.getAllEspectaculos();
            return dsVentas;
        }
    }
}
