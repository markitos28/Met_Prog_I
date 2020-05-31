using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using MetProgI.Patron_Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_TemplateMethod
{
    public class OroMaldito : JuegodeCartas
    {
        //public Persona Player1 { get; set; }
        //public Persona Player2 { get; set; }
        //public Pila MazoCartas { get; set; }
        public OroMaldito(Pila mazo, Persona player1, Persona player2) 
        {
            cargarMazo(mazo);
            Player1 = player1;
            Player2 = player2;
            MazoCartas = mazo;
        }

        public override bool existeJugador()
        {
            return (Player1 != null | Player2 != null) ? true : false;
        }

        public override Carta jugarUnaMano(Pila mazo, Persona player)
        {
            int rnd = new Random().Next(1,5);
            Carta desechar = player.cartas[rnd];
            player.cartas[rnd]= (Carta)MazoCartas.pop();
            return desechar;
        }

        private void cargarMazo(Pila mazo)
        {
            Carta naipe;
            for (int i= 1; i<=4; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    naipe = new Carta(j,i);
                    mazo.push(naipe);
                }
            }
            // Carga de los dos comodines
            naipe = new Carta(13, 5);
            mazo.push(naipe);
            naipe = new Carta(13, 5);
            mazo.push(naipe);

        }

        public override void mezclarMazo(Pila mazo)
        {
            List<Carta> mazoMezclado = new List<Carta>();
            IIterator iter = mazo.CreateIterator();
            while(!iter.EsFin())
            {
                mazoMezclado.Add((Carta)iter.Siguiente());
            }
            for(int j=0;j<5;j++)
            {
                int numero = mazoMezclado.Count;
                numero = numero - (j * 10);
                for (int i = 0; i < 5; i++)
                {
                    numero = numero / 2;
                    if (numero - 1 > 0)
                    {
                        Carta anterior = mazoMezclado[numero - 1];
                        mazoMezclado[numero - 1] = mazoMezclado[(numero * 2) - 1];
                        mazoMezclado[(numero * 2) - 1] = anterior;
                    }
                }
            }
            mazo = new Pila();
            for (int i = 0; i < mazoMezclado.Count; i++)
            {
                mazo.push(mazoMezclado[i]);
            }
        }

        public override void repartirCartasIniciales(Persona player1, Persona player2)
        {
            for (int i = 1; i <= 5; i++)
            {
                player1.cartas.Add((Carta)MazoCartas.pop());
                player2.cartas.Add((Carta)MazoCartas.pop());
            }
        }
    }
}
