using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I
{
    public interface IComparable<T>
    {

        public bool sosIgual(T comparable);

        public bool sosMenor(T comparable);

        public bool sosMayor(T comparable);


    }
}
