using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;

namespace MetProgI.Patron_Decorator
{
    public class DecoradoNotasEnLetras : AbsDecoradoresAdicionales
    {
        public DecoradoNotasEnLetras(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string imprimirDecorado()
        {
            string decoratedCalification = base.estudiante.showResult() + "(" + letrasXnumeros(base.estudiante.getScore()) + ")";
            return decoratedCalification;
        }

        public override string showResult()
        {
            return imprimirDecorado();
        }

        private string letrasXnumeros(int aConvertir)
        {
            string[] numerosConvertidos = { "CERO", "UNO", "DOS","TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};
            return numerosConvertidos[aConvertir];
        }
    }
}
