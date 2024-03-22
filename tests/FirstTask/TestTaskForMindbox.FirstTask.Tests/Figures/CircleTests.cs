using TestTaskForMindbox.FirstTask.Exceptions;
using TestTaskForMindbox.FirstTask.Figures;

namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class CircleTests
    {
        [Theory]
        [ClassData(typeof(CircleTestsData.InvalidRadiusValues))]
        public void Initialization_WithInvalidRadiusParam_ThrowException(double radius)
        {
            var initialization = new Action(() => new Circle(radius));

            Assert.Throws<RadiusCircleValidationException>(initialization);
        }

        [Theory]
        [ClassData(typeof(CircleTestsData.ValidRadiusValues))]
        public void Initialization_WithValidRadiusParam_CreateInstance(double radius)
        {
            var instance = new Circle(radius);

            Assert.NotNull(instance);
        }

        [Theory]
        [ClassData(typeof(CircleTestsData.RadiusWithExpectedAreaValues))]
        public void CalculateArea_ReturnExpectedResult(double radius, double expectedAreaValue)
        {
            var circle = new Circle(radius);

            var actualArea = circle.CalculateArea();

            Assert.Equal(expectedAreaValue, actualArea);
        }
    }
}
