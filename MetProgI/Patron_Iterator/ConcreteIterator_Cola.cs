using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Strategy;

namespace MetProgI.Patron_Iterator
{
    public class ConcreteIterator_Cola:IIterator
    {
        public Cola lista;
        public int actual = 0;

        public ConcreteIterator_Cola(Cola in_lista)
        {
            this.lista = in_lista;
        }

        public bool EsFin()
        {
            return actual < this.lista.cuantos() ? false : true;
        }

        public void Reset()
        {
            this.actual = 0;
        }

        public object Siguiente()
        {
            var anterior = this.lista.popX(actual);
            actual++;
            return anterior;

        }
    }
}
