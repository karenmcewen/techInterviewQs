using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an application that asks the user for an integer.
            //If the number is divisible by 3 "fizz". by 5 "buzz"; by both "fizzbuzz"

            Console.WriteLine("Please enter an integer");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum % 5 == 0 && userNum % 3 == 0)
            {
                Console.WriteLine("FIZZBUZZ");
            }
            else if (userNum % 3 == 0)
            {
                Console.WriteLine("FIZZ");

            }
            else if (userNum % 5 == 0)
            {
                Console.WriteLine("BUZZ");
            }
           
             else
            {
                Console.WriteLine("Sorry, not divisible by 3 or 5 - better luck next time!");
            }
        }
    }
}
