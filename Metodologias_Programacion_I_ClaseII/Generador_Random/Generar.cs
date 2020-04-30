using System;
using System.Collections.Generic;
using System.Text;

namespace Metodologias_Programacion_I_ClaseII.Generador_Random
{
    public class Generar : IGenerador
    {
        public int Gen_DNI()
        {
            Random rnd_dni = new Random();
            int dni = rnd_dni.Next(36000000, 43000000);
            return dni;
        }

        public int Gen_Legajo()
        {
            Random rnd_legajo = new Random();
            int legajo = rnd_legajo.Next(0, 20000);
            return legajo;
        }

        public string Gen_Nombre()
        {
            List<string> nombresAlAzar = new List<string>
            {
                "JUAN","JOSÉ LUIS","JOSÉ","MARÍA GUADALUPE",
                "FRANCISCO","GUADALUPE","MARÍA","JUANA",
                "ANTONIO","JESÚS","MIGUEL ÁNGEL","PEDRO",
                "ALEJANDRO","MANUEL","MARGARITA","MARÍA DEL CARMEN",
                "JUAN CARLOS","ROBERTO","FERNANDO","DANIEL",
                "CARLOS","JORGE","RICARDO","MIGUEL",
                "EDUARDO","JAVIER","RAFAEL","MARTÍN",
                "RAÚL","DAVID","JOSEFINA","JOSÉ ANTONIO",
                "ARTURO","MARCO ANTONIO","JOSÉ MANUEL","FRANCISCO JAVIER",
                "ENRIQUE","VERÓNICA","GERARDO","MARÍA ELENA",
                "LETICIA","ROSA","MARIO","FRANCISCA",
                "ALFREDO","TERESA","ALICIA","MARÍA FERNANDA",
                "SERGIO","ALBERTO"
            };
            Random rnd_nom = new Random();
            int indice_nom = rnd_nom.Next(nombresAlAzar.Count);
            return nombresAlAzar[indice_nom];
        }

        public double Gen_Promedio()
        {
            Random rnd_promedio = new Random();
            double promedio = Math.Round(rnd_promedio.Next(0, 10) + rnd_promedio.NextDouble(), 2);
            return promedio;
        }
    }
}
