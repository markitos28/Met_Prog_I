using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Coleccionables
{
    class ColeccionMultiple : IColeccionable<I_Comparable>
    {
        Pila pilaInterna;
        Cola colaInterna;

        public ColeccionMultiple(Pila inPila, Cola inCola)
        {
            this.pilaInterna = inPila;
            this.colaInterna = inCola;
        }

        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.colaInterna.cuantos();
        }

        public List<int> cuantos(int entrada = 0)
        {

            return new List<int>() { this.colaInterna.cuantos(), this.pilaInterna.cuantos() };
        }

        //Devuelve el elemento de menor valor de la colección
        public I_Comparable minimo()
        {
            return this.colaInterna.minimo().sosMenor(this.pilaInterna.minimo()) ? this.colaInterna.minimo() : this.pilaInterna.minimo();
        }

        //Devuelve el elemento de mayor valor de la colección
        public I_Comparable maximo()
        {
            return this.colaInterna.maximo().sosMayor(this.pilaInterna.maximo()) ? this.colaInterna.maximo() : this.pilaInterna.maximo();
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(I_Comparable comparable)
        {
            throw new NotImplementedException();
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(I_Comparable comparable)
        {
            return this.colaInterna.contiene(comparable) || this.pilaInterna.contiene(comparable) ? true : false;
        }

        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
