using MetProgI.Patron_Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Folder_Comparables
{
    public abstract class AbsAlumno : Persona, IImprimirDec, I_Comparable
    {
        public abstract int Legajo { get; set; }
        public abstract double Promedio { get; set; }
        public abstract double Calificacion { get; set; }
        public abstract string imprimirDecorado();
        public abstract string mostrarCalificacion();
        public abstract int responderPregunta(int pregunta);

    }
}
