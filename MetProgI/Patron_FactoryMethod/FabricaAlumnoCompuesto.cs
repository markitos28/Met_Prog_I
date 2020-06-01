using MetProgI.Folder_Comparables;
using MetProgI.Patron_Composite;
using MetProgI.Generador_Random;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaAlumnoCompuesto : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //CompuestoAlumno unAlumnoCompuesto = new CompuestoAlumno(
            //    new Generar().Gen_Nombre(),
            //    new Generar().Gen_DNI(),
            //    new Generar().Gen_Legajo(),
            //    (int)new Generar().Gen_Promedio()
            //    );
            //return unAlumnoCompuesto;

            Manejador generador = new LectorDeDatos(null);
            generador =  GeneradorDeDatosAleatorios.getInstance(generador);
            generador =  LectorDeArchivos.getInstance(generador);

            return new CompuestoAlumno(generador.stringAleatorio(15), (int)generador.numeroDesdeArchivo(42000000), generador.numeroAleatorio(20000), generador.numeroAleatorio(10));

        }

        public I_Comparable crearPorTeclado()
        {
            //Console.Clear();
            //Alumno alumno = (Alumno)new FabricaAlumno().crearAleatorio();
            //CompuestoAlumno unAlumnoCompuesto = new CompuestoAlumno(alumno.Nombre, alumno.DNI, alumno.Legajo, (int)alumno.Calificacion);
            //return unAlumnoCompuesto;

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
            return new CompuestoAlumno(nombre, documento, legajo, promedio);
        }
    }
}
