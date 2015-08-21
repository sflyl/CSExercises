using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter x value: ");
            String S = Console.ReadLine();
            double O = Convert.ToDouble(S);
            double a = Math.Pow(O, 2);
            double y = 2*a - 4*O + 3;
            Console.WriteLine(y);




        }
    }
}
