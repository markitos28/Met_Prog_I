using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaAlumnoMuyEstudioso : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //Generar random = new Generar();
            //AlumnoMuyEstudioso registro= new AlumnoMuyEstudioso(random.Gen_Nombre(), random.Gen_DNI(), random.Gen_DNI(), random.Gen_Promedio());
            //return registro;

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);

            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso
                (
                    generador.stringDesdeArchivo(10),
                    (int)generador.numeroDesdeArchivo(42000000),
                    generador.numeroAleatorio(20000),
                    generador.numeroAleatorio(10)
                );
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
            //AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
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

            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(nombre, documento, legajo, promedio);
            registro.Calificacion = calificacion;
            return registro;

        }
    }
}
