using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    public abstract class A_Persona
    {
        private string nombre;
        private int DNI;
    }
    public class Persona: A_Persona, IComparable<Persona>
    {
        private string _nombre;
        private int _dni;

        public string Nombre { get { return _nombre; } set { this._nombre = value; } }
        public int DNI { get { return _dni; } set { this._dni = value; } }

        public Persona(string in_nombre, int in_dni)
        {
            this._nombre = in_nombre;
            this._dni = in_dni;
        }

        public bool sosIgual(Persona comparable)
        {
            return comparable.DNI == this._dni ? true : false;
        }

        public bool sosMenor(Persona comparable)
        {
            return comparable.DNI > this._dni ? true : false;
        }

        public bool sosMayor(Persona comparable)
        {
            return comparable.DNI < this._dni ? true : false;
        }
    }
}
