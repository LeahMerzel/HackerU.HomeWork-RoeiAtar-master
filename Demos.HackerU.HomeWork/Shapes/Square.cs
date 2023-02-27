using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Shapes
{
    public class Square : Shape
    {
        private int _side;



        public int Side { get => _side; set => _side = value; }

        public Square(int side, Colors color) : base(color)
        {
            _side = side;
        }

        public override void CalculateArea()
        {
            Area = (Math.Pow(Side, 2));
        }

        public override void CalculatePerimeter()
        {
            Perimeter = Side * 4;
        }



        public override string ToString()
        {
            return $"Square:\nSide :{Side}\nArea :{Area}\nPerimeter :{Perimeter}\nColor :{Color}";
        }
    }
}
