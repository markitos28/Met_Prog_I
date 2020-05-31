using System;
using System.Collections.Generic;
using System.Text;
using global::MetProgI;
using MetProgI.Folder_Comparables;

namespace MetProgI.Patron_Command
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        public Aula Aula2 { get; set; }

        public OrdenLlegaAlumno(Aula in_Aula)
        {
            Aula2 = in_Aula;
        }
        public void ejecutar(I_Comparable a)
        {
            Aula2.nuevoAlumno((AbsAlumno)a);
        }
    }
}
