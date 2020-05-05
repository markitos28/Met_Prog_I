using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Observer;

namespace MetProgI.Patron_Strategy
{
    public class StratComparacion_Nombre : IStrategy<Persona>
    {

        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre).Equals(0) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) > 0 ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.Nombre.CompareTo(invocador.Nombre) < 0 ? true : false;
        }

    }

    public class StratComparacion_DNI : IStrategy<Persona>
    {

        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return comparable.DNI.Equals(invocador.DNI) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return comparable.DNI > invocador.DNI ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return comparable.DNI < invocador.DNI ? true : false;
        }
    }

    public class StratComparacion_Legajo : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo.Equals(((Alumno)invocador).Legajo) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo > ((Alumno)invocador).Legajo ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Legajo < ((Alumno)invocador).Legajo ? true : false;
        }
    }

    public class StratComparacion_Promedio : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio.Equals(((Alumno)invocador).Promedio) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio > ((Alumno)invocador).Promedio ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Alumno)comparable).Promedio < ((Alumno)invocador).Promedio ? true : false;
        }
    }

    public class StratComparacion_Bonus : IStrategy<Persona>
    {
        public bool sosIgual(Persona invocador, Persona comparable)
        {
            return ((Vendedor)comparable).Bonus.Equals(((Vendedor)invocador).Bonus) ? true : false;
        }

        public bool sosMenor(Persona invocador, Persona comparable)
        {
            return ((Vendedor)comparable).Bonus > ((Vendedor)invocador).Bonus ? true : false;
        }

        public bool sosMayor(Persona invocador, Persona comparable)
        {
            return ((Vendedor)comparable).Bonus < ((Vendedor)invocador).Bonus ? true : false;
        }
    }
}
