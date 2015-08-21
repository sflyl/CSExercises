using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your temperature: ");
            string S = Console.ReadLine();
            double T = Convert.ToDouble(S);
            double F = 1.8 * T + 32;
            Console.WriteLine(F);
        }
    }
}
