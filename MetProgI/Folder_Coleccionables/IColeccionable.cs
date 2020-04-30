using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Coleccionables
{
    public interface IColeccionable<T> :CreateIterator
    {
        public int cuantos();
        public T minimo();
        public T maximo();
        public void agregar(T comparable);
        public bool contiene(T comparable);
    }
}
