using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
