using System;

namespace Mindbox
{
    public class Circle : Figure
    {
        private double _radius;

        public double radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new Exception("Radius must be a positive number");
                _radius = value;
            }
        }

        public Circle(double initRadius)
        {
            radius = initRadius;
        }
        
        override public double GetArea()
        {
            // S = pi*(r^2)
            return Math.PI * radius * radius;
        }
    }
}
