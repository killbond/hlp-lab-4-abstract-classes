using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_4_abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<APrintableFigure> samples = new List<APrintableFigure>();

            samples.Add(new Rectangle(new Point(.9, .2), new Point(4.3, 7.9)));
            samples.Add(new Triangle(new Point(0, 0), new Point(3.2, 0), new Point(1.6, 3)));
            samples.Add(new Circle(new Point(0, 0), 3.7));

            foreach (APrintableFigure sample in samples)
            {
                Print(sample);
            }

            System.Console.In.Read();
        }

        static void Print(APrintableFigure item)
        {
            item.Print();
        }
    }
}
