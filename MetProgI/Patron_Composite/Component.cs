using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Composite
{
    public abstract class Component: AbsAlumno
    {
        public string _nombre;
        public int _dni;
        public int _legajo;
        public int _calificacion;

        public Component(string in_nombre, int in_dni, int in_legajo, int in_calificacion)
        {
            _nombre = in_nombre;
            _dni = in_dni;
            _legajo = in_legajo;
            _calificacion = in_calificacion;
        }

        public abstract int responder(int pregunta);
        public abstract void setCalificacion(int inCalificacion);
        public override abstract string mostrarCalificacion();
        public abstract bool sosIgual(AbsAlumno comparable);
        public abstract bool sosMayor(AbsAlumno comparable);
        public abstract bool sosMenor(AbsAlumno comparable);

    }
}
