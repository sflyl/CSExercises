namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {//34 part a
            System.Console.WriteLine("Student" + " " + "Total Score");
            int[,] score = new int[,]
            {
                {56,84,68,29},
                {94,73,31,89},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}

            };
            int [] studentnumber = new int [12] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            
          int i = 0;
            int j=0;
            
                
            for (i=0; i<12;i++)
            {               
                System.Console.Write(studentnumber[i] + "          ");
                int classSum = 0;
                    for (j=0;j<4;j++)
                    {
                        classSum = classSum + score[i, j];
                        
                    }
                    System.Console.WriteLine(classSum);

            } System.Console.WriteLine("        ");
            //part b

            System.Console.WriteLine("Avg1" + "   " + "Avg2" + "   " + "Avg3" + "   " + "Avg4");


            int overtotal = 0;
            int overallavg = 0;
           
            for (j=0; j<4; j++)
            {
                int subjecttotal = 0;
                for (i=0;i<12;i++)
                {
                    subjecttotal = subjecttotal + score[i, j];

                } int subjectavg = subjecttotal / 12;
                System.Console.Write(subjectavg + "    ");
                

                overtotal = overtotal + subjecttotal;
                overallavg = overtotal / 48;

            } System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("overallavg");
            System.Console.WriteLine(overallavg);



           
            



        }
    }
}
