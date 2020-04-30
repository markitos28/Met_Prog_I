using System;
using System.Collections.Generic;
using Metodologias_Programacion_I.Parte_I;
using Metodologias_Programacion_I.Parte_II;

namespace Metodologias_Programacion_I
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------Elija la Opcion que quiera ejecutar --------------\n");
            Console.WriteLine("1) ");
            // Test Ejercicio 9:

            //Parte_I.Cola newcola = new Parte_I.Cola();
            //Parte_I.Pila newpila = new Parte_I.Pila();
            //llenar(newcola);
            //llenar(newpila);
            //Parte_I.ColeccionMultiple newColeccion = new Parte_I.ColeccionMultiple(newpila, newcola);
            //informar(newcola);
            //informar(newpila);
            //informar(newColeccion);

            ///*
            // Respuesta al ejercicio 10:
            // He tenido que modificar el procedimiento "informar".
            //*/

            //Test Ejercicio 13:
            //Parte_II.Cola newcola2 = new Parte_II.Cola();
            //Parte_II.Pila newpila2 = new Parte_II.Pila();
            //llenarPersonas(newcola2);
            //llenarPersonas(newpila2);
            //Parte_II.ColeccionMultiple newColeccion2 = new Parte_II.ColeccionMultiple(newpila2, newcola2);
            //informarPersonas(newcola2);
            //informarPersonas(newpila2);
            //informarPersonas(newColeccion2);

            //Test Ejercicio 17:
            //Parte_II.Cola newcola3 = new Parte_II.Cola();
            //Parte_II.Pila newpila3 = new Parte_II.Pila();
            //llenarAlumnos(newcola3);
            //llenarAlumnos(newpila3);
            //Parte_II.ColeccionMultiple newColeccion3 = new Parte_II.ColeccionMultiple(newpila3, newcola3);
            //informarPersonas(newcola3);
            //informarPersonas(newpila3);
            //informarPersonas(newColeccion3);
            //Console.WriteLine("Por favor ");

            // Test Ejercicio 18:

            Parte_II.Cola newcola4 = new Parte_II.Cola();
            Parte_II.Pila newpila4 = new Parte_II.Pila();
            byte eleccionUsuario;
            int in_legajo;
            float in_promedio;
            llenarAlumnos(newcola4);
            llenarAlumnos(newpila4);
            Parte_II.ColeccionMultiple newColeccion4 = new Parte_II.ColeccionMultiple(newpila4, newcola4);
            
            try 
            {
                do
                {
                    Console.Clear(); 
                    Console.WriteLine("------- Alumno, por favor ingrese la opcion por la que desea compararse -------");
                    Console.WriteLine("1) Por Legajo. \n" +
                                       "2) Por Promedio.");
                    eleccionUsuario = Convert.ToByte(Console.ReadLine());
                }
                while (eleccionUsuario != 1 & eleccionUsuario!=2);

                if (eleccionUsuario.Equals(1))
                {
                    Console.WriteLine("Alumno, ingrese su legajo:");
                    in_legajo = Convert.ToInt32(Console.ReadLine());
                    Alumno nuevoUsuario = new Alumno("Usuario Temporal",0, in_legajo, 0);
                    for(int i=0; i<newcola4.cuantos();i++)
                    {
                        Alumno uxu = (Alumno)newcola4.pop();
                        if(nuevoUsuario.sosIgual(uxu))
                        {
                            Console.WriteLine("Alumno, usted ya se encuentra ingresado en el sistema");
                        }
                        else if (nuevoUsuario.sosMenor(uxu))
                        {
                            Console.WriteLine("Alumno, usted posee un legajo menor a {0}", uxu.Legajo);
                        }
                        else if (nuevoUsuario.sosMayor(uxu))
                        {
                            Console.WriteLine("Alumno, usted posee un legajo mayor a {0}", uxu.Legajo);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Alumno, ingrese su promedio:");
                    in_promedio = (float)Convert.ToDouble(Console.ReadLine());
                    Alumno nuevoUsuario = new Alumno("Usuario Temporal", 0, 0, in_promedio);
                    for (int i = 0; i < newcola4.cuantos(); i++)
                    {
                        Alumno uxu = (Alumno)newcola4.pop();
                        if (nuevoUsuario.sosIgual(uxu))
                        {
                            Console.WriteLine("Alumno, usted ya se encuentra ingresado en el sistema");
                        }
                        else if (nuevoUsuario.sosMenor(uxu))
                        {
                            Console.WriteLine("Alumno, usted posee un promedio menor a {0}", uxu.Promedio);
                        }
                        else if (nuevoUsuario.sosMayor(uxu))
                        {
                            Console.WriteLine("Alumno, usted posee un promedio mayor a {0}", uxu.Promedio);
                            
                        }

                    }
                }
            }
            
            
            catch (OverflowException) 
            {
                Console.WriteLine("Ha roto el codigo por insertar un numero muy alto. Elija con cuidado. \n\n\n-----Adios-----"); 
            }
            
            //--------------------- Fin del Test -----------------------------------

        }

        public static void informar(Parte_I.Cola inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos() + "\n" +
                              "La el Numero minimo que existe en la Cola es: " + inColeccionable.minimo().Valor + "\n" +
                              "La el Numero maximo que existe en la Cola es: " + inColeccionable.maximo().Valor
                             );
            Console.WriteLine("\nPor favor, ingrese un numero para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Numero newElemento = new Numero(input);
            if (inColeccionable.contiene(newElemento).Equals(true))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public static void informar(Parte_I.Pila inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Pila son :" + inColeccionable.cuantos() + "\n" +
                              "La el Numero minimo que existe en la Pila es: " + inColeccionable.minimo().Valor + "\n" +
                              "La el Numero maximo que existe en la Pila es: " + inColeccionable.maximo().Valor
                             );
            Console.WriteLine("\nPor favor, ingrese un numero para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Numero newElemento = new Numero(input);
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public static void informar(Parte_I.ColeccionMultiple inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos(0)[0] + "\n" +
                              "La cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos(0)[1] + "\n" +
                              "El Numero minimo que existe entre la Cola y la Pila es: " + inColeccionable.minimo().Valor + "\n" +
                              "El Numero maximo que existe entre la Cola y la Pila es: " + inColeccionable.maximo().Valor
                             );
            Console.WriteLine("\nPor favor, ingrese un numero para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Numero newElemento = new Numero(input);
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public static void llenar(Parte_I.Cola LPC)
        {
            Random alAzar = new Random();
            Numero valor;
            for(int i=0; i<20; i++)
            {
                valor = new Numero(alAzar.Next(-10000,10000));
                LPC.agregar(valor);
            }
        }

        public static void llenar(Parte_I.Pila LPC)
        {
            Random alAzar = new Random();
            Numero valor;
            for (int i = 0; i < 20; i++)
            {
                valor = new Numero(alAzar.Next(-10000, 10000));
                LPC.agregar(valor);
            }
        }
        //---------------------------------------------------------------------------------------
        public static void llenarPersonas(Parte_II.Cola LPC)
        {
            List<string> nombresAlAzar = new List<string> { "JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE","FRANCISCO","GUADALUPE","MARÍA","JUANA","ANTONIO","JESÚS","MIGUEL ÁNGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA",
                                                            "MARÍA DEL CARMEN","JUAN CARLOS","ROBERTO","FERNANDO","DANIEL","CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL","MARTÍN","RAÚL","DAVID",
                                                            "JOSEFINA","JOSÉ ANTONIO","ARTURO","MARCO ANTONIO","JOSÉ MANUEL","FRANCISCO JAVIER","ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA","LETICIA","ROSA","MARIO",
                                                            "FRANCISCA","ALFREDO","TERESA","ALICIA","MARÍA FERNANDA","SERGIO","ALBERTO"};
            Persona ciudadano;
            Random rnd_nom = new Random();
            Random rnd_dni = new Random();
            for(int i=0; i< 20;i++)
            {
                int indice_nom=rnd_nom.Next(nombresAlAzar.Count);
                int dni = rnd_dni.Next(36000000,43000000);
                ciudadano = new Persona(nombresAlAzar[indice_nom], dni);
                LPC.agregar(ciudadano);
            }
        }

        public static void llenarPersonas(Parte_II.Pila LPC)
        {
            List<string> nombresAlAzar = new List<string> { "JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE","FRANCISCO","GUADALUPE","MARÍA","JUANA","ANTONIO","JESÚS","MIGUEL ÁNGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA",
                                                            "MARÍA DEL CARMEN","JUAN CARLOS","ROBERTO","FERNANDO","DANIEL","CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL","MARTÍN","RAÚL","DAVID",
                                                            "JOSEFINA","JOSÉ ANTONIO","ARTURO","MARCO ANTONIO","JOSÉ MANUEL","FRANCISCO JAVIER","ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA","LETICIA","ROSA","MARIO",
                                                            "FRANCISCA","ALFREDO","TERESA","ALICIA","MARÍA FERNANDA","SERGIO","ALBERTO"};
            Persona ciudadano;
            Random rnd_nom = new Random();
            Random rnd_dni = new Random();
            for (int i = 0; i < 20; i++)
            {
                int indice_nom = rnd_nom.Next(nombresAlAzar.Count);
                int dni = rnd_dni.Next(36000000, 43000000);
                ciudadano = new Persona(nombresAlAzar[indice_nom], dni);
                LPC.agregar(ciudadano);
            }
        }

        public static void llenarAlumnos(Parte_II.Cola LPC)
        {
            List<string> nombresAlAzar = new List<string> { "JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE","FRANCISCO","GUADALUPE","MARÍA","JUANA","ANTONIO","JESÚS","MIGUEL ÁNGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA",
                                                            "MARÍA DEL CARMEN","JUAN CARLOS","ROBERTO","FERNANDO","DANIEL","CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL","MARTÍN","RAÚL","DAVID",
                                                            "JOSEFINA","JOSÉ ANTONIO","ARTURO","MARCO ANTONIO","JOSÉ MANUEL","FRANCISCO JAVIER","ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA","LETICIA","ROSA","MARIO",
                                                            "FRANCISCA","ALFREDO","TERESA","ALICIA","MARÍA FERNANDA","SERGIO","ALBERTO"};
            Alumno universitario;
            Random rnd_nom = new Random();
            Random rnd_dni = new Random();
            Random rnd_legajo = new Random();
            Random rnd_promedio = new Random();
            for (int i = 0; i < 20; i++)
            {
                int indice_nom = rnd_nom.Next(nombresAlAzar.Count);
                int dni = rnd_dni.Next(36000000, 43000000);
                int legajo = rnd_legajo.Next(0, 20000);
                float promedio = (float)Math.Round(rnd_promedio.Next(0, 10) + (float)rnd_promedio.NextDouble(),2);
                //float promedio = (float)rnd_promedio.NextDouble();
                universitario = new Alumno(nombresAlAzar[indice_nom], dni, legajo, promedio);
                LPC.agregar(universitario);
            }
        }

        public static void llenarAlumnos(Parte_II.Pila LPC)
        {
            List<string> nombresAlAzar = new List<string> { "JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE","FRANCISCO","GUADALUPE","MARÍA","JUANA","ANTONIO","JESÚS","MIGUEL ÁNGEL","PEDRO","ALEJANDRO","MANUEL","MARGARITA",
                                                            "MARÍA DEL CARMEN","JUAN CARLOS","ROBERTO","FERNANDO","DANIEL","CARLOS","JORGE","RICARDO","MIGUEL","EDUARDO","JAVIER","RAFAEL","MARTÍN","RAÚL","DAVID",
                                                            "JOSEFINA","JOSÉ ANTONIO","ARTURO","MARCO ANTONIO","JOSÉ MANUEL","FRANCISCO JAVIER","ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA","LETICIA","ROSA","MARIO",
                                                            "FRANCISCA","ALFREDO","TERESA","ALICIA","MARÍA FERNANDA","SERGIO","ALBERTO"};
            Alumno universitario;
            Random rnd_nom = new Random();
            Random rnd_dni = new Random();
            Random rnd_legajo = new Random();
            Random rnd_promedio = new Random();
            for (int i = 0; i < 20; i++)
            {
                int indice_nom = rnd_nom.Next(nombresAlAzar.Count);
                int dni = rnd_dni.Next(36000000, 43000000);
                int legajo = rnd_legajo.Next(0, 20000);
                float promedio = rnd_promedio.Next(0,10) + (float)rnd_promedio.NextDouble();
                universitario = new Alumno(nombresAlAzar[indice_nom], dni, legajo, promedio );
                LPC.agregar(universitario);
            }
        }

        public static void informarPersonas(Parte_II.Cola inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos() + "\n" +
                              "La Persona con menor numero de DNI en la Cola es: " + inColeccionable.minimo().DNI + "\n" +
                              "La Persona con mayor numero de DNI en la Cola es: " + inColeccionable.maximo().DNI
                             );
            Console.WriteLine("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario",input);
            if (inColeccionable.contiene(newElemento).Equals(true))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public static void informarPersonas(Parte_II.Pila inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Pila son :" + inColeccionable.cuantos() + "\n" +
                              "La Persona con menor numero de DNI en la Pila es: " + inColeccionable.minimo().DNI + "\n" +
                              "La Persona con mayor numero de DNI en la Pila es: " + inColeccionable.maximo().DNI
                             );
            Console.WriteLine("\nPor favor, ingrese un DNI para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario",input);
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }

        public static void informarPersonas(Parte_II.ColeccionMultiple inColeccionable)
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



    }
}
