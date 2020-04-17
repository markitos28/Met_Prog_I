using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    class Numero : IComparable<Numero>
    {
        private int _valor;

        public int Valor 
        {
            get { return this._valor; }
        }

        public Numero(int v)
        {
            this._valor = v;
        }

        public bool sosIgual(Numero comparable)
        {
            return comparable.Valor == this._valor ? true : false;
        }

        public bool sosMenor(Numero comparable)
        {
            return comparable.Valor > this._valor ? true : false;
        }

        public bool sosMayor(Numero comparable)
        {
            return comparable.Valor < this._valor ? true : false;
        }
    }
}
