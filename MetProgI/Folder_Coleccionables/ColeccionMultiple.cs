using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Coleccionables
{
    class ColeccionMultiple : IColeccionable<Persona>
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
        public Persona minimo()
        {
            return this.colaInterna.minimo().DNI < this.pilaInterna.minimo().DNI ? this.colaInterna.minimo() : this.pilaInterna.minimo();
        }

        //Devuelve el elemento de mayor valor de la colección
        public Persona maximo()
        {
            return this.colaInterna.maximo().DNI > this.pilaInterna.maximo().DNI ? this.colaInterna.maximo() : this.pilaInterna.maximo();
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Persona comparable)
        {
            throw new NotImplementedException();
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Persona comparable)
        {
            return this.colaInterna.contiene(comparable) || this.pilaInterna.contiene(comparable) ? true : false;
        }

        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }
    }
}
