/*
 * Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * (Radius * Radius);
        }
        public override double Circumference()
        {
            return 2 * 3.14 * Radius;
        }
        public override string ToString()
        {
            return "Circle Radius = " + Radius + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
}
