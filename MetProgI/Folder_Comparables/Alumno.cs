using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Strategy;
using MetProgI.Patron_Decorator;

namespace MetProgI.Folder_Comparables
{
    public class Alumno : Persona, IImprimirDec //, IStrategy<Humano> ,IComparable<Alumno> Nota: Se quita la interfaz IStrategy para no implementar los comparadores con dos argumentos.
    {
        private int _legajo;
        private double _promedio;
        private double _calificacion;
        public int Legajo { get { return _legajo; } protected set { _legajo = value; } }
        public double Promedio { get { return _promedio; } protected set { _promedio = value; } }
        public double Calificacion { get { return _calificacion; } set { _calificacion = value; } }

        public Alumno(string in_nombre, int in_dni, int in_legajo, double in_promedio)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            this._legajo = in_legajo;
            this._promedio = in_promedio;
            base.Estrategia = new StratComparacion_Nombre();
        }

        public bool sosIgual(Persona comparable)
        {
            return base.Estrategia.sosIgual(this, comparable);
        }

        public bool sosMenor(Persona comparable)
        {
            return base.Estrategia.sosMenor(this, comparable);
        }

        public bool sosMayor(Persona comparable)
        {
            return base.Estrategia.sosMayor(this, comparable);
        }

        public int responderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public string mostrarCalificacion()
        {
            //Console.WriteLine("El alumno {0} obtuvo una nota de {1} en sus examenes.", this.Nombre, this.Calificacion);
            return this.Nombre + "\t" + this.Calificacion;
        }

        public string imprimirDecorado()
        {
            throw new NotImplementedException();
        }
    }
}
