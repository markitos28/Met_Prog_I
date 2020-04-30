using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.PatronIterator
{
    public interface IIterator
    {
        public object Siguiente();

        public bool EsFin();

        public void Reset();
    }
}
