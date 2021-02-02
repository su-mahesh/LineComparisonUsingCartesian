using System;

namespace LineComparison
{
    class LineComparison
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;
                
        public void GetEndPoints() {
            InputPoint:
            Console.WriteLine("Enter line points x1 and y1 points(x1 y1): ");
            try
            {
                String[] input = Console.ReadLine().Split(" ");
                x1 = Convert.ToInt32(input[0]);
                y1 = Convert.ToInt32(input[1]);

                Console.WriteLine("Enter line points x2 and y2 points(x2 y2): ");
                input = Console.ReadLine().Split(" ");
                x2 = Convert.ToInt32(input[0]);
                y2 = Convert.ToInt32(input[1]);
            }
            catch (Exception) {
                Console.WriteLine("wrong input");
                goto InputPoint;
            }
        }

        public float CalculateLength() {
          
            float LineLength = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Line length: "+LineLength);
            return LineLength;
        }
        private void CheckEqualLines() {
            GetEndPoints();
            float LineLenght1 = CalculateLength();
            GetEndPoints();
            float LineLenght2 = CalculateLength();

            if (LineLenght1.Equals(LineLenght2))
                Console.WriteLine("lines are equals");
            else
                Console.WriteLine("lines are not equal");
        }
        private void CompareLines()
        {
            Console.WriteLine("\nLine 1");
            GetEndPoints();
            float LineLenght1 = CalculateLength();
            Console.WriteLine("\nLine 2");
            GetEndPoints();
            float LineLenght2 = CalculateLength();

            if (LineLenght1.CompareTo(LineLenght2) == 0)
                Console.WriteLine("both lines are equal");
            else if (LineLenght1.CompareTo(LineLenght2) > 0)
                Console.WriteLine("first line is bigger than second");
            else
                Console.WriteLine("first line is smaller than second");
        }
        static void Main(string[] args)
        {
            LineComparison lineComparison = new LineComparison();
            Console.WriteLine("Welcome to Line Comparison Computation Program");
        
            lineComparison.GetEndPoints();
            lineComparison.CalculateLength();
            lineComparison.CheckEqualLines();
            lineComparison.CompareLines();
        }      
    }
}
