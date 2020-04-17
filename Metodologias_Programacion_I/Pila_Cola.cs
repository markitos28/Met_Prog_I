using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    class Cola : IColeccionable<Numero>
    {
    
        List<Numero> cola;

    #region Propio:
        public Cola()
        {
            this.cola = new List<Numero>();
        }
        //Agrega un elemento a la cola.
        public void push(Numero elemento)
        {
            this.cola.Add(elemento);
        }

        //Extraer un elemento de cola.
        public Numero pop()
        {
            Numero firstCola = this.cola[0];
            this.cola.RemoveAt(0);
            return firstCola;
        }

        //Retorna true si cola está vacía.
        public bool isEmpty()
        {
            /*
              if (this.cola.Count.Equals(0))
                return true;
            else
                return false;

            Lo siguiente reemplaza a lo de arriba:
            */

            return this.cola.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la cola sin sacarlo.
        public Numero top()
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
        public Numero minimo()
        {
            Numero minValue = this.cola[0];
            Numero valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                minValue = valor.Valor < minValue.Valor ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Numero maximo()
        {
            Numero maxValue = this.cola[0];
            Numero valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                maxValue = valor.Valor > maxValue.Valor ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Numero comparable)
        {
            this.cola.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Numero comparable)
        {
            Numero valor;
            bool encontrado = false;
            for (int i=0; i< cuantos() || encontrado.Equals(false); i++)
            {
                valor = this.cola[i];
                encontrado= comparable.Valor == valor.Valor ? true : false;
            }
            return encontrado;
        }
    #endregion
    }

    class Pila : IColeccionable<Numero>
    {
        List<Numero> pila;

    #region Propio:
        public Pila()
        {
            this.pila = new List<Numero>();
        }
        //Agrega un elemento a la pila.
        public void push(Numero elemento)
        {
            this.pila.Add(elemento);
        }

        //Extraer un elemento de pila.
        public Numero pop()
        {
            Numero firstCola = this.pila[0];
            this.pila.RemoveAt(0);
            return firstCola;
        }

        //Retorna true si pila está vacía.
        public bool isEmpty()
        {
            return this.pila.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la pila sin sacarlo.
        public Numero top()
        {
            return this.pila[0];
        }

        //Retorna la cantidad de elementos que tiene pila.
        public int size()
        {
            return this.pila.Count;
        }

        //Retorna una nueva pila con los elementos en posición invertida(el primero en último lugar).
        public Cola reverse()
        {
            Cola reverse = new Cola();
            for (int i = 1; i <= this.pila.Count; i++)
            {
                reverse.push(this.pila[-i]);
            }
            return reverse;
        }

        //Agrega a la pila receptora todos los elementos de otra pila(respetando el orden original de salida).
        public void pushAll(Cola newCola)
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
        public Numero minimo()
        {
            Numero minValue = this.pila[0];
            Numero valor;
            for (int i = 0; i <= cuantos(); i++)
            {
                valor = this.pila[i];
                minValue = valor.Valor < minValue.Valor ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public Numero maximo()
        {
            Numero maxValue = this.pila[0];
            Numero valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                maxValue = valor.Valor > maxValue.Valor ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(Numero comparable)
        {
            this.pila.Add(comparable);
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(Numero comparable)
        {
            Numero valor;
            bool encontrado = false;
            for (int i = 0; i < cuantos() || encontrado.Equals(false); i++)
            {
                valor = this.pila[i];
                encontrado = comparable.Valor == valor.Valor ? true : false;
            }
            return encontrado;
        }
    #endregion
    }
}
