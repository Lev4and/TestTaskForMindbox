namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class TriangleTestsData
    {
        public class InvalidSidesLengthsValues : TheoryData<double, double, double>
        {
            public InvalidSidesLengthsValues()
            {
                Add(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
                Add(double.MinValue, double.MinValue, double.MinValue);
                Add(-1.0d, -1.0d, -1.0d);
                Add(0.0d, 0.0d, 0.0d);
                Add(1.0d, 0.0d, 2.0d);
                Add(1.0d, 2.0d, 0.0d);
            }
        }

        public class ImpossibleCombineSidesLengthsValues : TheoryData<double, double, double>
        {
            public ImpossibleCombineSidesLengthsValues()
            {
                Add(3.0d, 2.0d, 1.0d);
                Add(1.0d, 3.0d, 2.0d);
                Add(1.0d, 2.0d, 3.0d);
            }
        }

        public class ValidSidesLengthsValues : TheoryData<double, double, double>
        {
            public ValidSidesLengthsValues()
            {
                Add(0.1d, 0.1d, 0.1d);
                Add(1.0d, 1.0d, 1.0d);
                Add(2.0d, 2.0d, 1.0d);
                Add(2.0d, 2.0d, 2.0d);
                Add(double.MaxValue, double.MaxValue, double.MaxValue);
            }
        }

        public class SidesLengthsWithExpectedAreaValues : TheoryData<double, double, double, double>
        {
            public SidesLengthsWithExpectedAreaValues()
            {
                Add(2.0d, 2.0d, 2.0d, Math.Sqrt(3));
                Add(10.0d, 10.0d, 10.0d, Math.Sqrt(1875));
            }
        }

        public class SidesLengthsWithExpectedIsRectangularFlagValues : TheoryData<double, double, double, bool>
        {
            public SidesLengthsWithExpectedIsRectangularFlagValues()
            {
                Add(2.0d, 2.0d, 2.0d, false);
                Add(10.0d, 10.0d, 10.0d, false);
                Add(3.0d, 4.0d, 5.0d, true);
            }
        }
    }
}
