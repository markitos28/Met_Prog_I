using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Composite
{
    public class Leaf : Component
    {
        public AbsAlumno alumnoHoja;

        public Leaf(string in_nombre, int in_dni, int in_legajo, int in_calificacion) : base(in_nombre, in_dni, in_legajo, in_calificacion)
        {
            alumnoHoja = new Alumno(in_nombre,in_dni,in_legajo,in_calificacion);
        }

        public override int Legajo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Promedio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Calificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string imprimirDecorado()
        {
            return alumnoHoja.imprimirDecorado();
        }

        public override string mostrarCalificacion()
        {
            return alumnoHoja.Nombre + "\t" + alumnoHoja.Calificacion;
        }

        public override int responder(int pregunta)
        {
            return alumnoHoja.responderPregunta(pregunta);
        }

        public override int responderPregunta(int pregunta)
        {
            return alumnoHoja.responderPregunta(pregunta);
        }

        public override void setCalificacion(int inCalificacion)
        {
            alumnoHoja.Calificacion = inCalificacion;
        }

        public override bool sosIgual(AbsAlumno comparable)
        {
            return alumnoHoja.sosIgual(comparable);
        }

        public override bool sosMayor(AbsAlumno comparable)
        {
            return alumnoHoja.sosMayor(comparable);
        }

        public override bool sosMenor(AbsAlumno comparable)
        {
            return alumnoHoja.sosMenor(comparable);
        }
    }
}
