namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            string A = System.Console.ReadLine();

            if (A == "Venkat")
            {
                System.Console.Write("Enter your gender: ");
                string B = System.Console.ReadLine();
                if (B == "Mr")
                {
                    System.Console.WriteLine("Good Morning Mr. Venkat.");
                }
                else if (B == "Mrs")
                {
                    System.Console.WriteLine("Error. Please try again.");
                }
            }
            else
            {
                System.Console.WriteLine("Error. Please try again.");
            }
            
        }
    }
}