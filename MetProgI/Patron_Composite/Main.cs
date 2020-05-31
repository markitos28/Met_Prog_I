using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;
using MetProgI.Patron_FactoryMethod;
using MetProgI.Patron_Proxy;
using MetProgI.Patron_Decorator;
using MetProgI.Generador_Random;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Composite
{
    public class Main
    {
        public static void Run()
        {
            // --------------------------------------------- Ejercicio 2 Practica 6 -----------------------------------------------
            Teacher maestro = new Teacher();

            CompuestoAlumno alumnoCompuesto = (CompuestoAlumno)new FabricaAlumnoCompuesto().crearAleatorio();
            AlumnoProxy alumno1 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumno2 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumno3 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumno4 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumno5 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            
            alumnoCompuesto.agregar(alumno1);
            alumnoCompuesto.agregar(alumno2);
            alumnoCompuesto.agregar(alumno3);
            alumnoCompuesto.agregar(alumno4);
            alumnoCompuesto.agregar(alumno5);
            Student estudiante = new AdapterStudent(alumnoCompuesto);
            //Student adaptado; //hay que adaptar compuesto Alumno a student
            //maestro.goToClass(adaptado);
            maestro.goToClass(estudiante);
            maestro.teachingAClass();

            // ---------------------------------------------------------------------------------------------------------------------
        }
    }
}
