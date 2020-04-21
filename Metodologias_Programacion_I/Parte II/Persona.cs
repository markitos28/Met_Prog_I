using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{

    public class Persona: Humano, IComparable<Persona>
    { 
        public string Nombre { get { return base.Nombre; } set { base.Nombre = value; } }
        public int DNI { get { return base.DNI; } set { base.DNI = value; } }

        public Persona(string in_nombre, int in_dni)
        {
            Nombre = in_nombre;
            DNI = in_dni;
        }

        public bool sosIgual(Persona comparable)
        {
            return comparable.DNI == this.DNI ? true : false;
        }

        public bool sosMenor(Persona comparable)
        {
            return comparable.DNI > this.DNI ? true : false;
        }

        public bool sosMayor(Persona comparable)
        {
            return comparable.DNI < this.DNI ? true : false;
        }
    }
}
