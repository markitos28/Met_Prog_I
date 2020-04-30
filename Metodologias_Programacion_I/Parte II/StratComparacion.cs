using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    public class StratComparacion_Nombre : IStrategy<Humano>
    {
       
        public bool sosIgual(Humano invocador,  Humano comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre).Equals(0)  ? true : false;
        }

        public bool sosMenor(Humano invocador,  Humano comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) > 0 ? true : false;
        }

        public bool sosMayor(Humano invocador, Humano comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) < 0 ? true : false;
        }

    }

    class StratComparacion_DNI : IStrategy<Humano>
    {
      
        public bool sosIgual(Humano invocador, Humano comparable)
        {
            return comparable.DNI.Equals(invocador.Nombre) ? true : false;
        }

        public bool sosMenor(Humano invocador, Humano comparable)
        {
            return comparable.DNI > invocador.DNI ? true : false;
        }

        public bool sosMayor(Humano invocador, Humano comparable)
        {
            return comparable.DNI < invocador.DNI ? true : false;
        }
    }   

    class StratComparacion_Legajo : IStrategy<Humano>
    {
        public bool sosIgual(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Legajo.Equals(((Alumno)invocador).Legajo) ? true : false;
        }

        public bool sosMenor(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Legajo > ((Alumno)invocador).Legajo ? true : false;
        }

        public bool sosMayor(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Legajo < ((Alumno)invocador).Legajo ? true : false;
        }
    }

    class StratComparacion_Promedio : IStrategy<Humano>
    {
        public bool sosIgual(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Promedio.Equals(((Alumno)invocador).Promedio) ? true : false;
        }

        public bool sosMenor(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Promedio > ((Alumno)invocador).Promedio ? true : false;
        }

        public bool sosMayor(Humano invocador, Humano comparable)
        {
            return ((Alumno)comparable).Promedio < ((Alumno)invocador).Promedio ? true : false;
        }
    }
}
