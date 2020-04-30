using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Metodologias_Programacion_I_ClaseII.PatronIterator;

namespace Metodologias_Programacion_I_ClaseII
{
    public abstract class Coleccionable :CreateIterator, IColeccionable<Persona>
    {
         List<object> Coleccion_de_datos;

        public void agregar(Persona comparable)
        {
            throw new NotImplementedException();
        }

        public bool contiene(Persona comparable)
        {
            throw new NotImplementedException();
        }

        public IIterator CreateIterator()
        {
            throw new NotImplementedException();
        }

        public int cuantos()
        {
            throw new NotImplementedException();
        }

        public Persona maximo()
        {
            throw new NotImplementedException();
        }

        public Persona minimo()
        {
            throw new NotImplementedException();
        }
    }
}
