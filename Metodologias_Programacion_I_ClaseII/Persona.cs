using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{

    public class Persona: Humano//IComparable<Persona>
    { 
        public string Nombre { get { return base.Nombre; } set { base.Nombre = value; } }
        public int DNI { get { return base.DNI; } set { base.DNI = value; } }

        public Persona(string in_nombre, int in_dni)
        {
            Nombre = in_nombre;
            DNI = in_dni;
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
