using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE_01_Klasse_Objekt
{
    internal class Fahrzeug
    {

        private int speed = 0;  //private Eigenschaft definiert 
        private String definition; 

        //Konstruktor 
        public Fahrzeug(String d, int s)
        {
            this.speed = s;
            this.definition = d;
        }

        public Fahrzeug(String d)
        {
            this.definition = d;
            this.speed = 0; 
        }
        
        public Fahrzeug(int s)
        {
            this.definition = "leer";
            this.speed = s;
        }

        public Fahrzeug()
        {
            this.definition = "leer";
            this.speed = 0;
        }




        public String output()
        {
            return "Bezeichnung: " + definition + 
                   "\nGeschwindigkeit: " + this.speed + "\n";
        }

        public override String ToString()
        {
            return output();
        }

        public void accelerate(int value)
        {
            this.Speed += value; //setter wird verwendet durch großes S; ifs werden beachtet
        }

        //getter - setter (lesen, schreiben) 
        public int Speed
        {
            get
            {
                return this.speed;
            }
            private set
            {
                if (value > 100) this.speed = 100;
                else if (value < 0) this.speed = 0;
                else this.speed = value; 
            }       
        }



    }
}
