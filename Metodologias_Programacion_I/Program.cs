using System;

namespace Metodologias_Programacion_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola newcola = new Cola();
            llenar(newcola);

            Console.WriteLine("La cantidad de elementos que existen en la Cola son :" + newcola.cuantos() + "\n" +
                              "La el Numero minimo que existe en la Cola es: " + newcola.minimo().Valor + "\n" +
                              "La el Numero maximo que existe en la Cola es: " + newcola.maximo().Valor
                             );
        }

        public static void llenar(Cola LPC)
        {
            Random alAzar = new Random();
            Numero valor;
            for(int i=0; i<20; i++)
            {
                valor = new Numero(alAzar.Next(-10000,10000));
                LPC.agregar(valor);
            }
        }

        public static void llenar(Pila LPC)
        {
            Random alAzar = new Random();
            Numero valor;
            for (int i = 0; i < 20; i++)
            {
                valor = new Numero(alAzar.Next(-10000, 10000));
                LPC.agregar(valor);
            }
        }
    }
}
