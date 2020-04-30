using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    public interface IColeccionable<T> 
    {
        public int cuantos();
        public T minimo();
        public T maximo();
        public void agregar(T comparable);
        public bool contiene(T comparable);
    }
}
