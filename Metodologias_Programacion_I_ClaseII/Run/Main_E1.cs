using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_Programacion_I_ClaseII.Generador_Random;
using Metodologias_Programacion_I_ClaseII.PatronIterator;

namespace Metodologias_Programacion_I_ClaseII.Run
{
    class Main_E1 : IRun
    {
        public void Main(int TipoEstrategia)
        {
            //pruebaUnitaria(TipoEstrategia);
            //ejercicio_2();
            

        }

        public void cambioEstrategia(List<Persona> personas, IStrategy<Humano> estrategia)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                personas[i].Estrategia = estrategia;
            }
        }

        public void cambioEstrategia(List<Alumno> personas, IStrategy<Humano> estrategia)
        {
            for (int i = 0; i < personas.Count; i++)
            {
                personas[i].Estrategia = estrategia;
            }
        }

        public void llenarPersonas(Pila pila, Cola cola)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Persona unaPersona = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
                pila.agregar(unaPersona);
                cola.agregar(unaPersona);
            }
        }
        public static void llenarAlumnos(Cola cola )
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
                cola.agregar(unAlumno);
            }
        }

        public static void llenarAlumnos(Coleccionable pila)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
                pila.agregar((Persona)unAlumno);
            }
        }

        public static void informarPersonas(ColeccionMultiple inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos(0)[0] + "\n" +
                              "La cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos(0)[1] + "\n" +
                              "La Persona con menor numero de DNI entre la Cola y la Pila es: " + inColeccionable.minimo().DNI + "\n" +
                              "La Persona con mayor numero de DNI entre la Cola y la Pila es: " + inColeccionable.maximo().DNI
                             );
            Console.WriteLine("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public void pruebaUnitaria(int TipoEstrategia)
        {
            Generar generar = new Generar();
            List<Persona> personas = new List<Persona>();
            List<Alumno> alumnos = new List<Alumno>();
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
            personas.Add(p1); personas.Add(p2); personas.Add(p3); personas.Add(p4); personas.Add(p5); personas.Add(p6);
            personas.Add(p7); personas.Add(p8); personas.Add(p9);

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

            alumnos.Add(a1); alumnos.Add(a2); alumnos.Add(a3); alumnos.Add(a4); alumnos.Add(a5); alumnos.Add(a6); alumnos.Add(a7);
            alumnos.Add(a8); alumnos.Add(a9);

            switch (TipoEstrategia)
            {
                case 1:
                    break;
                case 2:
                    cambioEstrategia(personas, new StratComparacion_DNI());
                    cambioEstrategia(alumnos, new StratComparacion_DNI());
                    break;
                case 3:
                    cambioEstrategia(personas, new StratComparacion_Legajo());
                    cambioEstrategia(alumnos, new StratComparacion_Legajo());
                    break;
                case 4:
                    cambioEstrategia(personas, new StratComparacion_Promedio());
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
        public void ejercicio2()
        {
            //--------------------------------------------   Ejercicio 2 -----------------------------------------------
            Cola C_personas = new Cola();
            Cola C_alumnos = new Cola();
            Pila P_personas = new Pila();
            Pila P_alumnos = new Pila();

            llenarAlumnos(C_alumnos);
            llenarAlumnos(P_alumnos);
            llenarPersonas(P_personas, C_personas);

            ColeccionMultiple CM_personas = new ColeccionMultiple(P_personas, C_personas);
            ColeccionMultiple CM_alumnos = new ColeccionMultiple(P_alumnos, C_alumnos);

            informarPersonas(CM_personas);
            informarPersonas(CM_alumnos);


            //----------------------------------------------------------------------------------------------------------
        }

        public void ejercicio7(Coleccionable unaCola)
        {
            llenarAlumnos(unaCola);
            IIterator iter = unaCola.CreateIterator();
            while (!iter.EsFin())
            {
                Alumno elemento = (Alumno)iter.Siguiente();
                Console.WriteLine("Alumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}",
                     elemento.Nombre, elemento.DNI, elemento.Legajo, elemento.Promedio);
            }
        }
    }
}
