using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
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
            string nombre = new GeneradorDeDatosAleatorios().stringAleatorio(15);
            int dni = new GeneradorDeDatosAleatorios().numeroAleatorio(42000000);
            double sueldo = new GeneradorDeDatosAleatorios().numeroAleatorio(60000);
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }

        public I_Comparable crearPorTeclado()
        {
            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = new LectorDeDatos().stringPorTeclado();
            Console.Write("\nPor favor, ingrese un Documento: ");
            int dni = new LectorDeDatos().numeroPorTeclado();
            Console.Write("\nPor favor, ingrese un Sueldo Basico: ");
            double sueldo = new LectorDeDatos().numeroPorTeclado();
            Vendedor newVendedor = new Vendedor(nombre, dni, sueldo);
            return newVendedor;
        }
    }
}
