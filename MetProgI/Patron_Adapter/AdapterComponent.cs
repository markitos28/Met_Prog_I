using MetProgI.Folder_Comparables;
using MetProgI.Patron_Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Adapter
{
    public class AdapterComponent : Component
    {
        Component adaptado;

        public AdapterComponent(string in_nombre, int in_dni, int in_legajo, int in_calificacion) : base(in_nombre, in_dni, in_legajo, in_calificacion)
        {
            adaptado = new Leaf(in_nombre, in_dni, in_legajo, in_calificacion);
        }

        public override int Legajo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Promedio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Calificacion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string imprimirDecorado()
        {
            throw new NotImplementedException();
        }

        public override string mostrarCalificacion()
        {
            return adaptado.mostrarCalificacion();
        }

        public override int responder(int pregunta)
        {
            return adaptado.responder(pregunta);
        }

        public override int responderPregunta(int pregunta)
        {
            throw new NotImplementedException();
        }

        public override void setCalificacion(int inCalificacion)
        {
            adaptado.setCalificacion(inCalificacion);
        }

        public override bool sosIgual(AbsAlumno comparable)
        {
            return adaptado.sosIgual(comparable);
        }

        public override bool sosMayor(AbsAlumno comparable)
        {
            return adaptado.sosMayor(comparable);
        }

        public override bool sosMenor(AbsAlumno comparable)
        {
            return adaptado.sosMenor(comparable);
        }
    }
}
