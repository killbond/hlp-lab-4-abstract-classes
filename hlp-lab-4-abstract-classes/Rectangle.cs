using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_4_abstract_classes
{
    class Rectangle : APrintableFigure
    {
        private double a;

        private double b;

        public Rectangle(Point a, Point b)
        {
            this.a = Math.Abs(a.x - b.x);
            this.b = Math.Abs(a.y - b.y);
        }

        public override double getPerimeter()
        {
            return (a + b) * 2;
        }

        public override double getSquare()
        {
            return a * b;
        }
    }
}
