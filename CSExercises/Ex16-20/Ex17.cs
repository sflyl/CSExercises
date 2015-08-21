namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter your name: ");
            string A = System.Console.ReadLine();

            if (A == "Sam")
            {
                System.Console.Write("Please enter your gender: ");
                string B = System.Console.ReadLine();
                if (B == "M")
                {
                    System.Console.Write("Please enter your age: ");
                    double C = System.Convert.ToDouble(System.Console.ReadLine());
                    if (C == 45)
                    {
                        System.Console.Write("Good Morning Uncle Sam.");
                    }
                    else if (C >= 40 && C != 45)
                    {
                        System.Console.Write("Good Morning Uncle " + A);
                    }
                    else if (C < 40)
                    {
                        System.Console.Write("Good Morning Mr " + A);
                    }
                }
                else if (B == "F")
                {
                    System.Console.Write("Please enter  your age: ");
                    int D = System.Convert.ToInt32(System.Console.ReadLine());
                    if (D >= 40)
                    {
                        System.Console.Write("Good morning Aunty" + A);
                    }
                    else if (D < 40)
                    {
                        System.Console.Write("Good Morning Ms" + A);
                    }
                }
            }
            else
            {
                System.Console.Write("Please enter your gender: ");
                
            }
        }
    }
}