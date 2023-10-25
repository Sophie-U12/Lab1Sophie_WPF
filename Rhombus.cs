using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Sophie_WPF
{
    public class Rhombus
    {
        private double sideLength;
        public double SideLength
        {
            get
            {
                return sideLength;
            }
            set
            {
                if (sideLength <= 0)
                {
                    throw new ArgumentException("Error! Length must be > than 0!");
                }
                sideLength = value;
            }
        }

        public Rhombus()
        {
            sideLength = 1;
        }

        public Rhombus(double sideLength)
        {
            if(sideLength <= 0)
            {
                throw new ArgumentException("Error! Length must be > than 0!");
            }
            this.sideLength = sideLength;
        }

        public Rhombus(Rhombus rhombus)
        {
            this.sideLength = rhombus.sideLength;
        }

        public double CalculateArea()
        {
            return Math.Pow(sideLength, 2) * Math.Sin(Math.PI / 3);
        }

    }
}
