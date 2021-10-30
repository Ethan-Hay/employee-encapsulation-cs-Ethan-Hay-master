using System;

namespace soft_arch_encapsulation.part2.demo.poor
{
    public class Rectangle
    {
        private double _length;

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Length can't be less than zero!");
                _length = value;
            }
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Width can't be less than zero!");
                _width = value;
            }
        }

        /*
        There are so many things wrongs with this method.
        It's violating command/query separation.
        It's both a setter (command) and a getter (query)!
         */
        public double GetArea(double length, double width)
        {
            Length = length;
            Width = width;
            return Length * Width;
        }
    }
}