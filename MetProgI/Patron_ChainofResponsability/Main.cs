using MetProgI.Generador_Random;
using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Composite;
using MetProgI.Patron_FactoryMethod;
using MetProgI.Patron_Proxy;
using MetProgI.Patron_Adapter;
using MetProgI.Folder_Comparables;

namespace MetProgI.Patron_ChainofResponsability
{
    public class Main
    {
        public static void Run()
        {
            // --------------------------------------------- Ejercicio 3 Practica 7 -----------------------------------------------
            Teacher maestro = new Teacher();

            CompuestoAlumno alumnoCompuesto = (CompuestoAlumno)new FabricaAlumnoCompuesto().crearAleatorio();
            AlumnoProxy alumnoProxy1 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumnoProxy2 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumnoProxy3 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumnoProxy4 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();
            AlumnoProxy alumnoProxy5 = (AlumnoProxy)new FabricaAlumnoProxy().crearAleatorio();

            Alumno alumno1 = (Alumno)new FabricaAlumno().crearAleatorio();
            Alumno alumno2 = (Alumno)new FabricaAlumno().crearAleatorio();
            Alumno alumno3 = (Alumno)new FabricaAlumno().crearAleatorio();
            Alumno alumno4 = (Alumno)new FabricaAlumno().crearAleatorio();
            Alumno alumno5 = (Alumno)new FabricaAlumno().crearAleatorio();

            AlumnoMuyEstudioso alumnoME1 = (AlumnoMuyEstudioso)new FabricaAlumnoMuyEstudioso().crearPorTeclado();
            AlumnoMuyEstudioso alumnoME2 = (AlumnoMuyEstudioso)new FabricaAlumnoMuyEstudioso().crearPorTeclado();

            alumnoCompuesto.agregar(alumnoProxy1);
            alumnoCompuesto.agregar(alumnoProxy2);
            alumnoCompuesto.agregar(alumnoProxy3);
            alumnoCompuesto.agregar(alumnoProxy4);
            alumnoCompuesto.agregar(alumnoProxy5);
            
            Student estudiante = new AdapterStudent(alumnoCompuesto);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno1);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno2);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno3);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno4);
            maestro.goToClass(estudiante);
            estudiante = new AdapterStudent(alumno5);
            maestro.goToClass(estudiante);

            estudiante = new AdapterStudent(alumnoME1);
            maestro.goToClass(estudiante); 
            estudiante = new AdapterStudent(alumnoME2);
            maestro.goToClass(estudiante);

            maestro.teachingAClass();

            // ---------------------------------------------------------------------------------------------------------------------



        }
    }
}
