﻿using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonus = 0;
            if(number > 1000)
            {
                bonus += number * 0.10;
            }
            else if(number > 100)
            {
                bonus += number * 0.20;
            }
            else
            {
                bonus += 5;
            }
            if (number % 2 == 0)
            {
                bonus += 1;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
