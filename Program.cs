using System;
using System.Collections.Generic;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose one of these three methods");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");

            var input = Int32.Parse(Console.ReadLine());

            if (input >= 4 || input <= 0)
            {
                Console.WriteLine("Please enter a number between 1 - 3");
                Console.ReadLine();
            }
            else
            {

                if (input == 1)
                {
                    FirstMethod first = new FirstMethod();
                    first.First();
                }
                else if (input == 2)
                {
                    SecondMethod second = new SecondMethod();
                    second.Second();
                }
                else
                {
                    ThirdMethod third = new ThirdMethod();
                    third.Third();
                }

            }
        }
    }
    }

