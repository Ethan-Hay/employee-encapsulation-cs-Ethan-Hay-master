using System;

namespace soft_arch_encapsulation.part2.demo.good
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

        // Expression-bodied property functions as a getter. It is read-only.
        public double Area => _width * _length;
    }
}