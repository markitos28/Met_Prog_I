using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Strategy;
using MetodologíasDeProgramaciónI;

namespace MetProgI.Folder_Comparables
{
    public class AlumnoMuyEstudioso : AbsAlumno//Alumno , IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
    {
        public override int Legajo { get ; set; }
        public override double Promedio { get ; set ; }
        public override double Calificacion { get ; set ; }

        public AlumnoMuyEstudioso(string in_nombre, int in_dni, int in_legajo, double in_promedio)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            this.Legajo = in_legajo;
            this.Promedio = in_promedio;
            base.Estrategia = new StratComparacion_Nombre();
            
        }

        
        public override string imprimirDecorado()
        {
            throw new NotImplementedException();
        }

        public override int responderPregunta(int pregunta)
        {
            int respuesta = pregunta % 3;
            return respuesta;
        }

        public override string mostrarCalificacion()
        {
            //Console.WriteLine("El alumno {0} obtuvo una nota de {1} en sus examenes.", this.Nombre, this.Calificacion);
            return this.Nombre + "\t" + this.Calificacion;
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
