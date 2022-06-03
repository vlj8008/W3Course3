using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course3
{
    class Animal
    {
        public string externalCovering = "skin";

        public virtual void animalSound() //virtual keyword modifies method allowing for it to 
        // be overidden in child classes. 
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
