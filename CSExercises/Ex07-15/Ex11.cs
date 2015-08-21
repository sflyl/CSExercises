using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance: ");
            String A = Console.ReadLine();
            Double B = Convert.ToDouble(A);
            char F = '$';
            Double G = 2.40 + B * 0.4;
            Console.WriteLine("Your fare is : " + F + G);

        }
    }
}
