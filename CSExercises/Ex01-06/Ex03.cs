using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            String s = Console.ReadLine();
            double i = Convert.ToDouble(s);
            double u = Math.Sqrt(i);
            Console.WriteLine(u);

        }
    }
}
