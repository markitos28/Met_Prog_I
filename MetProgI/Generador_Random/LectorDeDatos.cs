using MetProgI.Patron_ChainofResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Generador_Random
{
    public class LectorDeDatos: Manejador
    {
        public LectorDeDatos(Manejador inSucesor) : base(inSucesor)
        {
        }

        public override int numeroAleatorio(int limite)
        {
            if (Sucesor != null)
                return Sucesor.numeroAleatorio(limite);
            return 0;
        }

        public override double numeroDesdeArchivo(double max)
        {
            if (Sucesor != null)
                return Sucesor.numeroDesdeArchivo(max);
            return 0;
        }

        public override int numeroPorTeclado()
        {
            int in_number = Convert.ToInt32(Console.ReadLine());
            return in_number;
        }

        public override string stringAleatorio(int cantidad_chr)
        {
            if (Sucesor != null)
                return Sucesor.stringAleatorio(cantidad_chr);
            return "";
        }

        public override string stringDesdeArchivo(int cant)
        {
            if (Sucesor != null)
                return Sucesor.stringDesdeArchivo(cant);
            return "";
        }

        public override string stringPorTeclado()
        {
            string in_string = Console.ReadLine();
            return in_string; 
        }
    }
}
