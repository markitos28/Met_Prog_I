using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaAlumno : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            Manejador generador = new LectorDeDatos(null);
            generador =  GeneradorDeDatosAleatorios.getInstance(generador);
            generador =  LectorDeArchivos.getInstance(generador);
            
            return new Alumno(generador.stringAleatorio(15), (int)generador.numeroDesdeArchivo(42000000), generador.numeroAleatorio(20000), generador.numeroAleatorio(10));
        }

        public I_Comparable crearPorTeclado()
        {
            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = generador.stringPorTeclado();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Documento: ");
            int documento = generador.numeroPorTeclado();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Legajo: ");
            int legajo = generador.numeroPorTeclado();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Promedio: ");
            int promedio = generador.numeroPorTeclado();
            return new Alumno(nombre, documento, legajo, promedio);
        }
    }
}
