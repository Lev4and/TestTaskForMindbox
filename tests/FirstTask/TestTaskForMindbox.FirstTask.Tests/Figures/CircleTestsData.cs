namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class CircleTestsData
    {
        public class InvalidRadiusValues : TheoryData<double>
        {
            public InvalidRadiusValues()
            {
                Add(double.NegativeInfinity);
                Add(double.MinValue);
                Add(-1.0d);
                Add(0.0d);
            }
        }

        public class ValidRadiusValues : TheoryData<double>
        {
            public ValidRadiusValues()
            {
                Add(0.1d);
                Add(1.0d);
                Add(double.MaxValue);
                Add(double.PositiveInfinity);
            }
        }

        public class RadiusWithExpectedAreaValues : TheoryData<double, double>
        {
            public RadiusWithExpectedAreaValues()
            {
                Add(1.0d, Math.PI);
                Add(2.0d, 12.566370614359172);
            }
        }
    }
}
