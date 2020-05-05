using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Coleccionables;

namespace MetProgI.Patron_Observer
{
    class Gerente : IObservador
    {
        private List<Vendedor> _mejoresVendedores;
        public List<Vendedor> MejoresVendedores {  get { return _mejoresVendedores; } set { _mejoresVendedores = value; } }

        public Gerente()
        {
            MejoresVendedores = new List<Vendedor>();
        }

        public void cerrar()
        {
            Console.WriteLine("La lista de los Mejores Vendedores es: ");
            foreach (Vendedor elemento in MejoresVendedores)
            {
                Console.WriteLine("{0} sumo un bonus de : {1}.", elemento.Nombre, elemento.Bonus);
            }
        }

        public void venta(double monto, Vendedor vendedor)
        {
            if(monto> 5000)
            {
                if(!MejoresVendedores.Contains(vendedor))
                {
                    MejoresVendedores.Add(vendedor);
                }
                vendedor.aumentaBonus();
            }
        }
        public void actualizar(IObservado observado)
        {
            Vendedor vendedorObservado = (Vendedor)observado;
            venta(vendedorObservado.UltimaVenta, vendedorObservado);
        }
    }
}
