using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demos.HackerU.HomeWork.Shapes
{
    public class Circle : Shape
    {
        private int _radius;
        public int Radius { get => _radius; set => _radius = value; }


        public Circle(int radius, Colors color) : base(color)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            Area = Math.PI * (Math.Pow(Radius, 2));
        }

        public override void CalculatePerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
        }


        public override string ToString()
        {
            return $"Circle:\nRadius :{Radius}\nArea :{Area}\nPerimeter :{Perimeter}\nColor :{Color}";
        }
    }
}
