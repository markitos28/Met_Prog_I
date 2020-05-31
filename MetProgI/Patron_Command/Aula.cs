using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Command
{
    public class Aula
    {
        private Teacher _teacher;
        public Teacher Profesor { get; set; }

        public void comenzar()
        {
            Console.WriteLine("Se instancia al Profesor. ");
            Profesor = new Teacher();
        }

        public void nuevoAlumno(AbsAlumno estudiante)
        {
            AdapterStudent adaptado = new AdapterStudent(estudiante);
            Profesor.goToClass(adaptado);
        }

        public void claseLista()
        {
            Profesor.teachingAClass();
        }
    }
}
