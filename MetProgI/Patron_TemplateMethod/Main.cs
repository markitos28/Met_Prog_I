using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_TemplateMethod
{
    public class Main
    {
        public static void Run()
        {

            // Ejercicio 4 al 6 Practica 6
            Pila nuevoMazo = new Pila();
            Persona jugador1 = (Persona)new FabricaJugador().crearAleatorio();
            Persona jugador2 = (Persona)new FabricaJugador().crearAleatorio();

            Console.Clear();
            Console.WriteLine("------------------- Ellecion de jugada --------------------------");
            Console.WriteLine("1) Por valor de Carta");
            Console.WriteLine("2) Por Puntaje de jugador");
            Console.Write("Por favor, elija el tipo de juego que quiere jugar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            JuegodeCartas nuevoJuego;
            switch (opcion)
            {
                case 1:
                    nuevoJuego = new OroMaldito(nuevoMazo, jugador1, jugador2);
                    Console.Clear();
                    for (int i = 1; i <= 10; i++)
                    {
                        Persona ganador = nuevoJuego.Jugar();
                        Console.WriteLine("Mano {0} -> Gano: {1}", i, ganador.Nombre);
                    }
                    break;
                case 2:
                    nuevoMazo = new Pila();
                    jugador1 = (Persona)new FabricaJugador().crearAleatorio();
                    jugador2 = (Persona)new FabricaJugador().crearAleatorio();
                    nuevoJuego = new OroMaldito(nuevoMazo, jugador1, jugador2);
                    bool flag = false;
                    Console.Clear();
                    for (int i = 1; i <= 10 || flag.Equals(false); i++)
                    {
                        Persona ganador = nuevoJuego.Jugar();
                        if(jugador1.Puntaje > 15)
                        {
                            Console.WriteLine("Mano {0} -> Gano: {1}", i, jugador1.Nombre);
                            flag = true;
                        }

                        if (jugador2.Puntaje > 15)
                        {
                            Console.WriteLine("Mano {0} -> Gano: {1}", i, jugador2.Nombre);
                            flag = true;
                        }
                    }
                    break;
            }
            
            // ------------------------------------------------------------------------------------------
            
        }
    }
}
