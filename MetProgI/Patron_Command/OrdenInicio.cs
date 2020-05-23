using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Command
{
    public class OrdenInicio: OrdenEnAula1
    {
        public Aula Aula1 { get; set; }

        public OrdenInicio(Aula salon)
        {
            Aula1 = salon;
        }

        public void ejecutar()
        {
            Aula1.comenzar();
        }
    }
}
