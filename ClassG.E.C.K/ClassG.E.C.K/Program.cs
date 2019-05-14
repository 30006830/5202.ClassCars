using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassG.E.C.K
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //task 2
            //Blake Jensen 30006830. Program Purpose: Class Program 2
            Console.ForegroundColor = ConsoleColor.White;
            /*First Name and Last Name are public, age is private. Use a constructor to populate the properties of the objects creation. Create person objects and display full name and age to user.*/

            Person Blake = new Person("Blake", "Jensen", 19);
            Console.WriteLine("Details:");
            Console.WriteLine($"Name: {Blake.Fname} {Blake.Lname} \nAge: {Blake.Age}");
            string fname, lname;
            int age;
            Console.WriteLine("Enter a First Name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter a Last Name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Enter an age: ");
            age = int.Parse(Console.ReadLine());

            Person p1 = new Person(fname, lname, age);
            Console.WriteLine($"Name: {fname + " " + lname}\nAge: {age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        private string fname;
        private string lname;
        private int age;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string _fname, string _lname, int _age)
        { 
            Console.WriteLine("");
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }
    }
}
