namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            
            string a = "institute of systems science";
                        string[] s = a.Split(' ');
                        string b = "";
                        
                        
           
            for (int i = 0; i < s.Length; i++)
            {   
                if (s[i].Length > 1)
                {
                    s[i] = s[i].ToUpper().Substring(0, 1) + s[i].Substring(1, s[i].Length - 1);
                    b = b + s[i] + " ";
                    
                }

            } System.Console.WriteLine(b);
        }
    }
}
