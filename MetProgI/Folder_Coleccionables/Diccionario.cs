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
    class Diccionario: IColeccionable<I_Comparable>, CreateIterator, Ordenable
    {
        private List<ClaveValor> _clave_valor;
        private Numero _claveDefault;
        public List<ClaveValor> Lista_ClaveValor { get { return _clave_valor; } private set { _clave_valor = value; } }
        public Numero ClaveDefault { get{ return _claveDefault; } set{ _claveDefault = value;  } }

        public OrdenEnAula1 OrdenInicioEnAula { get; set; }

        public OrdenEnAula1 OrdenEnAulaLlena { get; set; }
        public OrdenEnAula2 OrdenLlegaAlumno { get; set; }


        public Diccionario()
        {
            Lista_ClaveValor = new List<ClaveValor>();
            ClaveDefault = new Numero(0);
        }

        public void agregar(Numero in_clave, I_Comparable valor)
        {
            if (indiceElemento(in_clave).Equals(-1))
                Lista_ClaveValor.Add(new ClaveValor(in_clave, valor));
            else
                Lista_ClaveValor[indiceElemento(in_clave)] = new ClaveValor(in_clave, valor);
        }

        public void agregar(I_Comparable valor)
        {

            if (indiceElemento(ClaveDefault).Equals(-1))
            {
                Numero clave = new Numero(ClaveDefault.Valor);
                Lista_ClaveValor.Add(new ClaveValor(clave, valor));
                ClaveDefault.Valor += 1;
            }
            else
                Lista_ClaveValor[indiceElemento(ClaveDefault)] = new ClaveValor(ClaveDefault, valor);
        }

        /// <summary>
        /// Busca y retorna la posicion en el cual se encuentra el elemento. Si no existe, retorna -1
        /// </summary>
        /// <param name="in_clave"></param>
        /// <returns></returns>
        public int indiceElemento(Numero in_clave)
        {
            ConcreteIterator_Diccionario iter = new ConcreteIterator_Diccionario(this);
            while(!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.SiguienteCV();
                if (elemento.clave.sosIgual(in_clave))
                    return iter.Actual;
            }
            return -1;
        }

        /// <summary>
        /// Retorna el objecto asociado a la Clave ingresada por parametros.
        /// Si no existe la Clave dentro del Diccionario, retorna un NULL
        /// </summary>
        /// <param name="in_clave"></param>
        /// <returns></returns>
        public I_Comparable valorDe(Numero in_clave )
        {
            int posicion = indiceElemento(in_clave);
            if (!posicion.Equals(-1))
                return Lista_ClaveValor[posicion].valor;
            else
                return null;
        }

        public int cuantos()
        {
            return Lista_ClaveValor.Count;
        }

        public I_Comparable minimo()
        {
            ConcreteIterator_Diccionario iter = new ConcreteIterator_Diccionario(this);
            ClaveValor minimo = (ClaveValor)iter.Siguiente();
            while (!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                minimo = elemento.valor.sosMenor(minimo) ? elemento : minimo;
            }
            return minimo;
        }
        

        public I_Comparable maximo()
        {
            ConcreteIterator_Diccionario iter = new ConcreteIterator_Diccionario(this);
            ClaveValor maximo = (ClaveValor)iter.Siguiente();
            while (!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                maximo = elemento.valor.sosMayor(maximo) ? elemento : maximo;
            }
            return maximo;
        }

        public void agregar(ClaveValor comparable)
        {
            this.agregar(comparable.clave, comparable.valor);
        }

        public bool contiene(I_Comparable comparable)
        {
            IIterator iter = CreateIterator();
            while(!iter.EsFin())
            {
                ClaveValor elemento = (ClaveValor)iter.Siguiente();
                if (elemento.sosIgual(comparable))
                    return true;
            }
            return false;
        }

        public IIterator CreateIterator()
        {
            return new ConcreteIterator_Diccionario(this);
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
    }
}
