namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {

            int X;
            double Y;


            System.Console.WriteLine("X\tY");
            for (X = -5; X <= 5; X++)
            {

                double A = System.Math.Pow(X, 2);
                Y = 2 * A - 4 * X + 3;
                System.Console.WriteLine("{0: 0.0}\t{1: 0.0}", X, Y);
            }


        }
    }
}


