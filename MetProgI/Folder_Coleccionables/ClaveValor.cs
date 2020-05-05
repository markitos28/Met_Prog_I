using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;

namespace MetProgI.Folder_Coleccionables
{
    class ClaveValor: I_Comparable
    {
        public Numero clave;
        public I_Comparable valor;
        public ClaveValor(Numero in_clave, I_Comparable in_valor)
        {
            this.clave = in_clave;
            this.valor = in_valor;
        }

        // implementar estos tres metodos asi haces una reingenieria en Diccionario para que sea mas facil comparar
        // y asi romper con la funcion exclusiva para diccionario.
        public bool sosIgual(I_Comparable comparable)
        {
            return this.valor.sosIgual(comparable);
        }

        public bool sosMayor(I_Comparable comparable)
        {
            return this.valor.sosMayor(comparable);
        }

        public bool sosMenor(I_Comparable comparable)
        {
            return this.valor.sosMenor(comparable);
        }
    }
}
