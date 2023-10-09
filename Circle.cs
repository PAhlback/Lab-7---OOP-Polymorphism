using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public Circle() 
        {
            Radius = 15;
        }

        public override double Area()
        {
            return (Radius * Radius) * Math.PI;
        }
    }
}
