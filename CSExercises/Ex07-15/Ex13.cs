using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance: ");
            String A = Console.ReadLine();
            Double B = Convert.ToDouble(A);
            
            Double G = 2.40 + B * 0.4;
            Double K = Math.Round(G, 2);
            Double M = Math.Ceiling(K);
            Console.WriteLine("Your fare is {0: 0.00}", M);
        }
    }
}
