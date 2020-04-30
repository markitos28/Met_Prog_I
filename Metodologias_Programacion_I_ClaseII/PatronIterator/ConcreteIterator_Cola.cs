using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.PatronIterator
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
            var anterior = this.lista.pop();
            actual++;
            return anterior;

        }
    }
}
