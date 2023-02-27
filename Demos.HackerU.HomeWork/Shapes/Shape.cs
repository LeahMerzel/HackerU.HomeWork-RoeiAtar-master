using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Nest.JoinField;

namespace Demos.HackerU.HomeWork.Shapes
{
    public abstract class Shape
    {
        private double _area;
        private Colors _color;
        private double _perimeter;

        public Shape()
        {
            _area = 0;
            Color = Colors.White;
            Perimeter = 0;

        }

        public Shape(Colors color)
        {

            Color = color;


        }

        public double Area
        {
            get { return _area; }
            set { _area = value; CalculateArea(); }
        }


        public Colors Color { get => _color; set => _color = value; }
        public double Perimeter
        {
            get { return _perimeter; }
            set { _perimeter = value; CalculatePerimeter(); }
        }
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();



    }

    public enum Colors
    {
        Black,
        White,
        Blue,
        Green,
        Yellow,
        Red
    }
}
