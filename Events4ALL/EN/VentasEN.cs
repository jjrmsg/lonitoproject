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
        public VentasEN()
        {

        }

        //Devuelve un DataSet con las id y fechas de las ventas de todos los espectaculos
        public DataSet getAllEspectaculos()
        {
            VentasCAD vCAD = new VentasCAD();

            DataSet dsVentas;
            dsVentas = vCAD.getAllEspectaculos();
            return dsVentas;
        }
    }
}
