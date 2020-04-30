using Metodologias_Programacion_I_ClaseII.PatronIterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    class Pila : Coleccionable, IColeccionable<Humano>, CreateIterator
    { 

        List<Humano> pila;

        #region Propio:
        public Pila()
        {
            this.pila = new List<Humano>();
        }
        //Agrega un elemento a la cola.
        public void push(Humano elemento)
        {
            this.pila.Add(elemento);
        }

        //Extraer un elemento de cola.
        public Humano pop()
        {
            Humano firstCola = this.pila[this.pila.Count - 1];
            this.pila.RemoveAt(this.pila.Count - 1);
            return firstCola;
        }

        //Retorna true si cola está vacía.
        public bool isEmpty()
        {
            return this.pila.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la cola sin sacarlo.
        public Humano top()
        {
            return this.pila[this.pila.Count - 1];
        }

        //Retorna la cantidad de elementos que tiene cola.
        public int size()
        {
            return this.pila.Count;
        }

        //Retorna una nueva cola con los elementos en posición invertida(el primero en último lugar).
        public Pila reverse()
        {
            Pila reverse = new Pila();
            for (int i = 1; i <= this.pila.Count; i++)
            {
                reverse.push(this.pila[-i]);
            }
            return reverse;
        }

        //Agrega a la cola receptora todos los elementos de otra cola(respetando el orden original de salida).
        public void pushAll(Pila newCola)
        {
            for (int i = 0; i < newCola.size(); i++)
            {
                this.pila.Add(newCola.pop());
            }
        }
        #endregion

        #region Heredado:
        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.pila.Count;
        }

        //Devuelve el elemento de menor valor de la colección
        public Humano minimo()
        {
            Humano minValue = this.pila[0];
            Humano valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                minValue = valor.DNI < minValue.DNI ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Humano maximo()
        {
            Humano maxValue = this.pila[0];
            Humano valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                maxValue = valor.DNI > maxValue.DNI ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Humano comparable)
        {
            this.pila.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Humano comparable)
        {
            Humano valor;
            bool encontrado = false;
            for (int i = 0; i < cuantos() && encontrado.Equals(false); i++)
            {
                valor = this.pila[i];
                encontrado = comparable.DNI == valor.DNI ? true : false;
            }
            return encontrado;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Pila(this);
        }
        #endregion
    }
}
