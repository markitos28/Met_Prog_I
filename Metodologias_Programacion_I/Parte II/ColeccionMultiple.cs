using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    class ColeccionMultiple : IColeccionable<Humano>
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
        public Humano minimo()
        {
            return this.colaInterna.minimo().DNI < this.pilaInterna.minimo().DNI ? this.colaInterna.minimo() : this.pilaInterna.minimo();
        }

        //Devuelve el elemento de mayor valor de la colección
        public Humano maximo()
        {
            return this.colaInterna.maximo().DNI > this.pilaInterna.maximo().DNI ? this.colaInterna.maximo() : this.pilaInterna.maximo();
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Humano comparable)
        {
            throw new NotImplementedException();
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Humano comparable)
        {
            return this.colaInterna.contiene(comparable) || this.pilaInterna.contiene(comparable) ? true : false;
        }


    }
}
