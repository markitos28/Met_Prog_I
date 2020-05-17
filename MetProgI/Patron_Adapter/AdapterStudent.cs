using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;

namespace MetProgI.Patron_Adapter
{
    public class AdapterStudent : Student
    {
        private Alumno _adaptado;

        public Alumno Adaptado {  get { return _adaptado;  } set { _adaptado = value; } }
        //public AdapterStudent(string in_nombre, int in_dni, int in_legajo, double in_promedio) : base(in_nombre, in_dni, in_legajo, in_promedio) { }

        public AdapterStudent(Alumno inAlumno)
        {
            Adaptado = inAlumno;
        }
        public bool equals(Student student)
        {
            return Adaptado.Calificacion.Equals(student.getScore());
        }

        public string getName()
        {
            return Adaptado.Nombre;
        }

        public int getScore()
        {
            return (int)Adaptado.Calificacion;
        }

        public bool greaterThan(Student student)
        {
            return Adaptado.Calificacion > student.getScore() ? true:false ;
        }

        public bool lessThan(Student student)
        {
            return Adaptado.Calificacion < student.getScore() ? true : false;
        }

        public void setScore(int score)
        {
            Adaptado.Calificacion = score;
        }

        public string showResult()
        {
            return Adaptado.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return Adaptado.responderPregunta(question);
        }
    }
}
