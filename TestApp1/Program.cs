﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello World! My name is {0} and I am {1} years old. I was born in {2}.", userName,
                userAge, currentYear - userAge);

            //int counter = 5;
            //while (counter > 0)
            //{
            //    Console.WriteLine("Counter = {0}", counter);
            //    counter = counter - 1;
            //}
        }
    }
}


