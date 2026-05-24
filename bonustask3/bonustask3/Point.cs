using System;
using System.Collections.Generic;
using System.Text;

namespace bonustask3
{
    public class Point
    {
        public double x { get; private set; }
        public double y { get; private set; }
        public Point (double x,double y)
        {
         this.x = x;
         this.y = y;
        }
        //расстояние между точками
        public static double distance (Point p1, Point p2)
        {
            return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p1.y - p2.y)* (p1.y - p2.y));
        }
        public override string ToString()
        {
            return $"(x,y): {x},{y}";
        }
        
    }
}
