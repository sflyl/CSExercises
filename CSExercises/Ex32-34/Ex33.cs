using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("array");
            int[] list = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i = 0;
            for (i = 0; i < 20; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (list[i] < list[j])
                    {
                        int t = list[i];//i=0
                        list[i] = list[j];
                        list[j] = t;
                    }
                }
            }
            for(i = 0; i < 20; i++)
            {
                System.Console.WriteLine(list[i]);
            }
            
        }
    }
}



