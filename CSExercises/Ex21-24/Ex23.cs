using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {

            int i = 0;
            int A = 0;

            Random r = new Random();
            int secretnumber = r.Next(0, 10);


            for (i = 1; secretnumber != A; i++)
            {
                System.Console.Write("Please enter a number: ");
                A = System.Convert.ToInt32(System.Console.ReadLine());


                if (secretnumber == A)
                {
                    if (i <= 2)
                    {
                        System.Console.Write("You are a wizard!" + "Congratulations. You have had" + i + "attempts.");
                        break;
                    }
                    else if (i >= 3 && i <= 5)
                    {
                        System.Console.Write("You are a good guess!" + "Congratulations. You have had" + i + "attempts.");
                        break;
                    }
                    else if (i >=6)
                    {
                        System.Console.Write("You are lousy.");
                        break;
                    }
                    
                }
                else
                {
                    System.Console.Write("try again.");
                }
            }
        }
    }
}
           
            
            
        
    

