using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Please type in your salary: ");
            string s = (Console.ReadLine());
            double t = Convert.ToDouble (s);
            double h = 0.1*t;
            double p = 0.03*t;
            double b = (t + h + p);
            char c = '$';
            Console.WriteLine("Your salary is " + c + b);


        }
    }
}
