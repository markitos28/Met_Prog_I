using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;

namespace MetProgI.Patron_FactoryMethod
{
    public interface FabricaDeComparables
    {
        public I_Comparable crearAleatorio();
        public I_Comparable crearPorTeclado();
    }
}
