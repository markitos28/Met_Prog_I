using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Comparables
{
    public class Alumno : Persona //, IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
    {
        private int _legajo;
        private double _promedio;

        public int Legajo { get { return _legajo; } }
        public double Promedio { get { return _promedio; } }

        public Alumno(string in_nombre, int in_dni, int in_legajo, double in_promedio)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            this._legajo = in_legajo;
            this._promedio = in_promedio;
            base.Estrategia = new StratComparacion_Nombre();
        }

        public bool sosIgual(Persona comparable)
        {
            return base.Estrategia.sosIgual(this, comparable);
        }

        public bool sosMenor(Persona comparable)
        {
            return base.Estrategia.sosMenor(this, comparable);
        }

        public bool sosMayor(Persona comparable)
        {
            return base.Estrategia.sosMayor(this, comparable);
        }
    }
}
