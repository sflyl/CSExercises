namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter quantity for TV: ");
            double A = System.Convert.ToDouble(System.Console.ReadLine());
            double X = 900 * A;
            System.Console.Write("Please enter quantity for DVD: ");
            double B = System.Convert.ToDouble(System.Console.ReadLine());
            double Y = 500 * B;
            System.Console.Write("Please enter quantity for MP3: ");
            double C = System.Convert.ToDouble(System.Console.ReadLine());
            double Z = 700 * C;
            
            double D = X + Y + Z;

            if (A > 0 && B > 0 && C > 0) 
            {
                System.Console.Write("Total Payment is" + D);
                
            }
            else if (A > 0 && B >0 && C ==0)
            {
                if (D >5000 && D<10000)
                {
                    double U = 0.9*D;
                    System.Console.Write("Total Payment is " + U);
                }
                else if ( D> 10000)
                {
                    double I = 0.85 * D;
                    System.Console.Write("Total Payment is " + I);
                }
            }
            else
            {
                System.Console.Write("Error");
            }


        }
    }
}