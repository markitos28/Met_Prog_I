using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaJugador : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //Persona player = new Persona();
            //player.Nombre = new Generar().Gen_Nombre();
            //player.DNI = new Generar().Gen_DNI();
            //player.Puntaje = 0;
            //return player;
            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);

            Persona player = new Persona();
            player.Nombre = generador.stringDesdeArchivo(10);
            player.DNI = generador.numeroAleatorio(42000000);
            player.Puntaje = 0;
            return player;
        }

        public I_Comparable crearPorTeclado()
        {
            //Persona player = new Persona();
            //Console.Clear();
            //Console.Write("Ingrese el Nombre del Jugador: ");
            //player.Nombre = Console.ReadLine();
            //Console.Write("Ingrese el DNI del Jugador: ");
            //player.DNI = Convert.ToInt32(Console.ReadLine());
            //player.Puntaje = 0;
            //return player;
            Manejador generador = new LectorDeDatos(null);
            generador =  GeneradorDeDatosAleatorios.getInstance(generador);
            generador =  LectorDeArchivos.getInstance(generador);

            Persona player = new Persona();
            Console.Write("Ingrese el Nombre del Jugador: ");
            player.Nombre = generador.stringPorTeclado();
            Console.Write("Ingrese el DNI del Jugador: ");
            player.DNI = generador.numeroPorTeclado();
            player.Puntaje = 0;
            return player;

        }
    }
}
