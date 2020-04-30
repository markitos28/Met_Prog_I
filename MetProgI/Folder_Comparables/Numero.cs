using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Folder_Comparables
{ 
    class Numero : I_Comparable
    {
        private int _valor;

        public int Valor 
        {
            get { return this._valor; }
            set { this._valor = value; }
        }

        public Numero(int v)
        {
            this._valor = v;
        }

        public bool sosIgual(I_Comparable comparable)
        {
            return ((Numero)comparable).Valor == this._valor ? true : false;
        }

        public bool sosMenor(I_Comparable comparable)
        {
            return ((Numero)comparable).Valor > this._valor ? true : false;
        }

        public bool sosMayor(I_Comparable comparable)
        {
            return ((Numero)comparable).Valor < this._valor ? true : false;
        }
    }
}
