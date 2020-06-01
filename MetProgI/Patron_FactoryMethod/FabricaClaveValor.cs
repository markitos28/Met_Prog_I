using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_ChainofResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    class FabricaClaveValor : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            //Random rnd_number = new Random();
            //Persona persona = new Persona(new GeneradorDeDatosAleatorios().stringAleatorio(rnd_number.Next(10, 20)), rnd_number.Next(32000000,44000000));
            //return new ClaveValor(new Numero(rnd_number.Next()), persona);

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            Persona persona = new Persona
            (
                generador.stringDesdeArchivo(10),
                generador.numeroAleatorio(42000000)
            );
            ClaveValor registro = new ClaveValor
            (
                //new Numero((int)generador.numeroDesdeArchivo(20000)),
                (Numero)new FabricaNumero().crearAleatorio(),
                persona

            );
            return registro;
        }

        public I_Comparable crearPorTeclado()
        {
            //Console.WriteLine("\nPor favor, elija que desea ingresar.");
            //Console.WriteLine("1) Un Numero.");
            //Console.WriteLine("2) Una Persona.");
            //Console.WriteLine("3) Un Alumno.");
            //Console.Write("Su opcion: ");
            //string opcion=Console.ReadLine();
            //switch(opcion)
            //{
            //    case "1":
            //        Console.Write("\nIngrese el numero escogido: ");
            //        Numero numero=(Numero)new FabricaNumero().crearPorTeclado();
            //        return numero;
            //    case "2":
            //        Console.Write("\nIngrese un Nombre: ");
            //        string nombre = new LectorDeDatos().stringPorTeclado();
            //        Console.Write("\nIngrese un Documento: ");
            //        int documento = new LectorDeDatos().numeroPorTeclado();
            //        return new Persona(nombre, documento);
            //    case "3":
            //        return new FabricaAlumno().crearPorTeclado();
            //    default:
            //        return new Numero(0);
            //}

            Manejador generador = new LectorDeDatos(null);
            generador = GeneradorDeDatosAleatorios.getInstance(generador);
            generador = LectorDeArchivos.getInstance(generador);
            ClaveValor registro;
            Console.WriteLine("\nPor favor, elija que desea ingresar.");
            Console.WriteLine("1) Un Numero.");
            Console.WriteLine("2) Una Persona.");
            Console.WriteLine("3) Un Alumno.");
            Console.Write("Su opcion: ");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    
                    Numero numero = (Numero)new FabricaNumero().crearPorTeclado();
                    registro = new ClaveValor(new Numero(generador.numeroAleatorio(50000)), numero);
                    return registro;
                case "2":
                    Persona persona = new Persona
                    (
                        generador.stringPorTeclado(),
                        generador.numeroPorTeclado()
                    );
                    registro = new ClaveValor(new Numero(generador.numeroAleatorio(50000)), persona);
                    return registro;
                case "3":
                    registro = new ClaveValor(new Numero(generador.numeroAleatorio(50000)), new FabricaAlumno().crearPorTeclado());
                    return registro;
                default:
                    return null;
            }
            
        }
    }
}
