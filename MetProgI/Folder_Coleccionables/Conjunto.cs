using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Generador_Random;
using MetProgI.Patron_Iterator;
using MetProgI.Patron_Strategy;

namespace MetProgI.Folder_Coleccionables
{
    class Conjunto: IColeccionable<Persona> , CreateIterator
    {
        List<Persona> _almacenamiento;
        public List<Persona> Almacenamiento { get { return _almacenamiento; } private set { this._almacenamiento = value; } }

        public Conjunto()
        {
            Almacenamiento = new List<Persona>();
        }

        public void agregar(Persona elemento)
        {
            if(pertenece(elemento).Equals(false))
                Almacenamiento.Add(elemento);
        }

        public bool pertenece(Persona elemento)
        {
            bool pertenece = false;
            foreach(Persona puntero in Almacenamiento)
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

        public Persona minimo()
        {
            Persona minimo = Almacenamiento[0];
            foreach (Persona elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(minimo.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }

        public Persona maximo()
        {
            Persona maximo = Almacenamiento[0];
            foreach (Persona elemento in Almacenamiento)
            {
                if (elemento.ToString().CompareTo(maximo.ToString()) < 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        public bool contiene(Persona comparable)
        {
            foreach (Persona elemento in Almacenamiento)
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
