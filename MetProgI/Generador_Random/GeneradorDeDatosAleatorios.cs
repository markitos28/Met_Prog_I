using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Generador_Random
{
    public class GeneradorDeDatosAleatorios: Manejador
    {
        private static GeneradorDeDatosAleatorios Generador { get; set; }
        private GeneradorDeDatosAleatorios(Manejador inSucesor) : base(inSucesor)
        {
        }

        public static GeneradorDeDatosAleatorios getInstance(Manejador inSucesor)
        {
            if (Generador == null)
                Generador = new GeneradorDeDatosAleatorios(inSucesor);
            return Generador;
        }

        public override int numeroAleatorio(int limite)
        {
            Random rnd = new Random();
            return rnd.Next(0, limite);
        }

        public override double numeroDesdeArchivo(double max)
        {
            if(Sucesor != null)
                return Sucesor.numeroDesdeArchivo(max);
            return 0;
        }

        public override int numeroPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.numeroPorTeclado();
            return 0;
        }

        public override string stringAleatorio(int cantidad_chr)
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

        public override string stringDesdeArchivo(int cant)
        {
            if (Sucesor != null)
                return Sucesor.stringDesdeArchivo(cant);
            return "";
        }

        public override string stringPorTeclado()
        {
            if (Sucesor != null)
                return Sucesor.stringPorTeclado();
            return "";
        }
    }
}
