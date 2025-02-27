using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstratePolyMorphism
{ 
    abstract class TestingPolyMorphism
    {
        public abstract void printAnimalSounds(string animal, string sound);

        public void sounds()
        {
            Console.WriteLine("Printing Animals and Sounds");
        }
        
    }

    class Lion : TestingPolyMorphism
    {
        public override void printAnimalSounds(string animal, string sound)
        {
            Console.WriteLine("I am "+animal+" and my sound is "+sound +" and I am the king!");
        }

        public new void sounds()
        {
            Console.WriteLine("Printing Animal name and Sound for Lion");
        }

    }
    class Tiger : TestingPolyMorphism
    {
        public override void printAnimalSounds(string animal, string sound)
        {
            Console.WriteLine("I am " + animal + " and my sound is " + sound+" and I am the national animal");
        }
        public new void sounds()
        {
            Console.WriteLine("Printing Animal name and Sound for Tiger");
        }
    }

    class Elephant : TestingPolyMorphism
    {
        public override void printAnimalSounds(string animal, string sound)
        {
            Console.WriteLine("I am " + animal + " and my sound is " + sound + " and I am the largest animal");
        }
        public new void sounds()
        {
            Console.WriteLine("Printing Animal name and Sound for Elephant");
        }
    }
    public class DemonstratePolyMorphismConcept
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.printAnimalSounds("Lion", "Roar");
            lion.sounds();
            Tiger tiger = new Tiger();
            tiger.printAnimalSounds("Tiger", "Roars");
            tiger.sounds();
            Elephant elephant = new Elephant();
            elephant.printAnimalSounds("Elephant", "Trumpet");
            elephant.sounds();

        }
    }
}
