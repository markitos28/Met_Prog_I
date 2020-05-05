using System;
using System.Collections.Generic;
using System.Text;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Strategy;

namespace MetProgI.Patron_Observer
{
    public class Vendedor: Persona, I_Comparable, IObservado
    {
        private double _sueldoBasico;
        private double _bonus;
        private double _ultVenta=0;
        private List<IObservador> _listaObservadores;
        
        public double SueldoBasico { get { return _sueldoBasico; } set { _sueldoBasico = value; } }
        public double Bonus { get { return _bonus; } set { _bonus = value; } }

        public double UltimaVenta {  get { return _ultVenta; } set { _ultVenta = value; } }

        public List<IObservador> ListaObservadores { get { return _listaObservadores; } set { _listaObservadores = value; } }

        public Vendedor(string in_nombre, int in_dni, double in_suedoBasico)
        {
            base.Nombre = in_nombre;
            base.DNI = in_dni;
            this.SueldoBasico = in_suedoBasico;
            this.Bonus = 1;
            this.ListaObservadores = new List<IObservador>();
            base.Estrategia = new StratComparacion_Bonus();
        }

        public void venta(double monto)
        {
            this.UltimaVenta = monto;
            //Console.WriteLine("El vendedor {0} ha concretado una venta por un valor de {1}.", this.Nombre, monto);
            notificar();

        }

        public void aumentaBonus()
        {
            this.Bonus += 0.1;
        }

        public void agregarObservador(IObservador observador)
        {
            ListaObservadores.Add(observador);
        }

        public void quitarObservador(IObservador observador)
        {
            ListaObservadores.Remove(observador);
        }

        public void notificar()
        {
            foreach(IObservador observador in ListaObservadores)
            {
                observador.actualizar(this);
            }
        }
    }
}
