using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol_MHERLEIN
{
    class Pelota
    {
        Cancha c;
        private double radio;

        public void SetPelotaRadio() // Establezco el tamano de la Cancha
        {
            radio = 3.1416 * radio * 2;
        }

        public void HayPelota(Cancha c) //Checkeo si la pelota esta5 en la Cancha
        {
            if (c != null)
            {
                Console.WriteLine("Hay una pelota en cancha.");
            }
            else
            {
                Console.WriteLine("No hay una cancha donde poner una pelota.");
            }
            return;
            
        }

    }
}
