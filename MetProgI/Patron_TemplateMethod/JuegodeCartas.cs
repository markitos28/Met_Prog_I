using MetProgI.Folder_Coleccionables;
using MetProgI.Folder_Comparables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_TemplateMethod
{
    public abstract class JuegodeCartas
    {
        public Persona Player1 { get; set; }
        public Persona Player2 { get; set; }
        public Pila MazoCartas { get; set; }
        public Persona Jugar()//Pila mazo, Persona player1, Persona player2)
        {
            mezclarMazo(MazoCartas);
            if(Player1.cartas.Count.Equals(0) || Player2.cartas.Count.Equals(0))
                repartirCartasIniciales(Player1, Player2);
            Carta naipeP1 = jugarUnaMano(MazoCartas, Player1);
            Carta naipeP2 = jugarUnaMano(MazoCartas, Player2);
            Console.WriteLine("Jugador 1({0}):\t Carta: {1} {2}",Player1.Nombre, naipeP1.Valor, naipeP1.Simbolo);
            Console.WriteLine("Jugador 2({0}):\t Carta: {1} {2}", Player2.Nombre, naipeP2.Valor, naipeP2.Simbolo);
            existeJugador();
            if (naipeP1.sosMayor(naipeP2))
            {
                Player1.Puntaje += 2;
                return Player1;
            }
            else
            {
                Player2.Puntaje += 2;
                return Player2;
            }
            
        }

        public abstract void mezclarMazo(Pila mazo);
        public abstract void repartirCartasIniciales(Persona player1, Persona Player2);
        public abstract Carta jugarUnaMano(Pila mazo, Persona player);
        public abstract bool existeJugador();
    }
}
