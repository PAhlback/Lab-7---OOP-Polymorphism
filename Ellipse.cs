using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Ellipse : Geometry
    {
        public double MajorRadius { get; set; }
        public double MinorRadius { get; set; }
        public Ellipse()
        {
            MajorRadius = 8; 
            MinorRadius = 6;
        }
        public override double Area()
        {
            return MajorRadius * MinorRadius * Math.PI;
        }
    }
}
