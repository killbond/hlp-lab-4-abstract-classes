using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_4_abstract_classes
{
    class Circle : APrintableFigure
    {
        private Point center;

        private double r;

        public Circle(Point center, double radius)
        {
            this.center = center;
            this.r = radius;
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * r;
        }

        public override double getSquare()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override void Print()
        {
            System.Console.Out.WriteLine(
                "{0}: \tp={1:0.00} \tS={2:0.00} \tr={3:0.00}", 
                this.GetType().Name, 
                this.getPerimeter(), 
                this.getSquare(),
                this.r
           );
        }
    }
}
