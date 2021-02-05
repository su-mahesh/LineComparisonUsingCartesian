using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Line
    {
        private int StartPointXCordinate;
        private int StartPointYCordinate;
        private int EndPointXCordinate;
        private int EndPointYCordinate;
        private float Length;

        public Line()
        {
            Console.WriteLine("Enter line starting point x and y cordinates(x y):");
            String[] Cordinates = Console.ReadLine().Split(" ");
            StartPointXCordinate = Convert.ToInt32(Cordinates[0]);
            StartPointYCordinate = Convert.ToInt32(Cordinates[1]);

            Console.WriteLine("Enter line end point x and y cordinates(x y):");
            Cordinates = Console.ReadLine().Split(" ");
            EndPointXCordinate = Convert.ToInt32(Cordinates[0]);
            EndPointYCordinate = Convert.ToInt32(Cordinates[1]);
        }

        public int GetStartPointXCordinate()
        {
            return StartPointXCordinate;
        }
        public int GetStartPointYCordinate()
        {
            return StartPointYCordinate;
        }
        public int GetEndPointXCordinate()
        {
            return EndPointXCordinate;
        }
        public int GetEndPointYCordinate()
        {
            return EndPointYCordinate;
        }

        public void SetLength(float Length)
        {
            this.Length = Length;
        }
        public override bool Equals(Object line)
        {
            return this.Length.Equals(((Line)line).Length);
        }

        public int CompareTo(Line line)
        {
            return this.Length.CompareTo(line.Length);
        }

    }
}
