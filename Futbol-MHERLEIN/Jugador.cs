using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_MHERLEIN
{
    class Jugador
    {
        Pelota p = new Pelota();
        private int player;

        public int SetMaxPlayerQuantity() //Establezco la cantidad de jugadores Maxima;
        {
            player = 22;
            return player;
        }


    }
}
