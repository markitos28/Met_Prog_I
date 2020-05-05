using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaNumero : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            Random rnd = new Random();
            return new Numero(rnd.Next());
        }

        public I_Comparable crearPorTeclado()
        {
            Console.Write("Por favor, ingrese un numero: ");
            int usuario = Convert.ToInt32(Console.ReadLine());
            return new Numero(usuario);
        }
    }
}
