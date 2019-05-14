using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassS.T.A.M
{
    public class Animal
    {
        string type, sound;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Sound
        {
            get { return sound; }
            set { sound = value; }
        }
        public Animal(string _type, string _sound)
        {
            Type = _type;
            Sound = _sound;
        }

        public string AnimalSays()
        {
            return "The " + Type + " says " + Sound;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the animals type (i.e Cow, Dog, Cat, etc.): ");
            string animalType = Console.ReadLine();
            Console.WriteLine("Now enter the sound the animal makes: ");
            string animalSound = Console.ReadLine();

            Animal animal = new Animal(animalType, animalSound);

            Console.WriteLine(animal.AnimalSays());
            Console.ReadLine();
        }
    }
}
