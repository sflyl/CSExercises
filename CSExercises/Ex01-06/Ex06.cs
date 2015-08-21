using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            String a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            double c = Convert.ToDouble(b);
            double d = Math.Sqrt(c);
            Console.WriteLine(d);
                    }
    }
}
