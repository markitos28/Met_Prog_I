using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;
using MetProgI.Patron_FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Proxy
{
    public class Main
    {
        public static void Run()
        {
            // ------------------------------------------------- Ejercicio 8 Practica 4 -------------------------------------
            // Reingenieria para que cree alumnos proxys

            Teacher maestro = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
                maestro.goToClass(adaptado);
            }
            for (int i = 0; i < 10; i++)
            {
                Student adaptado = (AlumnoMuyEstudiosoProxy)new FabricaAlumnoMuyEstudiosoProxy().crearAleatorio();
                maestro.goToClass(adaptado);
            }

            maestro.teachingAClass();

            // --------------------------------------------------------------------------------------------------------------
        }
    }
}
