﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter number : ");
            String b = Console.ReadLine();
            double c = Convert.ToDouble(b);
            double d = Math.Sqrt(c);
            Console.WriteLine("Answer: {0:#.###}",d);

        }
    }
}
