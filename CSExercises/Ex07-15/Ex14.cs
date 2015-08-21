namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Please enter the side a: ");
            double y = System.Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("Please enter the side b: ");
            double x = System.Convert.ToDouble (System.Console.ReadLine());

            System.Console.Write("Please enter the side c: ");
            double z = System.Convert.ToDouble(System.Console.ReadLine());

            double f = (x + y + z)/2;
            double k = f*(f-y)*(f-x)*(f-z);
            double area = System.Math.Sqrt(k);
            System.Console.WriteLine("Your area is " + area);




        }
    }
}