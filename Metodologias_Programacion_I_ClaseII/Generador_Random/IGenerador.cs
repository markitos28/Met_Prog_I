using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.Generador_Random
{
    interface IGenerador
    {
        public string Gen_Nombre();
        public int Gen_DNI();
        public int Gen_Legajo();
        public double Gen_Promedio();
    }
}
