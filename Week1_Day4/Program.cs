using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is a tab \t. ");
            //Console.WriteLine("This is a \"quote\".");
            //Console.WriteLine("This is a backslash \\");
            //Console.WriteLine("This is a \n new line.");
            //Console.WriteLine("And this is a bell \a");

            string firstName = "Daniel";
            string dogName = "Gus";

            //Console.WriteLine("My name is {0} and my dog is {1}.", firstName, dogName);

            //string bestFriends = firstName + " " + dogName;
            //Console.WriteLine(bestFriends);

           string bestFriends = string.Concat(firstName, " ", dogName);
           Console.WriteLine(bestFriends);

            Console.WriteLine(firstName.Length);
            Console.WriteLine(bestFriends.Length);



        }
    }
}
