using System;
using System.Collections.Generic;
using System.Text;

namespace bonustask3
{
    internal class RectangleSimulator
    {
        public List<Rectangle> getList()
        {
            return rec;
        }
        private List<Rectangle> rec = new List<Rectangle>();
        public RectangleSimulator() { }
        //добавить пр
        public void addRectangle(Rectangle a)
        {
            rec.Add(a); 
        }
        //удалить пр
        public void removeRectangle(int a)
        {
            rec.RemoveAt(a);
        }
        //вывод
        public void Printall()
        {
            var s = "1 ";
            foreach(Rectangle r in rec)
            {
                s += r.ToString();
                s += "\n";
            }
            Console.WriteLine(s);
        }
        //ближайший к 0 0 пр
        public Rectangle NearestRecnangle()
        {
            if (rec.Count == 0) return null;

            Rectangle f = rec[0];
            Point p0 = f.NearestPoint();
            double maxD = (p0.x * p0.x) + (p0.y * p0.y);

            for (int i = 1; i < rec.Count; i++)
            {
                Rectangle c = rec[i];
                Point p = c.NearestPoint(); 
                double distSq = (p.x * p.x) + (p.y * p.y); 
                if (distSq > maxD)
                {
                    maxD = distSq;
                    f = c;
                }
            }

            return f;
        }
        //поворот на в
       public void turnrecon(int i,double a)
        {
             rec[i].turn(a);
            
        }
        // перемещение на х 
        public void moverecon(int i, double dx, double dy)
        {
            rec[i].move(dx, dy);
        }

        // ч и у больше в к раз
        public void powonxyrecon(int i, double kw, double kh)
        {
            rec[i].powonxy(kw, kh);
        }
        //фильтр по предикату
        public Rectangle[] filter(Predicate<Rectangle> pr)
        {
            var ls = new List<Rectangle>();

            foreach (var r in rec)
            {
                if (pr(r))
                {
                    ls.Add(r);
                }
            }

            return ls.ToArray();
        }
        
    }
}
