using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Marks");
            int[] grades = new int[]
           {
           63,
           29,
           75,
           82,
           55
           };

            int i = 0;
            for (i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {

                    if (grades[i] < grades[j])
                    {
                        int t = grades[i];
                        grades[i] = grades[j];
                        grades[j] = t;
                    }

                }

            }

            for (i = 0; i < 5; i++)
            {
                System.Console.WriteLine(grades[i]);
            }
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            System.Console.WriteLine("Name");

            string[] name = new string[]
            {
                "John","Venkat","Mary","Victor","Betty"
            };
            for (int x = 0; x < name.Length; x++)
            {
                for (int y = x + 1; y < name.Length; y++)
                {
                    if (name[x].CompareTo(name[y]) == 1)
                    {
                        string r = name[x];
                        name[x] = name[y];
                        name[y] = r;
                    }
                }
            }
            for (int x = 0; x < name.Length; x++)
            {
                System.Console.WriteLine(name[x]);
            }




        }
    }
}

