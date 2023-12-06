using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            string firstname;
            int age;

            //initialisation 
            firstname = "Inathi";
            age = 12;

            //what will be on console
            Console.WriteLine("Hi " + firstname + " you are " +  age + "years old");
             
            firstname = "Noma";
            age = 75;

            Console.WriteLine("Hallo " + firstname + " you are " + age + "years old");

            string Lastname = "Thomas";
            Console.WriteLine("Hallo I am " + firstname + " " + Lastname + " a " + age + "year old strong women");

            //freeze console
            Console.ReadLine();
        }
    }
}
