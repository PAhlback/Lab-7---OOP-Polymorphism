using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Parallelogram : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Parallelogram() 
        {
            Length = 9;
            Width = 7;
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
}
