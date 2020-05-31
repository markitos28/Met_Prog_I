using System; using System.Collections.Generic; using System.Text;
using MetProgI.Folder_Coleccionables; using MetProgI.Folder_Comparables; using MetProgI.Generador_Random;
using MetProgI.Impresiones;
using MetProgI.Patron_Adapter; using MetProgI.Patron_Decorator; using MetProgI.Patron_FactoryMethod; using MetProgI.Patron_Iterator;
using MetProgI.Patron_Observer; using MetProgI.Patron_Strategy; using MetodologíasDeProgramaciónI;

namespace MetProgI.Patron_Proxy
{
    public class AlumnoProxy : AbsAlumno, Student, I_Comparable
    {
        private Alumno _alumnoproxy = null;
        public Alumno ProxyAlumno { get { return _alumnoproxy; } private set { _alumnoproxy = value; } }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public override int Legajo { get; set; }
        public override double Promedio { get; set; }
        public override double Calificacion { get; set; }

        public AlumnoProxy(string in_nombre, int in_dni, int in_legajo, double in_promedio) 
        {
            Nombre = in_nombre;
            DNI = in_dni;
            Legajo = in_legajo;
            Promedio = in_promedio;
            Calificacion = 1;
            
        }

        public string getName()
        {
            return Nombre;
        }

        public int yourAnswerIs(int question)
        {
            if (ProxyAlumno == null)
            {
                ProxyAlumno = new Alumno(Nombre, DNI, Legajo, Promedio);
                Console.WriteLine("Se crea el Alumno Real");
            }
            return ProxyAlumno.responderPregunta(question);
        }

        public int getScore()
        {
            return (int)Calificacion;
        }

        public void setScore(int score)
        {
            Calificacion = score;
        }

        public string showResult()
        {
            return this.Nombre + "\t" + this.Calificacion;
        }

        public bool equals(Student student)
        {
            return Calificacion.Equals(student.getScore());
        }

        public bool lessThan(Student student)
        {
            return Calificacion < student.getScore() ? true : false;
        }

        public bool greaterThan(Student student)
        {
            return Calificacion > student.getScore() ? true : false;
        }

        public bool sosIgual(I_Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool sosMenor(I_Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool sosMayor(I_Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public override string imprimirDecorado()
        {
            throw new NotImplementedException();
        }

        public override string mostrarCalificacion()
        {
            return this.Nombre + "\t" + this.Calificacion;
        }

        public override int responderPregunta(int pregunta)
        {
            throw new NotImplementedException();
        }
    }
}
