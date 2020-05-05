using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Strategy;

namespace MetProgI.Patron_Iterator
{
    class ConcreteIterator_Diccionario: IIterator
    {
        public Diccionario lista;
        public int actual = 0;

        public int Actual { get; set; }

        public ConcreteIterator_Diccionario(Diccionario in_lista)
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
            var anterior = this.lista.Lista_ClaveValor[actual].valor;
            actual++;
            return anterior;
        }

        public object SiguienteCV()
        {
            var anterior = this.lista.Lista_ClaveValor[actual];
            actual++;
            return anterior;
        }
    }
}
