using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Rectangle
{
    class Rectangle
    {
        public double x { get; set; }
        public double y { get; set; }

        public double Calc(double x1, double y1) {
            return x1 * y1;
        }
    }
}
