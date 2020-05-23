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
    class Conjunto: IColeccionable<I_Comparable> , CreateIterator, Ordenable
    {
        List<I_Comparable> _almacenamiento;
        public List<I_Comparable> Almacenamiento { get { return _almacenamiento; } private set { this._almacenamiento = value; } }
        public OrdenEnAula1 TypeOrdenEnAula1A { get; set; }

        public OrdenEnAula1 TypeOrdenEnAula1B { get; set; }
        public OrdenEnAula2 TypeOrdenEnAula2 { get; set; }

        public Conjunto()
        {
            Almacenamiento = new List<I_Comparable>();
        }

        public void agregar(I_Comparable elemento)
        {
            if (Almacenamiento.Count.Equals(0))
                TypeOrdenEnAula1A.ejecutar();

            if (pertenece(elemento).Equals(false))
                Almacenamiento.Add(elemento);

            TypeOrdenEnAula2.ejecutar(elemento);

            if (Almacenamiento.Count.Equals(39)) 
            {
                /*arreglar y consultar con el profesor*/
                TypeOrdenEnAula1B.ejecutar();
            }
                
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

        public void setOrdenInicio(OrdenEnAula1 OEA1)
        {
            TypeOrdenEnAula1A = OEA1;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 OEA2)
        {
            TypeOrdenEnAula2 = OEA2;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 OEA1)
        {
            TypeOrdenEnAula1B = OEA1;
        }
    }
}
