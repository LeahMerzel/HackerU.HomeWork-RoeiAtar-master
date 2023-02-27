using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Shapes
{
    public class Rectangle : Shape
    {
        private int _height;
        private int _width;

        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        public Rectangle(int height, int width, Colors color) : base(color)
        {
            _height = height;
            _width = width;
        }

        public override void CalculateArea()
        {
            Area = Width * Height;
        }

        public override void CalculatePerimeter()
        {
            Perimeter = Height * 2 + Width * 2;
        }


        public override string ToString()
        {
            return $"Rectangle:\nWidth :{Width}\nHeight :{Height}\nArea :{Area}\nPerimeter :{Perimeter}\nColor :{Color}";
        }
    }
}
