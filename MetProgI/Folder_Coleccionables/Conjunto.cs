using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Coleccionables
{
    class Conjunto: IColeccionable<I_Comparable> , CreateIterator
    {
        List<I_Comparable> _almacenamiento;
        public List<I_Comparable> Almacenamiento { get { return _almacenamiento; } private set { this._almacenamiento = value; } }

        public Conjunto()
        {
            Almacenamiento = new List<I_Comparable>();
        }

        public void agregar(I_Comparable elemento)
        {
            if(pertenece(elemento).Equals(false))
                Almacenamiento.Add(elemento);
        }

        public bool pertenece(I_Comparable elemento)
        {
            bool pertenece = false;
            foreach(I_Comparable puntero in Almacenamiento)
            {
                if(pertenece.Equals(false))
                    pertenece= puntero.Equals(elemento) ? true : false;
            }
            return pertenece;
        }

        public int cuantos()
        {
            return this.Almacenamiento.Count;
        }

        public I_Comparable minimo()
        {
            I_Comparable minimo = Almacenamiento[0];
            foreach (I_Comparable elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(minimo.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        public I_Comparable maximo()
        {
            I_Comparable maximo = Almacenamiento[0];
            foreach (I_Comparable elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(maximo.ToString()) < 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        public bool contiene(I_Comparable comparable)
        {
            foreach (I_Comparable elemento in Almacenamiento)
            {
                if (elemento.Equals(comparable))
                    return true;
            }
            return false;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Conjunto(this);
        }
    }
}
