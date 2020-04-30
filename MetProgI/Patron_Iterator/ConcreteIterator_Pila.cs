using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Strategy;

namespace MetProgI.Patron_Iterator
{
    class ConcreteIterator_Pila: IIterator
    {
        public Pila lista;
        public int actual = 0;

        public ConcreteIterator_Pila(Pila in_lista)
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
            var anterior = this.lista.popX(actual+1);
            actual++;
            return anterior;
        }
    }
}
