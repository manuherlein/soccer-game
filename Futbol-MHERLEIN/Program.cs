using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_MHERLEIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j = new Jugador();
            Pelota p = new Pelota();
            Cancha c = new Cancha();

            c.SetCanchaSize();
            c.GetArea();
            p.HayPelota(c);
            j.SetMaxPlayerQuantity();
            c.AddPlayer();
            c.VerJugadores();
                          
            

            Console.Read();
        }
    }
}
