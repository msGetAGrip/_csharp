﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisCSharp.chap05.SwitchExp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // A switch statement can be used to produce values through branching, allowing you to write more readable code.
            Console.WriteLine("Please enter the score");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you retaking this course? (y,n)");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"credit: {grade}");
        }

    }
}
