using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaJugador : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            Persona player = new Persona();
            player.Nombre = new Generar().Gen_Nombre();
            player.DNI = new Generar().Gen_DNI();
            player.Puntaje = 0;
            return player;
        }

        public I_Comparable crearPorTeclado()
        {
            Persona player = new Persona();
            Console.Clear();
            Console.Write("Ingrese el Nombre del Jugador: ");
            player.Nombre = Console.ReadLine();
            Console.Write("Ingrese el DNI del Jugador: ");
            player.DNI = Convert.ToInt32(Console.ReadLine());
            player.Puntaje = 0;
            return player;
        }
    }
}
