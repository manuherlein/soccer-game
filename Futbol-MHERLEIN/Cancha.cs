using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_MHERLEIN
{
    class Cancha
    {
        Pelota p = new Pelota();
        Jugador j = new Jugador();
        List<Jugador> listJugadores = new List<Jugador>();
        private int canchaX;
        private int canchaY;
        private int area;

        public void SetCanchaSize() //Le establezco el tamano a la Cancha
        {
            canchaX = 80;
            canchaY = 100;
        }

        public void GetArea() // Calculo el area de la Cancha
        {
            area = canchaX * canchaY;
            Console.WriteLine("El area total de la cancha es de: " + area + " metros cuadrados.");
            return;            
        }
                      
        public void VerJugadores() //Ve si hay algun jugador en la Cancha
        {
            if (j!=null)
            {
                Console.WriteLine("Hay " + listJugadores.Count + " jugadores en cancha.");
                return;
            }

            //if (j > j.SetMaxPlayerQuantity())   //Ve si hay mas jugadores de los permitidos
            //{
            //    Console.WriteLine("Hay mas de 22 jugadores, por favor reduzca su cantidad.");
            //}
        }

        public void AddPlayer() //Agrego los jugadores a la Cancha
        {
            for (int i = 0; i < j.SetMaxPlayerQuantity(); i++)
            {
                listJugadores.Add(j);
            }
        }

    }
}
