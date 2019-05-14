using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5202.Cars
{
    public class Program
    {
        public static void Task1()
        {
            //Task 1
            Console.ForegroundColor = ConsoleColor.White; //Blake Jensen 30006830. Purpose: Class program
            Car c1 = new Car();
            c1.Make = "Nissan";
            c1.Model = "Juke NISMO RS";
            c1.Colour = "Avalanche White";
            c1.Rego = "97HGY3";
            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", c1.Make, c1.Model, c1.Colour, c1.Rego);
            Console.WriteLine("");
            
            Car c2 = new Car();
            c2.Make = "Nissan";
            c2.Model = "GTR R35 V-Spec";
            c2.Colour = "Titanium Grey";
            c2.Rego = "3254RY";
            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", c2.Make, c2.Model, c2.Colour, c2.Rego);
            Console.WriteLine("");
            
            Car c3 = new Car();
            c3.Make = "Toyota";
            c3.Model = "AE86 Levin";
            c3.Colour = "Midnight Black";
            c3.Rego = "0KNSD3";
            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", c3.Make, c3.Model, c3.Colour, c3.Rego);
            Console.WriteLine("");
            
            Car c4 = new Car();
            c4.Make = "Ferrari";
            c4.Model = "458 Speciale Aperta";
            c4.Colour = "Lemon Yellow";
            c4.Rego = "958DAB";
            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", c4.Make, c4.Model, c4.Colour, c4.Rego);
            Console.WriteLine("");

            Car c5 = new Car();
            c5.Make = "Ford";
            c5.Model = "GT";
            c5.Colour = "Miami Blue";
            c5.Rego = "Y33T3D";
            Console.WriteLine("Car Make: {0}\nModel: {1}\nColour: {2}\nRego: {3}", c5.Make, c5.Model, c5.Colour, c5.Rego);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private string colour;
        private string rego;

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string Rego { get { return rego; } set { rego = value; } }
    }
}
