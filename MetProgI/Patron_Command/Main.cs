using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Command
{
    public class Main
    {
        public static void Run()
        {
            Cola almacenamiento = new Cola();
            Aula clase = new Aula();
            almacenamiento.setOrdenAulaLlena(new OrdenAulaLlena(clase));
            almacenamiento.setOrdenLlegaAlumno(new OrdenLlegaAlumno(clase));
            almacenamiento.setOrdenInicio(new OrdenInicio(clase));
            Impresiones.Main.llenar(almacenamiento, 2);
            Impresiones.Main.llenar(almacenamiento, 6);
            Impresiones.Main.informar(almacenamiento);

        }
    }
}
