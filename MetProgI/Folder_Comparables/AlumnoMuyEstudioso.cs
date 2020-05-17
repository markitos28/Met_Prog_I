using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Strategy;
using MetodologíasDeProgramaciónI;

namespace MetProgI.Folder_Comparables
{
    public class AlumnoMuyEstudioso : Alumno //, IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
    {
        public AlumnoMuyEstudioso(string in_nombre, int in_dni, int in_legajo, double in_promedio) : base(in_nombre, in_dni, in_legajo, in_promedio)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            base.Legajo = in_legajo;
            base.Promedio = in_promedio;
            base.Estrategia = new StratComparacion_Nombre();
            
        }

        public new int responderPregunta(int pregunta)
        {
            int respuesta = pregunta % 3;
            return respuesta;
        }


        //public bool sosIgual(Persona comparable)
        //{
        //    return base.Estrategia.sosIgual(this, comparable);
        //}

        //public bool sosMenor(Persona comparable)
        //{
        //    return base.Estrategia.sosMenor(this, comparable);
        //}

        //public bool sosMayor(Persona comparable)
        //{
        //    return base.Estrategia.sosMayor(this, comparable);
        //}
    }
}
