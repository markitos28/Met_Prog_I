using System;
using System.Collections.Generic;

namespace Metodologias_Programacion_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cola newcola = new Cola();
            //Pila newpila = new Pila();
            //llenar(newcola);
            //llenar(newpila);
            //ColeccionMultiple newColeccion = new ColeccionMultiple(newpila,newcola);
            //informar(newcola);
            //informar(newpila);
            //informar(newColeccion);

            /*
             Respuesta al ejercicio 10:
             He tenido que modificar el procedimiento "informar".
            */

            Cola2 newcola = new Cola2();
            Pila2 newpila = new Pila2();
            llenarPersonas(newcola);
            llenarPersonas(newpila);
            ColeccionMultiple2 newColeccion = new ColeccionMultiple2(newpila, newcola);
            informarPersonas(newcola);
            informarPersonas(newpila);
            informarPersonas(newColeccion);
        }

        public static void informar(Cola inColeccionable)
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

        public static void informar(Pila inColeccionable)
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

        public static void informar(ColeccionMultiple inColeccionable)
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

        public static void llenar(Cola LPC)
        {
            Random alAzar = new Random();
            Numero valor;
            for(int i=0; i<20; i++)
            {
                valor = new Numero(alAzar.Next(-10000,10000));
                LPC.agregar(valor);
            }
        }

        public static void llenar(Pila LPC)
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
        public static void llenarPersonas(Cola2 LPC)
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

        public static void llenarPersonas(Pila2 LPC)
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

        public static void informarPersonas(Cola2 inColeccionable)
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

        public static void informarPersonas(Pila2 inColeccionable)
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

        public static void informarPersonas(ColeccionMultiple2 inColeccionable)
        {
            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + inColeccionable.cuantos(0)[0] + "\n" +
                              "La cantidad de elementos que existen en la Pila son: " + inColeccionable.cuantos(0)[1] + "\n" +
                              "La Persona con menor numero de DNI entre la Cola y la Pila es: " + inColeccionable.minimo().DNI + "\n" +
                              "La Persona con mayor numero de DNI entre la Cola y la Pila es: " + inColeccionable.maximo().DNI
                             );
            Console.WriteLine("\nPor favor, ingrese un numero para saber si se encuentra dentro de la coleccion: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Persona newElemento = new Persona("Usuario", input);
            if (inColeccionable.contiene(newElemento))
                Console.WriteLine("El elemento leido esta en la coleccion");
            else
                Console.WriteLine("El elemento leido no se encuentra en la coleccion");
        }
    }
}
