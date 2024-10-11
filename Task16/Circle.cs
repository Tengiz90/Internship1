using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    internal class Circle
    {
        private const double Pi = Math.PI;
        private double R;

        public double GetPi()
        {
            return Pi;
        }

        public double GetRadius()
        {
            return R;
        }
        public void SetRadius(double R)
        {
            this.R = R;
        }

        public double GetArea()
        {
            return Pi * this.R * this.R;

        }
        public double GetPerimeter()
        {
            return 2 * Pi * this.R;
        }
    }
}
