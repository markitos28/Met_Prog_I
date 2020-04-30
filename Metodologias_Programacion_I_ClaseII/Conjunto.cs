using System;
using System.Collections.Generic;
using System.Text;
using Metodologias_Programacion_I_ClaseII.PatronIterator;

namespace Metodologias_Programacion_I_ClaseII
{
    class Conjunto: Coleccionable, IColeccionable<object> , CreateIterator
    {
        List<object> _almacenamiento;
        public List<object> Almacenamiento { get { return _almacenamiento; } private set { this._almacenamiento = value; } }

        public Conjunto()
        {
            Almacenamiento = new List<object>();
        }

        public void agregar(object elemento)
        {
            if(pertenece(elemento).Equals(false))
                Almacenamiento.Add(elemento);
        }

        public bool pertenece(object elemento)
        {
            bool pertenece = false;
            foreach(object puntero in Almacenamiento)
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

        public object minimo()
        {
            object minimo = Almacenamiento[0];
            foreach (object elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(minimo.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        public object maximo()
        {
            object maximo = Almacenamiento[0];
            foreach (object elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(maximo.ToString()) < 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        public bool contiene(object comparable)
        {
            foreach (object elemento in Almacenamiento)
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
