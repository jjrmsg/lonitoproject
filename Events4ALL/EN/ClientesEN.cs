using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Events4ALL.CAD;
using System.Data;

namespace Events4ALL.EN
{
    public class ClientesEN
    {
        private ClientesCAD cliCAD;
        public string nif { get; set; }

        public ClientesEN()
        {
            cliCAD = new ClientesCAD();
        }

        public DataSet getClienteByNif()
        {
            return cliCAD.getClienteByNif(nif);
        }
    }
}
