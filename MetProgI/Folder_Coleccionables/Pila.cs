using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;
using MetProgI.Patron_Command;

namespace MetProgI.Folder_Coleccionables
{
    class Pila : IColeccionable<I_Comparable>, CreateIterator, Ordenable
    { 

        List<I_Comparable> pila;

        public OrdenEnAula1 OrdenInicioEnAula { get; set; }

        public OrdenEnAula1 OrdenEnAulaLlena { get; set; }
        public OrdenEnAula2 OrdenLlegaAlumno { get; set; }
        #region Propio:
        public Pila()
        {
            this.pila = new List<I_Comparable>();
        }
        //Agrega un elemento a la cola.
        public void push(I_Comparable elemento)
        {
            if (this.pila.Count.Equals(0))
                OrdenInicioEnAula.ejecutar();

            this.pila.Add(elemento);
            OrdenLlegaAlumno.ejecutar(elemento);

            if (this.pila.Count.Equals(39))
                OrdenEnAulaLlena.ejecutar();
        }

        //Extraer un elemento de cola.
        public I_Comparable pop()
        {
            I_Comparable firstPila = this.pila[this.pila.Count - 1];
            this.pila.RemoveAt(this.pila.Count - 1);
            return firstPila;
        }

        public I_Comparable popX(int puntero)
        {
            I_Comparable firstPila = this.pila[this.pila.Count - puntero];
            return firstPila;
        }

        //Retorna true si cola está vacía.
        public bool isEmpty()
        {
            return this.pila.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la cola sin sacarlo.
        public I_Comparable top()
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
        public I_Comparable minimo()
        {
            I_Comparable minValue = this.pila[0];
            I_Comparable valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                minValue = valor.sosMenor(minValue) ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public I_Comparable maximo()
        {
            I_Comparable maxValue = this.pila[0];
            I_Comparable valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.pila[i];
                //maxValue = valor.DNI > maxValue.DNI ? valor : maxValue;
                maxValue = valor.sosMayor(maxValue) ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(I_Comparable comparable)
        {
            if (this.pila.Count.Equals(0))
                OrdenInicioEnAula.ejecutar();

            this.pila.Add(comparable);
            OrdenLlegaAlumno.ejecutar(comparable);

            if (this.pila.Count.Equals(39))
                OrdenEnAulaLlena.ejecutar();
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(I_Comparable comparable)
        {
            IIterator iter = CreateIterator();
            bool encontrado = false;
            while (!iter.EsFin() && encontrado.Equals(false))
            {
                I_Comparable elemento = (I_Comparable)iter.Siguiente();
                encontrado = comparable.sosIgual(elemento) ? true : false;
            }
            return encontrado;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Pila(this);
        }

        public void setOrdenInicio(OrdenEnAula1 OEA1)
        {
            OrdenInicioEnAula = OEA1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 OEA2)
        {
            OrdenLlegaAlumno = OEA2;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 OEA1)
        {
            OrdenEnAulaLlena = OEA1;
        }
        #endregion
    }
}
