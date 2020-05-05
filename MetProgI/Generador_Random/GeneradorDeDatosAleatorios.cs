using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace MetProgI.Generador_Random
{
    class GeneradorDeDatosAleatorios
    {
        public int numeroAleatorio(int limite)
        {
            Random rnd = new Random();
            return rnd.Next(0, limite);
        }

        public string stringAleatorio(int cantidad_chr)
        {
            string ruta_nombre = @"C:\Users\Marcos Sosa\source\repos\Practicas_Y_Ejercicios\MetProgI\Generador_Random\Nombres.txt";
            string ruta_parentesco = @"C:\Users\Marcos Sosa\source\repos\Practicas_Y_Ejercicios\MetProgI\Generador_Random\Parentesco.txt";
            string[] registro_nombres = File.ReadAllLines(ruta_nombre);
            string[] registro_parentesco = File.ReadAllLines(ruta_parentesco);
            Random rnd = new Random();
            int puntero_nombre = rnd.Next(0, registro_nombres.Length);
            int puntero_parentesco = rnd.Next(0, registro_parentesco.Length);
            string palabra = registro_parentesco[puntero_parentesco] + " " + registro_nombres[puntero_nombre];
            while (!palabra.Length.Equals(cantidad_chr))
            {
                puntero_nombre = rnd.Next(0, registro_nombres.Length);
                puntero_parentesco = rnd.Next(0, registro_parentesco.Length);
                palabra = registro_parentesco[puntero_parentesco] + " " + registro_nombres[puntero_nombre];
            }
            return palabra;
        }
    }
}
