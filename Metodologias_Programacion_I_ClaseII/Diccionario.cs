using Metodologias_Programacion_I_ClaseII.PatronIterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    class Diccionario: Coleccionable, IColeccionable<ClaveValor>, CreateIterator
    {
        private List<ClaveValor> _clave_valor;
        //private Numero _claveDefault;
        public List<ClaveValor> Lista_ClaveValor { get { return _clave_valor; } private set { _clave_valor = value; } }
        //public Numero ClaveDefault { get{ return _claveDefault; } set{ _claveDefault = value;  } }


        public Diccionario()
        {
            Lista_ClaveValor = new List<ClaveValor>();
            //ClaveDefault = new Numero(0);
        }

        public void agregar(Numero in_clave, object valor)
        {
            if (indiceElemento(in_clave).Equals(-1))
                Lista_ClaveValor.Add(new ClaveValor(in_clave, valor));
            else
                Lista_ClaveValor[indiceElemento(in_clave)] = new ClaveValor(in_clave, valor);
        }

        /// <summary>
        /// Busca y retorna la posicion en el cual se encuentra el elemento. Si no existe, retorna -1
        /// </summary>
        /// <param name="in_clave"></param>
        /// <returns></returns>
        public int indiceElemento(Numero in_clave)
        {
            for(int i =0; i< Lista_ClaveValor.Count; i++)
            {
                if(Lista_ClaveValor[i].clave.Valor.Equals(in_clave.Valor))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Retorna el objecto asociado a la Clave ingresada por parametros.
        /// Si no existe la Clave dentro del Diccionario, retorna un NULL
        /// </summary>
        /// <param name="in_clave"></param>
        /// <returns></returns>
        public object valorDe(Numero in_clave )
        {
            int posicion = indiceElemento(in_clave);
            if (!posicion.Equals(-1))
                return Lista_ClaveValor[posicion];
            else
                return null;
        }

        public int cuantos()
        {
            return Lista_ClaveValor.Count;
        }

        public ClaveValor minimo()
        {
            ClaveValor minimo = Lista_ClaveValor[0];
            foreach (ClaveValor elemento in Lista_ClaveValor)
            {
                if (elemento.valor.ToString().CompareTo(minimo.valor.ToString()) < 0)
                {
                    minimo = elemento;
                }
            }
            return minimo;
        }
        

        public ClaveValor maximo()
        {
            ClaveValor maximo = Lista_ClaveValor[0];
            foreach (ClaveValor elemento in Lista_ClaveValor)
            {
                if (elemento.valor.ToString().CompareTo(maximo.valor.ToString()) > 0)
                {
                    maximo = elemento;
                }
            }
            return maximo;
        }

        public void agregar(ClaveValor comparable)
        {
            this.agregar(comparable.clave, comparable.valor);
        }

        public bool contiene(ClaveValor comparable)
        {
            foreach(ClaveValor elemento in Lista_ClaveValor)
            {
                if (elemento.valor.Equals(comparable.valor))
                    return true;
            }
            return false;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Diccionario(this);
        }
    }
}
