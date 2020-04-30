using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    public class Alumno : Humano //, IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
    {
        private int _legajo;
        private float _promedio;

        public int Legajo { get { return _legajo; } }
        public float Promedio {get { return _promedio; } }

        public Alumno(string in_nombre, int in_dni, int in_legajo, float in_promedio)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            this._legajo = in_legajo;
            this._promedio = in_promedio;
            base.Estrategia = new StratComparacion_Nombre();
        }

        public bool sosIgual(Humano comparable)
        {
            return base.Estrategia.sosIgual(this,comparable);
        }

        public bool sosMenor(Humano comparable)
        { 
            return base.Estrategia.sosMenor(this,comparable);
        }

        public bool sosMayor(Humano comparable)
        {
            return base.Estrategia.sosMayor(this, comparable);
        }
    }
}
