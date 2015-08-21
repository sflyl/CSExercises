using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            string s = Console.ReadLine();
            int i = Convert.ToInt32(s);
            double r = Math.Pow(i,2);
            Console.WriteLine(r);

        }
    }
}
