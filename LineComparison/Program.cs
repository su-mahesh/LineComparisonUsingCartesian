using System;

namespace LineComparison
{
    
    class LineComparison
    {
        public float CalculateLineLength(Line line) {
            float LineLength = (float)Math.Sqrt(Math.Pow((line.GetEndPointXCordinate() - line.GetStartPointXCordinate()), 2) + Math.Pow((line.GetEndPointYCordinate() - line.GetStartPointYCordinate()), 2));
            Console.WriteLine("Line length: "+ LineLength +"\n");
            line.SetLength(LineLength);
            return LineLength;
        }
        private void CheckEqualLines(Line FirstLine, Line SecondLine) {
            Console.WriteLine("First Line:");
            float LineLenght1 = CalculateLineLength(FirstLine);
            Console.WriteLine("Second Line:");
            float LineLenght2 = CalculateLineLength(SecondLine);
            
            if (FirstLine.Equals(SecondLine))
                Console.WriteLine("lines are equals\n");
            else
                Console.WriteLine("lines are not equal\n");
        }
        private void CompareLines(Line FirstLine, Line SecondLine)
        {
            Console.WriteLine("First Line:");
            float LineLenght1 = CalculateLineLength(FirstLine);
            Console.WriteLine("Second Line:");
            float LineLenght2 = CalculateLineLength(SecondLine);

            if (FirstLine.CompareTo(SecondLine) == 0)
                Console.WriteLine("both lines are equal\n");
            else if (LineLenght1.CompareTo(LineLenght2) > 0)
                Console.WriteLine("first line is bigger than second line\n");
            else
                Console.WriteLine("first line is smaller than second line\n");
        }
        static void Main(string[] args)
        {
            LineComparison lineComparison = new LineComparison();
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("First line");
            Line FirstLine = new Line();
            lineComparison.CalculateLineLength(FirstLine);

            Console.WriteLine("Second line");
            Line SecondLine = new Line();
            lineComparison.CalculateLineLength(SecondLine);

            lineComparison.CheckEqualLines(FirstLine, SecondLine);
            lineComparison.CompareLines(FirstLine, SecondLine);
        }

        
    }
}
