namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter your mark: ");
            double X = System.Convert.ToDouble(System.Console.ReadLine());
            if (X>=80 && X <=100)
            {
                System.Console.Write("Your grade is A.");
            }
            else if (X >=60 && X<=79)
            {
                System.Console.Write("Your grade is B.");
            }
            else if ( X >=40 && X<= 59)
            {
                System.Console.Write("Your grade is C.");
            }
            else if (X >= 0 && X <=39)
            {
                System.Console.Write("Your grade is F.");
            }
            else if (X < 0)
            {
                System.Console.Write("**Error**");
            }
            else if (X > 100)
            {
                System.Console.Write("**Error**");
            }
            

        }
    }
}