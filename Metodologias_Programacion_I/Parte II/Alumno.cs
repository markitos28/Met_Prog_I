using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    public class Alumno : Humano, IComparable<Alumno>
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
        }

        public bool sosIgual(Alumno comparable)
        {
            return comparable.Legajo == this._legajo ? true : false;
        }
        public bool sosIgual(Alumno comparable, byte decision)
        {
            return decision == 0 ? (comparable.Legajo == this._legajo ? true : false) : (comparable.Promedio == this._promedio ? true : false);
        }

        public bool sosMenor(Alumno comparable)
        {
            return comparable.Legajo > this._legajo ? true : false;
        }

        public bool sosMenor(Alumno comparable, byte decision)
        {
            return decision == 0 ? (comparable.Legajo > this._legajo ? true : false) : (comparable.Promedio > this._promedio ? true : false);
            
        }

        public bool sosMayor(Alumno comparable)
        {
            return comparable.Legajo < this._legajo ? true : false;
        }

        public bool sosMayor(Alumno comparable, byte decision)
        {
            return decision == 0 ? (comparable.Legajo < this._legajo ? true : false) : (comparable.Promedio < this._promedio ? true : false);

        }
    }
}
