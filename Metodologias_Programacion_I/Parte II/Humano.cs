using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I.Parte_II
{
    public abstract class Humano
    {
        private string _nombre;
        private int _DNI;

        public string Nombre { get { return this._nombre; } protected set { this._nombre = value; } }

        public int DNI { get { return this._DNI; } protected set { this._DNI = value; } }
    }
}
