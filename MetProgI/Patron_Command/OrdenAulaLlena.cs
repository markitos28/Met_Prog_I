using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Command
{
    public class OrdenAulaLlena  : OrdenEnAula1  
    {
        public Aula Aula1 { get; set; }

        public OrdenAulaLlena(Aula salon)
        {
            Aula1 = salon;
        }

        public void ejecutar()
        {
            Aula1.claseLista();
        }
    }
}
