using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_Programacion_I_ClaseII.PatronIterator;

namespace Metodologias_Programacion_I_ClaseII
{
    public class Cola : Coleccionable, IColeccionable<Humano>, CreateIterator
    {

        List<Humano> cola;

        #region Propio:
        public Cola()
        {
            this.cola = new List<Humano>();
        }
        //Agrega un elemento a la cola.
        public void push(Humano elemento)
        {
            this.cola.Add(elemento);
        }

        //Extraer un elemento de cola.
        public Humano pop()
        {
            Humano firstCola = this.cola[0];
            this.cola.RemoveAt(0);
            return firstCola;
        }

        //Retorna true si cola está vacía.
        public bool isEmpty()
        {
            return this.cola.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la cola sin sacarlo.
        public Humano top()
        {
            return this.cola[0];
        }

        //Retorna la cantidad de elementos que tiene cola.
        public int size()
        {
            return this.cola.Count;
        }

        //Retorna una nueva cola con los elementos en posición invertida(el primero en último lugar).
        public Cola reverse()
        {
            Cola reverse = new Cola();
            for (int i = 1; i <= this.cola.Count; i++)
            {
                reverse.push(this.cola[-i]);
            }
            return reverse;
        }

        //Agrega a la cola receptora todos los elementos de otra cola(respetando el orden original de salida).
        public void pushAll(Cola newCola)
        {
            for (int i = 0; i < newCola.size(); i++)
            {
                this.cola.Add(newCola.pop());
            }
        }
        #endregion

        #region Heredado:
        //Devuelve la cantidad de elementos comparables que tiene el coleccionable
        public int cuantos()
        {
            return this.cola.Count;
        }

        //Devuelve el elemento de menor valor de la colección
        public Humano minimo()
        {
            Humano minValue = this.cola[0];
            Humano valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                minValue = valor.DNI < minValue.DNI ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Humano maximo()
        {
            Humano maxValue = this.cola[0];
            Humano valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                maxValue = valor.DNI > maxValue.DNI ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Humano comparable)
        {
            this.cola.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Humano comparable)
        {
            Humano valor;
            bool encontrado = false;
            for (int i = 0; i < cuantos() && encontrado.Equals(false); i++)
            {
                valor = this.cola[i];
                encontrado = comparable.DNI == valor.DNI ? true : false;
            }
            return encontrado;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Cola(this);
        }
        #endregion
    }
}
