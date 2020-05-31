using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Folder_Comparables
{
    public class Carta : I_Comparable
    {
        public int Valor { get; set; }
        public string Simbolo { get; set; }
        public int PesoSimbolo { get; set; }

        public Carta(int valor, int pesoSimbolo)
        {
            Valor = valor;
            PesoSimbolo = pesoSimbolo;
            if (PesoSimbolo.Equals(1)) Simbolo = "Espada";
            else if (PesoSimbolo.Equals(2)) Simbolo = "Basto";
            else if (PesoSimbolo.Equals(3)) Simbolo = "Oro";
            else if (PesoSimbolo.Equals(4)) Simbolo = "Copa";
            else Simbolo = "Comodin";
        }
        public bool sosIgual(I_Comparable comparable)
        {
            Type tipo = comparable.GetType();
            Type obj = this.GetType();
            if(tipo.Equals(obj))
            {
                return Valor.Equals(((Carta)comparable).Valor) && PesoSimbolo.Equals(((Carta)comparable).PesoSimbolo) ? true: false;
            }
            return false;
        }

        public bool sosMayor(I_Comparable comparable)
        {
            Type tipo = comparable.GetType();
            Type obj = this.GetType();
            if (tipo.Equals(obj))
            {
                return Valor > ((Carta)comparable).Valor && PesoSimbolo <= ((Carta)comparable).PesoSimbolo ? true : false;
            }
            return false;
        }

        public bool sosMenor(I_Comparable comparable)
        {

            Type tipo = comparable.GetType();
            Type obj = this.GetType();
            if (tipo.Equals(obj))
            {
                return Valor < ((Carta)comparable).Valor && PesoSimbolo < ((Carta)comparable).PesoSimbolo ? true : false;
            }
            return false;
        }
    }
}
