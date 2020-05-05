using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Observer
{
    public interface IObservador
    {
        public void actualizar(IObservado observado);
    }
}
