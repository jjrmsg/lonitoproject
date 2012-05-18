using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Entities
{
    public class VotosEN
    {
        public VotosEN()
        {

        }

        public bool setVoto(string user, string esp, int nota)
        {
            VotosCAD votCAD = new VotosCAD();
            return votCAD.setVoto(user, esp, nota);
        }

        public DataSet SacarVotosEn(string tipo)
        {
            VotosCAD votCAD = new VotosCAD();
            return votCAD.SacarVotosCAD(tipo);
        }
    }
}
