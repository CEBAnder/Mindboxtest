using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Triangle's maximum side
        /// </summary>
        private double _maxSide;

        public List<double> sides = new List<double>();
        
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new Exception("All sides must be positive");
            sides.Add(firstSide);
            sides.Add(secondSide);
            sides.Add(thirdSide);
            _maxSide = sides.Max();
        }

        private bool CheckRightTriangle()
        {
            // If triangle is right it's sides complete Pythagorean theorem
            var sidesList = sides.ToList();
            sidesList.Remove(_maxSide);
            return Math.Pow(_maxSide, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        public override double GetArea()
        {
            // If we have right triangle it's area is half of cathetus multiply
            if (CheckRightTriangle())
            {
                var listCopy = new List<double>(sides);
                listCopy.Remove(_maxSide);
                return (listCopy[0] * listCopy[1]) / 2;
            }
            // else use Heron's formula
            else
            {
                var s = (sides[0] + sides[1] + sides[2]) / 2;
                return Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            }
        }
    }
}
