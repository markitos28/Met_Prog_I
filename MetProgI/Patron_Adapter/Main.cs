using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;
using MetProgI.Patron_FactoryMethod;
using MetProgI.Folder_Comparables;

namespace MetProgI.Patron_Adapter
{
    public class Main
    {
        public static void Run()
        {
            // ------------------------------------------------- Ejercicio 4 Practica 4 -------------------------------------

            Teacher maestro = new Teacher();
            for(int i =0; i<10; i++)
            {
                Student adaptado =new AdapterStudent((Alumno)new FabricaAlumno().crearAleatorio());
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = new AdapterStudent((AlumnoMuyEstudioso)new FabricaAlumnoMuyEstudioso().crearAleatorio());
                maestro.goToClass(adaptado);
            }

            maestro.teachingAClass();

            // --------------------------------------------------------------------------------------------------------------
        }
    }
}
