using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;

namespace MetProgI.Patron_ChainofResponsability
{
    public abstract class Manejador
    {
        public Manejador Sucesor { get; set; }

        public Manejador(Manejador inSucesor)
        {
            Sucesor = inSucesor;
        }

        public abstract double numeroDesdeArchivo(double max);
        public abstract string stringDesdeArchivo(int cant);
        public abstract int numeroAleatorio(int limite);
        public abstract string stringAleatorio(int cantidad_chr);
        public abstract int numeroPorTeclado();
        public abstract string stringPorTeclado();


    }
}
