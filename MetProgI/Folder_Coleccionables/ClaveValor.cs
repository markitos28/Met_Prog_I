using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;

namespace MetProgI.Folder_Coleccionables
{
    class ClaveValor
    {
        public Numero clave;
        public Persona valor;
        public ClaveValor(Numero in_clave, Persona in_valor)
        {
            this.clave = in_clave;
            this.valor = in_valor;
        }
    }
}
