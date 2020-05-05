using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Observer
{
    public interface IObservado
    {
        public void agregarObservador(IObservador observador);
        public void quitarObservador(IObservador observador);
        public void notificar();
    }
}
