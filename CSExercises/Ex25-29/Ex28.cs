namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter a number: ");
            int A = System.Convert.ToInt32(System.Console.ReadLine());

            


            if (A % A == 0 && A % 1 == 0)
            {
                System.Console.WriteLine("Prime");
            }
            else
                System.Console.WriteLine("Not Prime");


        }
    }
}

