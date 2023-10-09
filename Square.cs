using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Square : Geometry
    {
        public double Side { get; set; }
        public Square() 
        {
            Side = 19;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
