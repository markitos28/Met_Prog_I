using MetProgI.Folder_Comparables;
using MetProgI.Patron_Composite;
using MetProgI.Generador_Random;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_FactoryMethod
{
    public class FabricaAlumnoCompuesto : FabricaDeComparables
    {
        public I_Comparable crearAleatorio()
        {
            CompuestoAlumno unAlumnoCompuesto = new CompuestoAlumno(
                new Generar().Gen_Nombre(),
                new Generar().Gen_DNI(),
                new Generar().Gen_Legajo(),
                (int)new Generar().Gen_Promedio()
                );
            return unAlumnoCompuesto;
            
        }

        public I_Comparable crearPorTeclado()
        {
            Console.Clear();
            Alumno alumno = (Alumno)new FabricaAlumno().crearAleatorio();
            CompuestoAlumno unAlumnoCompuesto = new CompuestoAlumno(alumno.Nombre, alumno.DNI, alumno.Legajo, (int)alumno.Calificacion);
            return unAlumnoCompuesto;
        }
    }
}
