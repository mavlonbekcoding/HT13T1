using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shakllar
{
    public class Triangle
{
    public Triangle(double x, double y,double z)
    {
        if (!IsValidArgs(x, y, z))
            throw new ArgumentException("Uchberchak shartlarini qanoatlatirmaydi");
        A = x;
        B = y;
        C = z;
    }
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double Perimetr { get => A + B + C;}

    public double Area
    {
        get
        {
            var p = Perimetr / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    private bool IsValidArgs(double a, double b, double c)
    {
        return ((a + b > c) & (a + b > c) & (a + b > c));
    }
}
}
