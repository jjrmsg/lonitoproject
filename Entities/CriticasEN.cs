using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entities
{
    public class CriticasEN
    {
        public CriticasEN()
        {

        }

        public bool Insertar(string idCliente, string idEsp, string titulo, string texto)
        {
            CriticasCAD criCAD = new CriticasCAD();
            return criCAD.Insertar(idCliente, idEsp, titulo, texto);
        }

        public DataSet getCriticasEspectaculo(string idEsp)
        {
            CriticasCAD criCAD = new CriticasCAD();
            return criCAD.getCriticasEspectaculo(idEsp);
        }
    }
}
