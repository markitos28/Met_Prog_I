using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;
using MetProgI.Patron_Proxy;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaAlumnoMuyEstudiosoProxy : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //Generar random = new Generar();
            //AlumnoMuyEstudiosoProxy registro= new AlumnoMuyEstudiosoProxy(random.Gen_Nombre(), random.Gen_DNI(), random.Gen_DNI(), random.Gen_Promedio());
            //return registro;

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy
            (
                generador.stringDesdeArchivo(10),
                generador.numeroAleatorio(42000000),
                (int)generador.numeroDesdeArchivo(20000),
                generador.numeroAleatorio(10)
            ) ;
            return registro;
        }

        public I_Comparable crearPorTeclado()
        {
            //Console.Write("Por favor, ingrese un Nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("");
            //Console.Write("Por favor, ingrese un Documento: ");
            //string documento = Console.ReadLine();
            //Console.WriteLine("");
            //Console.Write("Por favor, ingrese un Legajo: ");
            //string legajo = Console.ReadLine();
            //Console.WriteLine("");
            //Console.Write("Por favor, ingrese un Promedio: ");
            //string promedio = Console.ReadLine();
            //Console.Write("Por favor, ingrese una Calificacion: ");
            //string calificacion = Console.ReadLine();
            //AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
            //registro.Calificacion = Convert.ToDouble(calificacion);
            //return registro;

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
            Console.Write("Por favor, ingrese una Calificacion: ");
            int calificacion = generador.numeroPorTeclado();

            AlumnoMuyEstudiosoProxy registro = new AlumnoMuyEstudiosoProxy(nombre, documento, legajo, promedio);
            return registro;
        }
    }
}
