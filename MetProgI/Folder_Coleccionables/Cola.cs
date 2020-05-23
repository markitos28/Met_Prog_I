using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Patron_Iterator;
using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Command;

namespace MetProgI.Folder_Coleccionables
{
    public class Cola : IColeccionable<I_Comparable>, CreateIterator, Ordenable 
    {

        List<I_Comparable> cola;
        public OrdenEnAula1 OrdenInicioEnAula { get; set; }
        public OrdenEnAula1 OrdenEnAulaLlena { get; set; }
        public OrdenEnAula2 OrdenLlegaAlumno { get; set; }

        #region Propio:
        public Cola()
        {
            this.cola = new List<I_Comparable>();
        }
        //Agrega un elemento a la cola.
        public void push(I_Comparable elemento)
        {
            if (this.cola.Count.Equals(0))
                OrdenInicioEnAula.ejecutar();

            this.cola.Add(elemento);
            OrdenLlegaAlumno.ejecutar(elemento);

            if (this.cola.Count.Equals(39))
                OrdenEnAulaLlena.ejecutar();
        }

        //Extraer un elemento de cola.
        public I_Comparable pop()
        {
            I_Comparable firstCola = this.cola[0];
            this.cola.RemoveAt(0);
            return firstCola;
        }
        /// <summary>
        /// Esta implementacion NO elimina el elemento contenido en la coleccion
        /// </summary>
        /// <returns></returns>
        public I_Comparable popX(int puntero)
        {
            I_Comparable firstCola = this.cola[puntero];
            return firstCola;
        }
        //Retorna true si cola está vacía.
        public bool isEmpty()
        {
            return this.cola.Count.Equals(0) ? true : false;
        }

        //Retorna el elemento al tope de la cola sin sacarlo.
        public I_Comparable top()
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
        public I_Comparable minimo()
        {
            I_Comparable minValue = this.cola[0];
            I_Comparable valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                minValue = valor.sosMenor(minValue) ? valor : minValue;
            }
            return minValue;
        }

        //Devuelve el elemento de mayor valor de la colección
        public I_Comparable maximo()
        {
            I_Comparable maxValue = this.cola[0];
            I_Comparable valor;
            for (int i = 0; i < cuantos(); i++)
            {
                valor = this.cola[i];
                maxValue = valor.sosMayor(maxValue) ? valor : maxValue;
            }
            return maxValue;
        }

        //Agrega el comparable recibido por parámetro a la colección que recibe el mensaje
        public void agregar(I_Comparable comparable)
        {
            if (this.cola.Count.Equals(0))
                OrdenInicioEnAula.ejecutar();

            this.cola.Add(comparable);
            OrdenLlegaAlumno.ejecutar(comparable);

            if (this.cola.Count.Equals(39))
                OrdenEnAulaLlena.ejecutar();
        }

        //Devuelve verdadero si el comparable recibido por parámetro está incluido en la colección y falso en caso contrario
        public bool contiene(I_Comparable comparable)
        {
            IIterator iter = CreateIterator();
            bool encontrado = false;
            while (!iter.EsFin() && encontrado.Equals(false))
            {
                I_Comparable elemento=(I_Comparable) iter.Siguiente();
                encontrado = comparable.sosIgual(elemento) ? true : false;
            }
            return encontrado;
            //I_Comparable valor;
            //bool encontrado = false;
            //for (int i = 0; i < cuantos() && encontrado.Equals(false); i++)
            //{
            //    valor = this.cola[i];
            //    encontrado = comparable.sosIgual(valor) ? true : false;
            //}
            //return encontrado;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Cola(this);
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
