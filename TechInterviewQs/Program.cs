﻿using System;
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

            //Console.WriteLine("Please enter an integer");
            //int userNum = int.Parse(Console.ReadLine());

            //if (userNum % 5 == 0 && userNum % 3 == 0)
            //{
            //    Console.WriteLine("FIZZBUZZ");
            //}
            //else if (userNum % 3 == 0)
            //{
            //    Console.WriteLine("FIZZ");

            //}
            //else if (userNum % 5 == 0)
            //{
            //    Console.WriteLine("BUZZ");
            //}

            //else
            //{
            //    Console.WriteLine("Sorry, not divisible by 3 or 5 - better luck next time!");
            //}
            //////////////////////////////////////////////////////////////////////////////////

            //Tech interview question
            //what is the difference between an Array and a List?

            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question
            //difference between reference types and value types
            //stacks vs heaps
            //reference types are pointers to data located on the heap
            //C# does the garbage collection for us - other languauges you have to reallocate space


            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question
            //stringbuilder - how does it work?

            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question (9/12)
            //print out all prime numbers that are less than 100 to the console ***THIS DIDN'T WORK
            //0 and 1 are not prime numbers
            //{
            //    int beginNumber = 2;
            //    int endNumber = 100;
            //    Console.WriteLine("What number would you like to start with?");
            //    beginNumber = int.Parse(Console.ReadLine());
            //    Console.WriteLine("What number would you like to end with?");
            //    endNumber = int.Parse(Console.ReadLine());

            //    List<int> primeNums = new List<int>() { 2, 3, 5, 7 }; //initial 
            //    bool isPrime = true;


            //    for (int i = beginNumber; i < endNumber; i++) //outer loop
            //    {
            //        for (int j = 2; j < i; j++) //inner loop
            //        {
            //            if (i!j && i % j == 0)    
            //    } } }
            //        { isPrime = false;
            //        break;
            //    }
            //}

            //    }

            //    if (isPrime)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    isPrime = true;

            //    }

            //}

            
            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question 9/13-1
            //Create a method that takes one int Array
            //the method should return the largest # in that array

         
            int[] numArray = {10101, 3, 7, 98, 123, 4, 67, 34, 8787, 33, -9000 };
            int maxNumber = LargestNum(numArray);
            Console.WriteLine("The largest number in the array is " + maxNumber);


            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question (9/13 - 2)
            //Create a method that takes a string
            //then returns the string reversed (without using .Reverse)

            string aString = "This is a string";
            
            Console.WriteLine(ReverseTheString(aString));

            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question




            //////////////////////////////////////////////////////////////////////////////////
            //Tech interview question

            ///////////////////////////////////////////END OF MAIN ///////////////////////////////////////
        }
        //creating a method that finds the largest number in the array (9/13-1)
        public static int LargestNum(int[] numArray) //this method takes in an integer array as input
        {
            int biggestNum = numArray[0];  //setting initial value to first of array takes care of problem of negative numbers
            for (int i = 0; i < numArray.Length; i++)
            {                
                if (numArray[i] > biggestNum)
                {
                    biggestNum = numArray[i];                    
                }
            }
            return biggestNum; //remember, the variable biggestNum only exists within this method - 
            //need to assign a name to what is being returned within the main program (can call it the same thing or not)
        }
        //////////////////////////////////////////////////////////////////////////////////////
        //creating a method to reverse a string (9/13-2)
        public static string ReverseTheString(string aString)
        {
            string reversedString = "";

            for (int i= aString.Length - 1; i>=0;i--)
            {                
                    reversedString += aString[i]; //concatenating in reverse order          
                //alternative - reverse the string in place (switching end and beginning etc to middle)      
            }
            return reversedString;
        }
        //////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////do not erase two curly brackets below this /////////////
    }
}
