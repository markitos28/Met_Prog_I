using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    public interface IColeccionable
    {
        public int cuantos();
        public object minimo();
        public object maximo();
        public void agregar(IComparable comparable);
        public bool contiene(IComparable comparable);
    }
}
