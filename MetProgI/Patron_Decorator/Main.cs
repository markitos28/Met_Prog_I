using MetodologíasDeProgramaciónI;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Adapter;
using MetProgI.Patron_FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Decorator
{
    public class Main
    {
        public static void Run()
        {
            Student adaptado = new AdapterStudent((Alumno)new FabricaAlumno().crearAleatorio());
            DecoradoLegajo a = new DecoradoLegajo(adaptado);
            string imprimir = new DecoradoLegajo(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoNotasEnLetras b = new DecoradoNotasEnLetras(a.estudiante);
            imprimir = new DecoradoNotasEnLetras(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoPromocion c = new DecoradoPromocion(b.estudiante);
            imprimir = new DecoradoPromocion(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            DecoradoRecuadroAsteriscos d = new DecoradoRecuadroAsteriscos(c.estudiante);
            imprimir = new DecoradoRecuadroAsteriscos(adaptado).imprimirDecorado();
            Console.Clear();
            Console.WriteLine(imprimir);
            Console.ReadKey();

            // agregado 23/06

            Student marcos = new AdapterStudent((Alumno)new FabricaAlumno().crearAleatorio());
            AbsDecoradoresAdicionales primerDecorado = new DecoradoLegajo(marcos);
            primerDecorado = new DecoradoNotasEnLetras(primerDecorado);
            primerDecorado = new DecoradoPromocion(primerDecorado);
            primerDecorado = new DecoradoRecuadroAsteriscos(primerDecorado);
            Console.Clear();
            Console.WriteLine(primerDecorado.imprimirDecorado());
            Console.ReadKey();

            //----------------------------
        }
    }
}
