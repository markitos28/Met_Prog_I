using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;
using MetProgI.Patron_Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaVendedor : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //string nombre = new GeneradorDeDatosAleatorios(null).stringAleatorio(15);
            //int dni = new GeneradorDeDatosAleatorios(null).numeroAleatorio(42000000);
            //double sueldo = new GeneradorDeDatosAleatorios(null).numeroAleatorio(60000);
            //Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            //return newVendedor;

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);

            Vendedor newVendedor = new Vendedor
            (
                generador.stringDesdeArchivo(10),
                generador.numeroAleatorio(42000000), 
                generador.numeroDesdeArchivo(60000)
            );
            return newVendedor;

        }

        public I_Comparable crearPorTeclado()
        {
            //Console.Write("Por favor, ingrese un Nombre: ");
            //string nombre = new LectorDeDatos().stringPorTeclado();
            //Console.Write("\nPor favor, ingrese un Documento: ");
            //int dni = new LectorDeDatos().numeroPorTeclado();
            //Console.Write("\nPor favor, ingrese un Sueldo Basico: ");
            //double sueldo = new LectorDeDatos().numeroPorTeclado();
            //Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            //return newVendedor;

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);

            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = generador.stringPorTeclado();
            Console.Write("\nPor favor, ingrese un Documento: ");
            int dni = generador.numeroPorTeclado();
            Console.Write("\nPor favor, ingrese un Sueldo Basico: ");
            double sueldo = generador.numeroPorTeclado();
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }
    }
}
