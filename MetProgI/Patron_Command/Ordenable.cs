using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Command
{
    public interface Ordenable
    {
        public void setOrdenInicio(OrdenEnAula1 OEA1);
        public void setOrdenLlegaAlumno(OrdenEnAula2 OEA2);
        public void setOrdenAulaLlena(OrdenEnAula1 OEA1);

    }
}
