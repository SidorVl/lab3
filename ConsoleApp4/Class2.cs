using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Point
    {
        int x;
        int y;
        string name;
        public string Name { get => name; }
        public int X { get => x; }
        public int Y { get => y; }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
    public class Figure
    {
        List<Point> points = new List<Point>();
        public Figure(Point point1, Point point2, Point point3)
        {
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
        }
        public Figure(Point point1, Point point2, Point point3, Point point4) : this(point1, point2, point3)
        {
            points.Add(point4);
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) : this(point1, point2, point3, point4)
        {
            points.Add(point5);
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        public double PerimetrCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                sum += LengthSide(points[i], points[(i + 1) % points.Count]);
            }
            return sum;
        }
        public string GetName()
        {
            switch (points.Count)
            {
                case 3: return "Triangle";
                case 4: return "Rectangle";
                case 5: return "5";
                default:
                    return "Don`t know";
            }
        }
    }
}