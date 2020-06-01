using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_FactoryMethod;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Patron_Observer
{
    public class Main
    {
        public static void Run()
        {
            Cola newCola = new Cola();
            Impresiones.Main.llenar(newCola, 5); //Se le pasa el 5 ya que es la fabrica de Vendedores
            Gerente jefe = new Gerente();
            IIterator iter = newCola.CreateIterator();
            while (!iter.EsFin())
            {
                Vendedor elemento = (Vendedor)iter.Siguiente();
                elemento.agregarObservador(jefe);
            }
            jornadaDeVentas(newCola);
            jefe.cerrar();

        }

        public static void jornadaDeVentas(IColeccionable<I_Comparable> coleccion)
        {
            double monto;
            IIterator iter = coleccion.CreateIterator();
            while(!iter.EsFin())
            {
                Vendedor elemento = (Vendedor)iter.Siguiente();
                monto =  GeneradorDeDatosAleatorios.getInstance(null).numeroAleatorio(7000);
                elemento.venta(monto);
                
            }
        }
    }
}
