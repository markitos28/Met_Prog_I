using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.PatronIterator
{
    class ConcreteIterator_Diccionario: IIterator
    {
        public Diccionario lista;
        public int actual = 0;

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
            var anterior = this.lista.Lista_ClaveValor[actual];
            actual++;
            return anterior;
        }
    }
}
