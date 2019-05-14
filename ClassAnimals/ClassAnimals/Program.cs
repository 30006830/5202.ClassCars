using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Animal a1 = new Animal();
            a1.Type = "Giraffe";
            a1.Name = "Harold";

            Console.WriteLine("Animal Type: {0}\nName: {1}\nID: {2}", a1.Type, a1.Name, a1.ID);
            Console.ReadLine();
        }
    }
    class Animal
    {
        public string type;
        public string name;
        public int id;

        public string Type { get { return type; } set { type = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int ID { get { return id; } set { id = value; } }

        private int randID()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }

        public Animal()
        {
            Console.WriteLine("New object has been created!");
            ID = randID();
        }
    }
}
