using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Impresiones
{
    class Main
    {
        public static void Run()
        {
            Cola C_personas = new Cola();
            Cola C_alumnos = new Cola();
            Pila P_personas = new Pila();
            Pila P_alumnos = new Pila();

            llenarAlumnos(C_alumnos);
            llenarAlumnos(P_alumnos);
            llenarPersonas(P_personas);
            llenarPersonas(C_personas);

            ColeccionMultiple CM_personas = new ColeccionMultiple(P_personas, C_personas);
            ColeccionMultiple CM_alumnos = new ColeccionMultiple(P_alumnos, C_alumnos);

            informarPersonas(CM_personas);
            informarPersonas(CM_alumnos);
        }

        public static void Run2()
        {
            //Ejercicio 8

            Pila newPila = new Pila();
            Cola newCola = new Cola();
            Conjunto newConjunto = new Conjunto();
            Diccionario newDiccionario = new Diccionario();

            llenarAlumnos(newPila);
            llenarAlumnos(newCola);
            llenarAlumnos((IColeccionable<Persona>)newConjunto);
            //llenarAlumnos((IColeccionable<Persona>)newDiccionario);
            llenarAlumnosDiccionario(newDiccionario);
            Console.WriteLine("Pila: ");
            Patron_Iterator.Main.imprimirElementos(newPila);
            Console.WriteLine("Cola: ");
            Patron_Iterator.Main.imprimirElementos(newCola);
            Console.WriteLine("Conjunto: ");
            Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newConjunto);
            Console.WriteLine("Diccionario: ");
            Patron_Iterator.Main.imprimirElementosDiccionario(newDiccionario);


        }

        public static void Run3()
        {
            //------------------------------------------- Ejercicio 10 ------------------------------------------
            Pila newPila = new Pila();
            llenarAlumnos(newPila);
            Patron_Strategy.Main.cambioEstrategia(newPila,new StratComparacion_Nombre());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_DNI());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_Legajo());
            informar(newPila);

            Patron_Strategy.Main.cambioEstrategia(newPila, new StratComparacion_Promedio());
            informar(newPila);

            //----------------------------------------------------------------------------------------------------
            // Para validar los 20 objetos, desconectar las siguientes dos lineas
            //Console.WriteLine();
            //Patron_Iterator.Main.imprimirElementos(newPila);


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
        public static void llenarAlumnos(IColeccionable<Persona> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
                coleccion.agregar(unAlumno);
            }
        }
        public static void llenarAlumnosDiccionario(IColeccionable<ClaveValor> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Alumno unAlumno = new Alumno(generar.Gen_Nombre(), generar.Gen_DNI(), generar.Gen_Legajo(), generar.Gen_Promedio());
                ((Diccionario)coleccion).agregar(unAlumno);
                //coleccion.agregar(unAlumno);
            }
        }
        public static void llenarPersonas(IColeccionable<Persona> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Persona unaPersona = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
                coleccion.agregar(unaPersona);
            }
        }

        public static void informar(IColeccionable<Persona> coleccion)
        {
            Alumno maximo = (Alumno)coleccion.maximo();
            Alumno minimo = (Alumno)coleccion.minimo();
            Console.WriteLine("Elementos de la Coleccion:\n" +
                "Maximo:\n\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}\n" +
                "Minimo:\n\tAlumno: {4}\tDNI: {5}\tLegajo: {6}\tPromedio: {7}",
                     maximo.Nombre, maximo.DNI, maximo.Legajo, maximo.Promedio,
                     minimo.Nombre, minimo.DNI, minimo.Legajo, minimo.Promedio);
        }

        
    }
}
