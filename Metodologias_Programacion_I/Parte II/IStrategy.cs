using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    public interface IStrategy<T>
    {
        public bool sosIgual(T invocador,T comparable);

        public bool sosMenor(T invocador, T comparable);

        public bool sosMayor(T invocador, T comparable);
    }
}
