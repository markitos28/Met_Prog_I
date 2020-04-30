using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.PatronIterator
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
            return actual < this.lista.cuantos() ? true : false;
        }

        public void Reset()
        {
            this.actual = 0;
        }

        public object Siguiente()
        {
            var anterior = this.lista.pop();
            actual++;
            return anterior;
        }
    }
}
