using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Generador_Random;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaAlumnoMuyEstudioso : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            Generar random = new Generar();
            AlumnoMuyEstudioso registro= new AlumnoMuyEstudioso(random.Gen_Nombre(), random.Gen_DNI(), random.Gen_DNI(), random.Gen_Promedio());
            //registro.Calificacion = new Random().Next(1, 10);
            return registro;
        }

        public I_Comparable crearPorTeclado()
        {
            Console.Write("Por favor, ingrese un Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Documento: ");
            string documento = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Legajo: ");
            string legajo = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Por favor, ingrese un Promedio: ");
            string promedio = Console.ReadLine();
            Console.Write("Por favor, ingrese una Calificacion: ");
            string calificacion = Console.ReadLine();
            AlumnoMuyEstudioso registro = new AlumnoMuyEstudioso(nombre, Convert.ToInt32(documento), Convert.ToInt32(legajo), Convert.ToDouble(promedio));
            registro.Calificacion = Convert.ToDouble(calificacion);
            return registro;
        }
    }
}
