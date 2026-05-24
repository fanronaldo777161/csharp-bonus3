using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace bonustask3
{
    public class Rectangle
    {
        public Point[] points {  get; private set; }
        public Point center;
        public Rectangle(Point[] l)
        {
            if (l == null)
                throw new ArgumentNullException(nameof(l), "Массив точек не должен быть пустым");

            if (l.Length != 4)
                throw new ArgumentException("Для прямоугольника должно быть ровно четыре точки");

            var a = l[0];
            var b = l[1];
            var c = l[2];
            var d = l[3];

            double ab = Point.distance(a, b);
            double bc = Point.distance(b, c);
            double cd = Point.distance(c, d);
            double ad = Point.distance(a, d);

            double ac = Point.distance(a, c); 
            double bd = Point.distance(b, d); 

            double eps = 1e-6;

            if (!(Math.Abs(ab - cd) < eps && Math.Abs(bc - ad) < eps && Math.Abs(ac - bd) < eps))
            {
                throw new ArgumentException("Переданные точки не образуют прямоугольник");
            }
            this.points = new Point[] { a, b, c, d };

            this.center = new Point( (a.x + b.x + c.x + d.x) / 4.0, (a.y + b.y + c.y + d.y) / 4.0 ) ;
        }
        public override string ToString()
        {
            var s = $"Прямоугольник: ";
            foreach (var p in points)
            {
                s += p.ToString() ;
                s += " ";
            }
            return s;
        }
        //ближайшая к 0 0 точка
        public Point NearestPoint()
        { 
            Point c = points[0];
            double minD = (c.x * c.x) + (c.y * c.y);
            for (int i = 1; i < points.Length; i++)
            {
                var p = points[i];
                double distSq = (p.x * p.x) + (p.y * p.y);

                if (distSq < minD)
                {
                    minD = distSq;
                    c = p;
                }
            }

            return c;
        }
        //поворот на а градусов
        public void turn(double a)
        { 
            double a1 = a * Math.PI / 180;
            double cos = Math.Cos(a1);
            double sin = Math.Sin(a1);
            for (int i = 0; i < points.Length; i++)
            {
                double X = points[i].x - center.x;
                double Y = points[i].y - center.y;
                double newX = (X * cos) - (Y * sin);
                double newY = (X * sin) + (Y * cos);
                points[i] = new Point(newX + center.x, newY + center.y);
            }
        }
        //+ к х и у прямоугольника
        public void move(double dx, double dy)
        {
            for (int i = 0; i < points.Length; i++)
            {
                var p = points[i];
                points[i] = new Point(p.x + dx, p.y + dy);
            }

            
            center = new Point(center.x + dx, center.y + dy);
        }
        //площадь
        public double area()
        {
            double w = Point.distance(points[0], points[1]);
            double h = Point.distance(points[1], points[2]);
            return w * h;
        }
        //перимеетр
        public double perimeter()
        {
            double w = Point.distance(points[0], points[1]);
            double h = Point.distance(points[1], points[2]);
            return 2 * (w + h);
        }
        //х и у больше в к раз
        public void powonxy(double kw, double kh)
        {
            for (int i = 0; i < points.Length; i++)
            {
                var p = points[i];
                points[i] = new Point(p.x * kw, p.y * kh);
            }

            center = new Point(center.x * kw, center.y * kh);
        }
    }
}
