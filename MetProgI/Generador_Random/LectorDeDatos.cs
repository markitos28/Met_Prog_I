using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Generador_Random
{
    class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            int in_number = Convert.ToInt32(Console.ReadLine());
            return in_number;
        }

        public string stringPorTeclado()
        {
            string in_string = Console.ReadLine();
            return in_string; 
        }
    }
}
