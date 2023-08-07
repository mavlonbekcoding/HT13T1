using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtBurchak.Rectange
{
    public class Rectangle
        {

            public Rectangle(Point a, Point b, Point c, Point d)
            {
                AB = a;
                BC = b;
                CD = c;
                DA = d;
            }

            public Point AB { get; set; }
            public Point BC { get; set; }
            public Point CD { get; set; }
            public Point DA { get; set; }

            public double Area { get=>
                Math.Sqrt(Math.Pow(CD.X,2)- Math.Pow(AB.X, 2)+Math.Pow(CD.Y,2) - Math.Pow(AB.Y,2));
                }
        }

}
