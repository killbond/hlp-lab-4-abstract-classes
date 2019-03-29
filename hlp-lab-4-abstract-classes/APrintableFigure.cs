using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hlp_lab_4_abstract_classes
{
    abstract class APrintableFigure
    {
        public virtual void Print()
        {
            System.Console.Out.WriteLine("{0}: \tp={1:0.00} \tS={2:0.00}", this.GetType().Name, this.getPerimeter(), this.getSquare());
        }

        public abstract double getPerimeter();

        public abstract double getSquare();
    }
}
