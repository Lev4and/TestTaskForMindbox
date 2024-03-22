using TestTaskForMindbox.FirstTask.Exceptions;

namespace TestTaskForMindbox.FirstTask.Figures
{
    public class Triangle : Figure
    {
        private readonly double _firstSideLength;
        private readonly double _secondSideLength;
        private readonly double _thirdSideLength;

        public Triangle(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            if (firstSideLength <= 0 || secondSideLength <= 0 || thirdSideLength <= 0)
            {
                throw new SideLengthTriangleValidationException();
            }

            if (thirdSideLength + secondSideLength <= firstSideLength || firstSideLength + thirdSideLength <= secondSideLength
                || firstSideLength + secondSideLength <= thirdSideLength)
            {
                throw new NotExistTriangleValidationException();
            }

            _firstSideLength = firstSideLength;
            _secondSideLength = secondSideLength;
            _thirdSideLength = thirdSideLength;
        }

        public override double CalculateArea()
        {
            var semiperimeter = CalculateSemiperimeter();

            return Math.Sqrt(semiperimeter * (semiperimeter - _firstSideLength) * (semiperimeter - _secondSideLength)
                * (semiperimeter - _thirdSideLength));
        }

        public bool ValidateOnIsRectangular()
        {
            var hypotenuseLength = GetHypotenuseLength();
            var cathetersLengths = GetCathetersLengths();

            return cathetersLengths.Select(catheterLength => Math.Pow(catheterLength, 2)).Sum()
                == Math.Pow(hypotenuseLength, 2);
        }

        private double CalculateSemiperimeter()
        {
            return GetSidesLengths().Sum() / 2.0d;
        }

        private double GetHypotenuseLength()
        {
            return GetSidesLengths().Max();
        }

        private double[] GetCathetersLengths()
        {
            return GetSidesLengths().Order().Take(2).ToArray();
        }

        private double[] GetSidesLengths()
        {
            return [_firstSideLength, _secondSideLength, _thirdSideLength];
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
