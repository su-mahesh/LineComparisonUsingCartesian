using System;

namespace LineComparison
{
    class Line
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;
        private float Length;

        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public int GetX1()
        {
            return x1;
        }
        public int GetX2()
        {
            return x2;
        }
        public int GetY1()
        {
            return y1;
        }
        public int GetY2()
        {
            return y2;
        }
        public void SetLength(float Length) {
            this.Length = Length;
        }
        public override bool Equals(Object line) {
            return this.Length.Equals(((Line)line).Length);
        }

        public int CompareTo(Line line)
        {       
            return this.Length.CompareTo(line.Length);
        }

    }  
    class LineComparison
    {
        public float CalculateLineLength(Line line) {
            float LineLength = (float)Math.Sqrt(Math.Pow((line.GetX2() - line.GetX1()), 2) + Math.Pow((line.GetY1() - line.GetY2()), 2));
            Console.WriteLine("Line length: "+ LineLength +"\n");
            line.SetLength(LineLength);
            return LineLength;
        }
        private void CheckEqualLines(Line line1, Line line2) {
            Console.WriteLine("Line 1:");
            float LineLenght1 = CalculateLineLength(line1);
            Console.WriteLine("Line 2");
            float LineLenght2 = CalculateLineLength(line2);
            
            if (line1.Equals(line2))
                Console.WriteLine("lines are equals\n");
            else
                Console.WriteLine("lines are not equal\n");
        }
        private void CompareLines(Line line1, Line line2)
        {
            Console.WriteLine("Line 1:");
            float LineLenght1 = CalculateLineLength(line1);
            Console.WriteLine("Line 2");
            float LineLenght2 = CalculateLineLength(line2);

            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("both lines are equal\n");
            else if (LineLenght1.CompareTo(LineLenght2) > 0)
                Console.WriteLine("first line is bigger than second\n");
            else
                Console.WriteLine("first line is smaller than second\n");
        }
        static void Main(string[] args)
        {
            LineComparison lineComparison = new LineComparison();
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line1 = new Line(4, 0, 1, 1);
            Line line2 = new Line(1, 1, 0, 10);
            lineComparison.CalculateLineLength(line1);
            lineComparison.CalculateLineLength(line2);
            lineComparison.CheckEqualLines(line1, line2);
            lineComparison.CompareLines(line1, line2);
        }      
    }
}
