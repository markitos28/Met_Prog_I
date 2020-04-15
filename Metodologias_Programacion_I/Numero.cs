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
            if (comparable.Valor == this._valor) { return true; }
            else { return false; }
        }

        public bool sosMenor(Numero comparable)
        {
            if (comparable.Valor > this._valor) { return true; }
            else { return false; }
        }

        public bool sosMayor(Numero comparable)
        {
            if (comparable.Valor < this._valor) { return true; }
            else { return false; }
        }
    }
}
