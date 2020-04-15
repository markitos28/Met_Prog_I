using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    class Cola:IColeccionable
    {
        List<object> cola;
        public Cola()
        {
            this.cola = new List<object>();
        }
        //Agrega un elemento a la cola.
        public void push(object elemento) 
        {
            this.cola.Add(elemento);
        }

        //Extraer un elemento de cola.
        public object pop() 
        {
            object firstCola = this.cola[0];
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
        public object top() 
        {
            return this.cola[0];
        }

        //Retorna la cantidad de elementos que tiene cola.
        public ulong  size() 
        {
            return (ulong)this.cola.Count;
        }

        //Retorna una nueva cola con los elementos en posición invertida(el primero en último lugar).
        public Cola reverse() 
        {
            List<object> newCola = new List<object>();
            foreach(object i in this.cola)
            {

            }
            return new Cola(); 
        }

        //Agrega a la cola receptora todos los elementos de otra cola(respetando el orden original de salida).
        public void pushAll(Cola newCola) { }
            
        public int cuantos()
        {
            throw new NotImplementedException();
        }

        public object minimo()
        {
            throw new NotImplementedException();
        }

        public object maximo()
        {
            throw new NotImplementedException();
        }

        public void agregar(IComparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool contiene(IComparable comparable)
        {
            throw new NotImplementedException();
        }
    }

    class Pila : IColeccionable
    {
        //Agrega un elemento a la pila.
        public void push(object elemento) { }

        //Extraer un elemento de pila.
        public object pop() { return true; }

        //Retorna true si pila está vacía.
        public bool isEmpty() { return true; }

        //Retorna el elemento al tope de la pila sin sacarlo.
        public object top() { return true; }

        //Retorna la cantidad de elementos que tiene pila.
        public ulong size() { return 0; }

        //Retorna una nueva pila con los elementos en posición invertida(el primero en último lugar).
        public Pila reverse() { return new Pila(); }

        //Agrega a la pila receptora todos los elementos de otra pila(respetando el orden original de salida).
        public void pushAll(Pila newPila) { }

        public int cuantos()
        {
            throw new NotImplementedException();
        }

        public object minimo()
        {
            throw new NotImplementedException();
        }

        public object maximo()
        {
            throw new NotImplementedException();
        }

        public void agregar(IComparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool contiene(IComparable comparable)
        {
            throw new NotImplementedException();
        }
    }
}
