/*
 * Created by Metodologías de Programación I
 * Activity 7. 
 * Chain of responsability and Singleton patterns 
 *
 * Antes de usar este código el alumno deberá agregar a la variable "ruta_archivo" de la clase 
 * "LectorDeArchivos" la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
 * provistos por la cátedra (archivo datos.txt)
 *
 * IMPORTANTE *  
 * El código que está en este archivo SI puede modificarse para resolver la actividad solicitada
 * 
 */

using System;
using System.IO;
using MetodologíasDeProgramaciónI;
using MetProgI.Patron_ChainofResponsability;

namespace MetProgI.Patron_ChainofResponsability
{
	public class LectorDeArchivos : Manejador
	{
		private static LectorDeArchivos Lector { get; set; }

		// El alumno deberá agregar la ruta correspondiente a su equipo donde haya guardado el archvo con los datos
		private const string ruta_archivo = @"C:\Users\Marcos Sosa\source\repos\Practicas_Y_Ejercicios\MetProgI\Patron_ChainofResponsability\datos.txt";
		// --------------------------------------------------------------------------------------------------------

		private StreamReader lector_de_archivos;

		private LectorDeArchivos(Manejador inSucesor) : base(inSucesor)
		{
			lector_de_archivos = new StreamReader(ruta_archivo);
		}

		public static LectorDeArchivos getInstance(Manejador inSucesor)
		{
			if (Lector == null)
				Lector = new LectorDeArchivos(inSucesor);
			return Lector;
		}

		public override int numeroAleatorio(int limite)
		{
			if (Sucesor != null)
				return Sucesor.numeroAleatorio(limite);
			return 0;
		}

		public override double numeroDesdeArchivo(double max){
			string linea = lector_de_archivos.ReadLine();
			return Double.Parse(linea.Substring(0, linea.IndexOf('\t'))) * max;
		}

		public override int numeroPorTeclado()
		{
			if (Sucesor != null)
				return Sucesor.numeroPorTeclado();
			return 0;
		}

		public override string stringAleatorio(int cantidad_chr)
		{
			if (Sucesor != null)
				return Sucesor.stringAleatorio(cantidad_chr);
			return "";
		}

		public override string stringDesdeArchivo(int cant){
			string linea = lector_de_archivos.ReadLine();
			linea = linea.Substring(linea.IndexOf('\t')+1);
			cant = Math.Min(cant, linea.Length);
			return linea.Substring(0, cant);
		}

		public override string stringPorTeclado()
		{
			if (Sucesor != null)
				return Sucesor.stringPorTeclado();
			return "";
		}
	}
}
