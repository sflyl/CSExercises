using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter x1: ");
            String S = Console.ReadLine();
            Double T = Convert.ToDouble(S);
            

            Console.Write ("Please enter x2: ");
            String B = Console.ReadLine ();
            Double C = Convert.ToDouble(B);
            

            Console.Write("Please enter y1: ");
            String U = Console.ReadLine();
            Double Y = Convert.ToDouble(U);
            

            Console.Write("Please enter y2: ");
            String O = Console.ReadLine();
            Double P = Convert.ToDouble(O);
            

            Double W = C - T;
            Double I = Math.Pow(W, 2);
            Double G = P - Y;
            Double K = Math.Pow(G, 2);
            Double V = I + K;
            Double X = Math.Sqrt(V);
            Console.WriteLine("Distance: " + X);





             

        }
    }
}
