using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;
using MetProgI.Patron_FactoryMethod;
using MetProgI.Patron_Observer;

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

            Patron_Strategy.Main.cambioEstrategia(C_personas,new StratComparacion_DNI());
            Patron_Strategy.Main.cambioEstrategia(C_alumnos, new StratComparacion_DNI());
            Patron_Strategy.Main.cambioEstrategia(P_personas, new StratComparacion_DNI());
            Patron_Strategy.Main.cambioEstrategia(P_alumnos, new StratComparacion_DNI());

            ColeccionMultiple CM_personas = new ColeccionMultiple(P_personas, C_personas);
            ColeccionMultiple CM_alumnos = new ColeccionMultiple(P_alumnos, C_alumnos);

            Console.Clear();
            Console.WriteLine("Pila y Cola de Personas:\n");
            informarPersonas(CM_personas);
            Console.ReadKey(); 
            Console.Clear();
            Console.WriteLine("Pila y Cola de Alumnos:\n");
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
            llenarAlumnos(newConjunto);
            llenarAlumnos(newDiccionario);
            //llenarAlumnosDiccionario(newDiccionario);
            Console.WriteLine("Pila: ");
            //Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newPila);
            Patron_Iterator.Main.imprimirElementos(newPila);
            Console.WriteLine("Cola: ");
            //Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newCola);
            Patron_Iterator.Main.imprimirElementos(newCola);
            Console.WriteLine("Conjunto: ");
            //Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newConjunto);
            Patron_Iterator.Main.imprimirElementos(newConjunto);
            Console.WriteLine("Diccionario: ");
            //Patron_Iterator.Main.imprimirElementos((IColeccionable<Persona>)newDiccionario);
            Patron_Iterator.Main.imprimirElementos(newDiccionario);
            //Patron_Iterator.Main.imprimirElementosDiccionario(newDiccionario);


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

        public static void Run4()
        {
            // Verificacion del ejercicio 6 practica 3

            // ------------------------------------- Llenar Pila --------------------------------------------------------------
            Pila newPila = new Pila();
            Console.Clear();
            Console.WriteLine("1) Persona. \n" +
                              "2) Alumno. \n" +
                              "3) Numero. \n");

            Console.Write("Por favor, ingrese que tipo de Comparable desea crear para llenar la Pila: ");
            int eleccion_p = new LectorDeDatos().numeroPorTeclado();
            llenar(newPila, eleccion_p);
            //Console.Write("\nDesea mostrar los elementos que se generaron? (S/N): ");
            //string eleccion_str = new LectorDeDatos().stringPorTeclado();
            //if ("S".Equals(eleccion_str.ToUpper()))
            //{
            //    Console.WriteLine("La Pila se llenó con los siguientes elementos: ");
            //}
            // ------------------------------------------------------------------------------------------------------------------

            //-----------------------------------Llenar Cola --------------------------------------------------------------------
            Cola newCola = new Cola();
            Console.Clear();
            Console.WriteLine("1) Persona. \n" +
                              "2) Alumno. \n" +
                              "3) Numero. \n");
            
            Console.Write("Por favor, ingrese que tipo de Comparable desea crear para llenar la Cola: ");
            int eleccion_c = new LectorDeDatos().numeroPorTeclado();
            llenar(newCola, eleccion_c);
            //Console.Write("\nDesea mostrar los elementos que se generaron? (S/N): ");
            //eleccion_str = new LectorDeDatos().stringPorTeclado();
            //if ("S".Equals(eleccion_str.ToUpper()))
            //{
            //    Console.WriteLine("La Cola se llenó con los siguientes elementos: ");
            //    informar(newCola, eleccion);
            //}
            // --------------------------------------------------------------------------------------------------------------------

            // --------------------------------- Llenar Conjunto ------------------------------------------------------------------
            Conjunto newConjunto = new Conjunto();
            Console.Clear();
            Console.WriteLine("1) Persona. \n" +
                              "2) Alumno. \n" +
                              "3) Numero. \n");

            Console.Write("Por favor, ingrese que tipo de Comparable desea crear para llenar el Conjunto: ");
            int eleccion_cj = new LectorDeDatos().numeroPorTeclado();
            llenar(newConjunto, eleccion_cj);
            //Console.Write("\nDesea mostrar los elementos que se generaron? (S/N): ");
            //eleccion_str = new LectorDeDatos().stringPorTeclado();
            //if ("S".Equals(eleccion_str.ToUpper()))
            //{
            //    Console.WriteLine("El Conjunto se llenó con los siguientes elementos: ");
            //    informar(newConjunto, eleccion);
            //}
            // --------------------------------------------------------------------------------------------------------------------

            // --------------------------- Llenar Diccionario ---------------------------------------------------------------------
            Diccionario newDiccionario = new Diccionario();
            Console.Clear();
            Console.WriteLine("1) Persona. \n" +
                              "2) Alumno. \n" +
                              //"3) ClaveValor (Este comparable es compuesto por Numero como Clave y Persona como Valor). \n" +
                              "3) Numero. \n");

            Console.Write("Por favor, ingrese que tipo de Comparable desea crear para llenar el Diccionario: ");
            int eleccion_d = new LectorDeDatos().numeroPorTeclado();
            llenar(newDiccionario, eleccion_d);
            //Console.Write("\nDesea mostrar los elementos que se generaron? (S/N): ");
            //eleccion_str = new LectorDeDatos().stringPorTeclado();
            //if ("S".Equals(eleccion_str.ToUpper()))
            //{
            //    Console.WriteLine("El Diccionario se llenó con los siguientes elementos: ");
            //    informar(newDiccionario, eleccion);
            //}

            //---------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Informar Pila ----------------------------------------------------------
            Console.Clear();
            informar(newPila,eleccion_p);
            Console.ReadKey();
            // --------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Informar Cola ----------------------------------------------------------
            Console.Clear(); 
            informar(newCola, eleccion_c);
            Console.ReadKey();
            // --------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Informar Conjunto ----------------------------------------------------------
            Console.Clear(); 
            informar(newConjunto, eleccion_cj);
            Console.ReadKey();
            // --------------------------------------------------------------------------------------------------------------------

            // ------------------------------------------- Informar Diccionario ----------------------------------------------------------
            //  ------------- Arreglar el informar para Diccionario.
            //Console.Clear(); 
            //informar(newDiccionario, eleccion_d);
            //Console.ReadKey();
            // --------------------------------------------------------------------------------------------------------------------
        }

        public static void Run5()
        {
            Cola newCola = new Cola();
            llenar(newCola, 5);
            informar(newCola,5);
        }

        public static void informarPersonas(ColeccionMultiple inColeccionable)
        {
            Persona minimo = (Persona)inColeccionable.minimo();
            Persona maximo = (Persona)inColeccionable.maximo();
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos(0)[0] + "\n" +
                              "La cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos(0)[1] + "\n" +
                              "La Persona con menor numero de DNI entre la Cola y la Pila es: " + minimo.DNI + "\n" +
                              "La Persona con mayor numero de DNI entre la Cola y la Pila es: " + maximo.DNI
                             );
            Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            newElemento.Estrategia = new StratComparacion_DNI();
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("\nEl elemento leido esta en la coleccion");
            else
                Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
        }
        public static void llenarAlumnos(IColeccionable<I_Comparable> coleccion)
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
        public static void llenarPersonas(IColeccionable<I_Comparable> coleccion)
        {
            Generar generar = new Generar();
            for (int i = 0; i < 20; i++)
            {
                Persona unaPersona = new Persona(generar.Gen_Nombre(), generar.Gen_DNI());
                coleccion.agregar(unaPersona);
            }
        }
        public static void informar(IColeccionable<I_Comparable> coleccion)
        {
            // Ejercicio 10 practica 2
            Alumno maximo = (Alumno)coleccion.maximo();
            Alumno minimo = (Alumno)coleccion.minimo();
            Console.WriteLine("Elementos de la Coleccion:\n" +
                "Maximo:\n\tAlumno: {0}\tDNI: {1}\tLegajo: {2}\tPromedio: {3}\n" +
                "Minimo:\n\tAlumno: {4}\tDNI: {5}\tLegajo: {6}\tPromedio: {7}",
                     maximo.Nombre, maximo.DNI, maximo.Legajo, maximo.Promedio,
                     minimo.Nombre, minimo.DNI, minimo.Legajo, minimo.Promedio);
        }

        public static void llenar(IColeccionable<I_Comparable> coleccion, int eleccion)
        {
            //Ejercicio 6 practica 3
            // Elecciones: Persona(1) / Alumno(2) / ClaveValor(3) / Numero(4)
            switch(eleccion)
            {
                case 1:
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.agregar(new Persona(new GeneradorDeDatosAleatorios().stringAleatorio(15), new GeneradorDeDatosAleatorios().numeroAleatorio(44000000)));
                    }
                    break;
                case 2:
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.agregar(new FabricaAlumno().crearAleatorio()) ;
                    }
                    break;
                //case 3:
                //    for (int i = 0; i < 20; i++)
                //    {
                //        coleccion.agregar(new FabricaClaveValor().crearAleatorio());
                //    }
                //    break;
                case 3:
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.agregar(new FabricaNumero().crearAleatorio());
                    }
                    break;
                case 5: // Ejercicio 6 Practica 3: Implemente una fábrica concreta para la clase Vendedor y compruebe el correcto funcionamiento del método main del ejercicio 6.Compare a los vendedores por el campo bonus.
                    for (int i = 0; i < 20; i++)
                    {
                        coleccion.agregar(new FabricaVendedor().crearAleatorio());
                    }
                    break;
                default:
                    break;
            }
        }

        public static void informar(IColeccionable<I_Comparable> coleccion, int opcion)
        {
            // Ejercicio 6 practica 3
            // Elecciones: Persona(1) / Alumno(2) / ClaveValor(3) / Numero(4)
            
            switch (opcion)
            {
                case 1:
                    Persona maximo_p = (Persona)coleccion.maximo();
                    Persona minimo_p = (Persona)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Coleccion: {0}\n" +
                        "Maximo:\n\tNombre: {1}\tDNI: {2}\n" +
                        "Minimo:\n\tNombre: {3}\tDNI: {4}",
                             coleccion.cuantos(),
                             maximo_p.Nombre, maximo_p.DNI,
                             minimo_p.Nombre, minimo_p.DNI);
                    Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
                    int input = new LectorDeDatos().numeroPorTeclado();
                    Persona newElemento = new Persona("Usuario", input);
                    newElemento.Estrategia = new StratComparacion_DNI();
                    if (coleccion.contiene(newElemento))
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                    else
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                    break;
                case 2:
                    Alumno maximo_a = (Alumno)coleccion.maximo();
                    Alumno minimo_a = (Alumno)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Coleccion: {0}\n" +
                        "Maximo:\n\tAlumno: {1}\tDNI: {2}\tLegajo: {3}\tPromedio: {4}\n" +
                        "Minimo:\n\tAlumno: {5}\tDNI: {6}\tLegajo: {7}\tPromedio: {8}",
                             coleccion.cuantos(),
                             maximo_a.Nombre, maximo_a.DNI, maximo_a.Legajo, maximo_a.Promedio,
                             minimo_a.Nombre, minimo_a.DNI, minimo_a.Legajo, minimo_a.Promedio);
                    Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
                    input = new LectorDeDatos().numeroPorTeclado();
                    newElemento = new Persona("Usuario", input);
                    newElemento.Estrategia = new StratComparacion_DNI();
                    if (coleccion.contiene(newElemento))
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                    else
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                    break;
                //case 3:
                //    ClaveValor maximo_cv = (ClaveValor)coleccion.maximo();
                //    ClaveValor minimo_cv = (ClaveValor)coleccion.minimo();
                //    Console.WriteLine("Cantidad de Elementos de la Coleccion: {0}\n" +
                //        "Maximo:\n\tNombre: {1}\tDNI: {2}\n" +
                //        "Minimo:\n\tNombre: {3}\tDNI: {4}",
                //             coleccion.cuantos(),
                //             ((Persona)maximo_cv.valor).Nombre, ((Persona)maximo_cv.valor).DNI,
                //             ((Persona)minimo_cv.valor).Nombre, ((Persona)minimo_cv.valor).DNI);
                //    Console.Write("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
                //    input = new LectorDeDatos().numeroPorTeclado();
                //    newElemento = new Persona("Usuario", input);
                //    newElemento.Estrategia = new StratComparacion_DNI();
                //    if (coleccion.contiene(newElemento))
                //        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                //    else
                //        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                //    break;
                case 3:
                    Numero maximo_nro = (Numero)coleccion.maximo();
                    Numero minimo_nro = (Numero)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Coleccion: {0}\n" +
                        "Maximo:\n\tNumero: {1}\n" +
                        "Minimo:\n\tNumero: {2}\n",
                             coleccion.cuantos(),
                             maximo_nro.Valor, minimo_nro.Valor);
                    Console.Write("\nPor favor, ingrese un Numero para saber si se encuentra dentro de la coleccion: ");
                    input = new LectorDeDatos().numeroPorTeclado();
                    Numero newElemento_nro = new Numero(input);
                    //newElemento_nro.Estrategia = new StratComparacion_DNI();
                    if (coleccion.contiene(newElemento_nro))
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                    else
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                    break;

                case 5:
                    Vendedor maximo_vend = (Vendedor)coleccion.maximo();
                    Vendedor minimo_vend = (Vendedor)coleccion.minimo();
                    Console.WriteLine("Cantidad de Elementos de la Coleccion: {0}\n" +
                        "Maximo:\n\tNombre: {1}\n" +
                        "Minimo:\n\tNombre: {2}\n",
                             coleccion.cuantos(),
                             maximo_vend.Nombre, minimo_vend.Nombre);
                    Console.Write("\nPor favor, ingrese puntos de Bonus para saber si se encuentra dentro de la coleccion: ");
                    double puntos = Convert.ToDouble(Console.ReadLine());
                    Vendedor newElemento_vend = new Vendedor(new GeneradorDeDatosAleatorios().stringAleatorio(15),
                                                             new GeneradorDeDatosAleatorios().numeroAleatorio(44000000),
                                                             new GeneradorDeDatosAleatorios().numeroAleatorio(60000));
                    newElemento_vend.Bonus = puntos;//Comentando esta linea de codigo, entrará en el if (considerando que primero, el vendedor, debe 
                                                    //sumar ventas antes de ser comparado, ya que todos comienzan con puntos de bonus en 1.0)
                                                    //A menos que el usuario ingrese los puntos 1.0

                    //newElemento_nro.Estrategia = new StratComparacion_DNI();
                    if (coleccion.contiene(newElemento_vend))
                        Console.WriteLine("\nEl elemento leido esta en la coleccion");
                    else
                        Console.WriteLine("\nEl elemento leido no se encuentra en la coleccion");
                    break;
                default:
                    break;
            }
        }


    }
}
