using System;

namespace _04._03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (LineLenght(x1, y1, x2, y2) >= LineLenght(x3, y3, x4, y4))
            {
                CloserPoint(x1, y1, x2, y2);
            }
            else
            {
                CloserPoint(x3, y3, x4, y4);
            }
        }

        static void CloserPoint(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

            }
        }
        static double LineLenght(double x1, double y1, double x2, double y2)
        {
            int firstPointQuadrant = CheckQuadrant(x1, y1);
            int secondPointQuadrant = CheckQuadrant(x2, y2);
            double x = 0.0;
            double y = 0.0;

            if (firstPointQuadrant == secondPointQuadrant)
            {
                x = Math.Abs(x1) - Math.Abs(x2);
                y = Math.Abs(y1) - Math.Abs(y2);
            }
            else if (((firstPointQuadrant == 1 || firstPointQuadrant == 2) && (secondPointQuadrant == 2 || secondPointQuadrant == 1))
                   || ((firstPointQuadrant == 3 || firstPointQuadrant == 4) && (secondPointQuadrant == 4 || secondPointQuadrant == 3)))
            {
                x = Math.Abs(x1) + Math.Abs(x2);
                y = Math.Abs(y1) - Math.Abs(y2);
            }
            else if (((firstPointQuadrant == 2 || firstPointQuadrant == 3) && (secondPointQuadrant == 3 || secondPointQuadrant == 2))
                   || ((firstPointQuadrant == 1 || firstPointQuadrant == 4) && (secondPointQuadrant == 4 || secondPointQuadrant == 1)))
            {
                x = Math.Abs(x1) - Math.Abs(x2);
                y = Math.Abs(y1) + Math.Abs(y2);
            }
            else
            {
                x = Math.Abs(x1) + Math.Abs(x2);
                y = Math.Abs(y1) + Math.Abs(y2);
            }
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        }

        static int CheckQuadrant(double x, double y)
        {
            if (x >= 0 && y >= 0)
            {
                return 1;
            }
            else if (x < 0 && y >= 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
