using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaNumero : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //Random rnd = new Random();
            //return new Numero(rnd.Next());
            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Numero registro = new Numero((int)generador.numeroDesdeArchivo(50000));
            return registro;
        }

        public I_Comparable crearPorTeclado()
        {
            //Console.Write("Por favor, ingrese un numero: ");
            //int usuario = Convert.ToInt32(Console.ReadLine());
            //return new Numero(usuario);

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Console.Write("Por favor, ingrese un numero: ");
            Numero registro = new Numero((int)generador.numeroPorTeclado());
            return registro;
        }
    }
}
