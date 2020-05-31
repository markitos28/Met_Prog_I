using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MetProgI.Folder_Coleccionables;

namespace MetProgI.Patron_Composite
{
    public class CompuestoAlumno : Component
    {
        private List<AbsAlumno> _alumnosCompuestos;

        public override int Legajo { get { return base._legajo; } set { base._legajo = value; } }
        public override double Promedio { get { return this.Promedio; } set { this.Promedio = value; } }
        public override double Calificacion { get { return base._calificacion; } set { base._calificacion=(int)value; } }

        public CompuestoAlumno(string in_nombre, int in_dni, int in_legajo, int in_calificacion) : base(in_nombre, in_dni, in_legajo, in_calificacion)
        {
            _alumnosCompuestos = new List<AbsAlumno>();
        }

        public override string mostrarCalificacion()
        {
            string calificaciones = "";
            foreach (AbsAlumno puntero in _alumnosCompuestos)
            {
                calificaciones+=" "+ puntero.mostrarCalificacion();
            }
            return calificaciones;
        }

        public override int responder(int pregunta)
        {
            List<int> respuestas = new List<int>();
            foreach(Component puntero in _alumnosCompuestos)
            {
                respuestas.Add(puntero.responder(pregunta));
            }

            return maxCount(respuestas);
        }

        private int maxCount(List<int> lista)
        {
            lista.Sort();
            int contador = 0;
            int anterior =lista[0];
            int numeroMaximo = 0;
            int contadorAnterior = 0;
            for(int i=1; i< lista.Count;i++)
            {
                if(anterior==lista[i])
                {
                    contador += 1;
                    anterior = lista[i];
                }
                else 
                {
                    if (contadorAnterior < contador)
                        numeroMaximo = anterior;
                    contadorAnterior = contador;
                }
            }
            return numeroMaximo;
        }

        public override void setCalificacion(int inCalificacion)
        {
            foreach(Component elemento in _alumnosCompuestos)
            {
                elemento.setCalificacion(inCalificacion);
            }
            
        }

        public override bool sosIgual(AbsAlumno comparable)
        {
            bool verificacion=false;
            foreach(Component elemento in _alumnosCompuestos)
            {
                verificacion=elemento.sosIgual(comparable);
            }
            return verificacion;
        }

        public override bool sosMayor(AbsAlumno comparable)
        {
            bool verificacion = false;
            foreach (Component elemento in _alumnosCompuestos)
            {
                verificacion = elemento.sosMayor(comparable);
            }
            return verificacion;
        }

        public override bool sosMenor(AbsAlumno comparable)
        {
            bool verificacion = false;
            foreach (Component elemento in _alumnosCompuestos)
            {
                verificacion = elemento.sosMenor(comparable);
            }
            return verificacion;
        }

        public void agregar(AbsAlumno alumno)
        {
            _alumnosCompuestos.Add(alumno);
        }

        public void agregarAlumno(AbsAlumno alumno)
        {
            _alumnosCompuestos.Add(alumno);
        }

        public void remover(Component alumno)
        {
            _alumnosCompuestos.Remove(alumno);
        }

        public override string imprimirDecorado()
        {
            return "";
        }

        public override int responderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
