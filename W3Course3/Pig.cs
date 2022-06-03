using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course3
{
    class Pig:Animal
    {
        public  void animalSound() //overide keyword overides using Animal method.
        {
            Console.WriteLine("The pig says: oink, oink, oink");
        }
    }
}
