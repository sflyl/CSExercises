namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your sentence: ");
            string X = System.Console.ReadLine();
            
            string y = "";

            for (int i = 0; i <= X.Length -1; i++)
            {

                y = X[i] + y;
            }  
                
                
             if (y.Equals(X))
                {
                    System.Console.WriteLine("Palindrome.");
                }
                else
                {
                    System.Console.WriteLine("Not Palindrome");
                }
                
            }
        }
    }

