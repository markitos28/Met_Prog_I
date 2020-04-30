using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    public class Alumno : Humano //, IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
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

        public bool sosIgual(Humano comparable)
        {
            return base.Estrategia.sosIgual(this, comparable);
        }

        public bool sosMenor(Humano comparable)
        {
            return base.Estrategia.sosMenor(this, comparable);
        }

        public bool sosMayor(Humano comparable)
        {
            return base.Estrategia.sosMayor(this, comparable);
        }
    }
}
