using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;

namespace MetProgI.Patron_Strategy
{
    public class Main
    {
        public static void Run(int TipoEstrategia)
        {
            Generar generar = new Generar();
            //List<Persona> personas = new List<Persona>();
            //List<Persona> alumnos = new List<Persona>();
            IColeccionable<I_Comparable> personas = new Cola();
            IColeccionable<I_Comparable> alumnos = new Pila();
            //--------------------- Creacion de algunas Personas
            Persona p1 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p2 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p3 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p4 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p5 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p6 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p7 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p8 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            Persona p9 = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
            //--------------------- Fin de creacion de Personas
            personas.agregar(p1); personas.agregar(p2); personas.agregar(p3); personas.agregar(p4); personas.agregar(p5); personas.agregar(p6);
            personas.agregar(p7); personas.agregar(p8); personas.agregar(p9);

            //--------------------- Creacion de algunas Alumnos
            Alumno a1 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a2 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a3 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a4 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a5 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a6 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a7 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a8 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            Alumno a9 = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
            //--------------------- Fin de creacion de Alumnos

            alumnos.agregar(a1); alumnos.agregar(a2); alumnos.agregar(a3); alumnos.agregar(a4); alumnos.agregar(a5); alumnos.agregar(a6); alumnos.agregar(a7);
            alumnos.agregar(a8); alumnos.agregar(a9);

            switch (TipoEstrategia)
            {
                case 1:
                    break;
                case 2:
                    cambioEstrategia(personas, new StratComparacion_DNI());
                    //cambioEstrategia((IColeccionable<Persona>)personas, new StratComparacion_DNI());
                    //cambioEstrategia((IColeccionable<Persona>)alumnos, new StratComparacion_DNI());
                    cambioEstrategia(alumnos, new StratComparacion_DNI());
                    break;
                case 3:
                    cambioEstrategia(personas, new StratComparacion_Legajo());
                    //cambioEstrategia((IColeccionable<Persona>)personas, new StratComparacion_Legajo());
                    //cambioEstrategia((IColeccionable<Persona>)alumnos, new StratComparacion_Legajo());
                    cambioEstrategia(alumnos, new StratComparacion_Legajo());
                    break;
                case 4:
                    cambioEstrategia(personas, new StratComparacion_Promedio());
                    //cambioEstrategia((IColeccionable<Persona>)personas, new StratComparacion_Promedio());
                    //cambioEstrategia((IColeccionable<Persona>)alumnos, new StratComparacion_Promedio());
                    cambioEstrategia(alumnos, new StratComparacion_Promedio());
                    break;
            }

            Console.WriteLine("Comparamos a1 con a2: \n" +
                              "sosIgual: " + a1.sosIgual(a2) + "\n" +
                              "sosMenor: " + a1.sosMenor(a2) + "\n" +
                              "sosMayor: " + a1.sosMayor(a2) + "\n\n" +
                              "Comparamos a3 con a4: \n" +
                              "sosIgual: " + a3.sosIgual(a4) + "\n" +
                              "sosMenor: " + a3.sosMenor(a4) + "\n" +
                              "sosMayor: " + a3.sosMayor(a4) + "\n\n" +
                              "Comparamos a5 con a6: \n" +
                              "sosIgual: " + a5.sosIgual(a6) + "\n" +
                              "sosMenor: " + a5.sosMenor(a6) + "\n" +
                              "sosMayor: " + a5.sosMayor(a6) + "\n\n"
                              );
            if (!TipoEstrategia.Equals(3) && !TipoEstrategia.Equals(4))
            {
                Console.WriteLine("Comparamos p1 con p2: \n" +
                                  "sosIgual: " + p1.sosIgual(p2) + "\n" +
                                  "sosMenor: " + p1.sosMenor(p2) + "\n" +
                                  "sosMayor: " + p1.sosMayor(p2) + "\n\n" +
                                  "Comparamos p3 con p4: \n" +
                                  "sosIgual: " + p3.sosIgual(p4) + "\n" +
                                  "sosMenor: " + p3.sosMenor(p4) + "\n" +
                                  "sosMayor: " + p3.sosMayor(p4) + "\n\n" +
                                  "Comparamos p5 con p6: \n" +
                                  "sosIgual: " + p5.sosIgual(p6) + "\n" +
                                  "sosMenor: " + p5.sosMenor(p6) + "\n" +
                                  "sosMayor: " + p5.sosMayor(p6) + "\n\n"
                                  );
            }
        }

        // Cambio de estrategia implementado por mi, antes de implementar el patron "Iterator"
        //public static void cambioEstrategia(List<Persona> personas, IStrategy<Persona> estrategia)
        //{
        //    for (int i = 0; i < personas.Count; i++)
        //    {
        //        personas[i].Estrategia = estrategia;
        //    }
        //}

        // ----------------------------------------- Ejercicio 9 ------------------------------------------------
        public static void cambioEstrategia(IColeccionable<I_Comparable> personas, IStrategy<Persona> estrategia)
        {
            IIterator iter = personas.CreateIterator();

            while(!iter.EsFin())
            {
                Persona unaPersona = (Persona)iter.Siguiente();
                unaPersona.Estrategia = estrategia;
            }
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
