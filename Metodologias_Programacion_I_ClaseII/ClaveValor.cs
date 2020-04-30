using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    class ClaveValor
    {
        public Numero clave;
        public object valor;
        public ClaveValor(Numero in_clave, object in_valor)
        {
            this.clave = in_clave;
            this.valor = in_valor;
        }
    }
}
