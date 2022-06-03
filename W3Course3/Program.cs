using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            // By creating a pig object with class being pig I can't access the animalSound method,
            // only the pig animalSound method/implementation, even though I inherited. 

            Pig pig1 = new Pig(); //didn't make constructor so values initialized.
            pig1.animalSound(); // output: "oink, oink, oink"
            Console.WriteLine(pig1.externalCovering);//this is field of Animal class

            Dog dog1 = new Dog();
            dog1.animalSound();// output:"bow, wow, wow" 

            Animal animal1 = new Animal();
            animal1.animalSound(); //output:"animal makes sound"

             // By creating a new pig or dog using Animal class 
            Animal myAnimal = new Animal();
            Animal myPig = new Pig(); // output:"animal makes sound" as no overide keyword.
            Animal myDog = new Dog(); // output:"bow, wow, wow" as overide keyword is used. 

            Console.WriteLine(myDog.externalCovering);
            myAnimal.animalSound(); //output:"the animal makes a sound"
            myPig.animalSound(); //output:"the animal makes a sound" because did not use override keyword 
            myDog.animalSound();//output:"bow, woo, woo" because overrode animal class method

            Console.ReadKey();
        }
    }
}
