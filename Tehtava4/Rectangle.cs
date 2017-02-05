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
    class Rectangle : Shape
    {
        double Height { get; set; }
        double Width { get; set; }

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override double Circumference()
        {
            return 2 * (Height + Width);
        }

        public override string ToString()
        {
            return "Rectangle Width = " + Width + " Height = " + Height + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
}
