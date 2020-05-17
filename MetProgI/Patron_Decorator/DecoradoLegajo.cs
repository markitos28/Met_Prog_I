using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;

namespace MetProgI.Patron_Decorator
{
    public class DecoradoLegajo : AbsDecoradoresAdicionales
    {
        public DecoradoLegajo(Student estudiante)
        {
            base.estudiante = estudiante;
        }
        public override string imprimirDecorado()
        {
            AdapterStudent alumno = (AdapterStudent)base.estudiante;
            string showCalification = alumno.showResult();
            string[] splitCalification= showCalification.Split('\t');
            string decoratedCalification = splitCalification[0] + " (" + alumno.Adaptado.Legajo + ") " + "\t" + splitCalification[1];
            return decoratedCalification;
        }
    }
}
