using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_01_Klasse_Objekt
{
    internal class Fahrzeug
    {

        private int speed;  //private Eigenschaft definiert 




        public String toString()
        {
            return "Geschwindigkeit: " + this.speed;
        }

        public void accelerate(int value)
        {
            this.speed += value; 
        }



    }
}
