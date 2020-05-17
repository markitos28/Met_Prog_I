using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace MetProgI.Patron_Decorator
{
    public abstract class AbsDecoradoresAdicionales :  IImprimirDec
    {
        public Student estudiante;

        public abstract string imprimirDecorado();

    }
}
