namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double no;
            System.Console.WriteLine("no  inverse  squareroot  square");
            System.Console.WriteLine("--------------------------------");


            
                for (no = 1; no <= 10; no++)
                {
                    double inverse;
                    inverse = System.Math.Pow(no, -1);
                    double squareroot;
                    squareroot = System.Math.Sqrt(no);
                    double square;
                    square = System.Math.Pow(no, 2);
                    System.Console.WriteLine("{0:0.0} \t {1:0.000} \t {2:0.000} \t {3:0.0}", no, inverse, squareroot, square);
                }
            }
           
        }
    }

