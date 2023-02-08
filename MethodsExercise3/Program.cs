using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void PrintNumbers1000()
        {

            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintNumbers999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        static void TwoNumbersEqualOrNot(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine(" They are not equal");
            }
        }
        static void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("This number is even");
            }
            else
            {
                Console.WriteLine("This number is odd");
            }
        }
        static void PositveOrNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Then it is positive");
            }
            else
            {
                Console.WriteLine("Otherwise it is negative");
            }
        }
        static void OldEnoughToVote()
        {
            Console.WriteLine("Enter in your age");
            var answer = int.Parse(Console.ReadLine());
            if (answer >= 18)
            {
                Console.WriteLine("You are old enogh to vote!");
            }
            else
            {
                Console.WriteLine("You're gonna have to wait a few more years..");
            }
        }
        static void Main(string[] args)
        {
            // PrintNumbers999();
            //TwoNumbersEqualOrNot(1, 2);
            OldEnoughToVote();

        }
          
    }
}