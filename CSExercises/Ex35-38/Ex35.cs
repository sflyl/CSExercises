namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter a phrase: ");
            string S = System.Console.ReadLine();
            int q;
            
          
            int counta= 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;
            


            for (q = 0; q < S.Length;q++)
            {


                if (S.Substring(q, 1).Equals("a"))
                {
                    counta++;

                }
                else if (S.Substring(q, 1).Equals("e"))
                {
                    counte++;
                }
                else if (S.Substring(q, 1).Equals("i"))
                                    {
                                        counti++;
                }
                else if (S.Substring(q, 1).Equals("o"))
                {
                    counto++;

                }
                else if (S.Substring(q, 1).Equals("u"))
                {
                    countu++;

                }
                else
                    System.Console.WriteLine("");
                }
                        System.Console.WriteLine("Number of a: " + counta);

                        System.Console.WriteLine("Number of e: " + counte);

                        System.Console.WriteLine("Number of i: " + counti);

                        System.Console.WriteLine("Number of o: " + counto);

                        System.Console.WriteLine("Number of u: " + countu);//entered at the end because system will go through the q one by each character through the whole sentence and may not cover alphabet a first. ps: Starts with o and u first.

            }

            


        }
    }

