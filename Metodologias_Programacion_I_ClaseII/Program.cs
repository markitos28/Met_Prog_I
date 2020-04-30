using System;
using Metodologias_Programacion_I_ClaseII.Generador_Random;
using Metodologias_Programacion_I_ClaseII.Run;
using System.Collections;
using System.Collections.Generic;

namespace Metodologias_Programacion_I_ClaseII
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (salir.Equals(false))
            {
                Console.WriteLine("---------- Elija la opcion que desea ejecutar ---------");
                Console.WriteLine("1) Comparar Nombre");
                Console.WriteLine("2) Comparar DNI");
                Console.WriteLine("3) Comparar Legajo");
                Console.WriteLine("4) Comparar Promedio");
                Console.WriteLine("5) Ejercicio 2");
                Console.WriteLine("6) Ejercicio 7");
                Console.WriteLine("0) Salir");
                Console.WriteLine();
                Console.Write("Ingrese su opcion: ");
                int eleccion = Convert.ToInt32(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        new Main_E1().Main(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        new Main_E1().Main(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        new Main_E1().Main(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        new Main_E1().Main(eleccion);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        new Main_E1().ejercicio2();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        //new Main_E1().Main(eleccion);
                        Coleccionable newCola = new Cola();
                        new Main_E1().ejercicio7(newCola);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 0:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Por favor, elija una opcion correcta.");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
