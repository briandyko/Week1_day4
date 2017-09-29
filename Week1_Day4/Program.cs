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

            //string firstName = "Daniel";
            //string dogName = "Gus";

            //Console.WriteLine("My name is {0} and my dog is {1}.", firstName, dogName);

            //string bestFriends = firstName + " " + dogName;
            //Console.WriteLine(bestFriends);

            //string bestFriends = string.Concat(firstName, " ", dogName);
            //Console.WriteLine(bestFriends);

            // int daniellength = firstName.Length;

            // Console.WriteLine(firstName.Length);
            // Console.WriteLine(bestFriends.Length);

            //-----

            // string myFirst = Console.ReadLine();
            // string myLast = Console.ReadLine();

            // Console.WriteLine(myFirst.Length);
            // Console.WriteLine(myLast.Length);

            // if (myFirst.Length > myLast.Length)
            // {
            //     Console.WriteLine("First is longer.");
            // }
            //else if (myFirst.Length==myLast.Length)
            // {
            //     Console.WriteLine("Samsis.");
            // }
            // else
            // {
            //     Console.WriteLine("last must be longer.");
            // }
            //----------------

            //string person = "Peggy";
            //string diffPerson = "Margaret";

            //if (person == diffPerson)
            //{
            //    Console.WriteLine("The names are the same.");
            //}
            //else
            //{
            //    Console.WriteLine("The names are different.");
            //}

            //bool okay = string.Equals(person, diffPerson);
            //Console.WriteLine(okay)

            //Console.WriteLine("What is your first name?");
            //string fname = Console.ReadLine();

            //Console.WriteLine("What is your last name?");
            //string lname = Console.ReadLine();

            //Console.WriteLine("Your full name is full name is " + fname + " " + lname);

            Console.WriteLine("Guess the type of animal? (hint: not a dog)");
            string pet = Console.ReadLine();

            string answer = "cat";


            if (pet.ToLower() == answer)
                {
                Console.WriteLine("You guessed correctly!");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }





        }
    }
}
