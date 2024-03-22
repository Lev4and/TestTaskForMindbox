using TestTaskForMindbox.FirstTask.Exceptions;

namespace TestTaskForMindbox.FirstTask.Figures
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new RadiusCircleValidationException();

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return "Circle";
        }
    }
}
