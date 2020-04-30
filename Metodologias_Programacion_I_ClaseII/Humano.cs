using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII
{
    public abstract class Humano
    {
        private string _nombre;
        private int _DNI;
        private IStrategy<Humano> _Estrategia;

        public string Nombre { get { return this._nombre; } protected set { this._nombre = value; } }

        public int DNI { get { return this._DNI; } protected set { this._DNI = value; } }

        public IStrategy<Humano> Estrategia { get { return this._Estrategia; } set { this._Estrategia = value; } }
    }
}
