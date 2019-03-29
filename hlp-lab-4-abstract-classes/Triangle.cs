using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_4_abstract_classes
{
    class Triangle : APrintableFigure
    {
        private double a;

        private double b;

        private double c;

        public Triangle(Point a, Point b, Point c)
        {
            this.a = a.GetDistance(b);
            this.b = b.GetDistance(c);
            this.c = c.GetDistance(a);
        }

        public override double getPerimeter()
        {
            return a + b + c;
        }

        public override double getSquare()
        {
            double p = this.getPerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
