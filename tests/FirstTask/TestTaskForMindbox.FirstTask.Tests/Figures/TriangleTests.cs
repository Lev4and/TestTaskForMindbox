using TestTaskForMindbox.FirstTask.Exceptions;
using TestTaskForMindbox.FirstTask.Figures;

namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class TriangleTests
    {
        [Theory]
        [ClassData(typeof(TriangleTestsData.InvalidSidesLengthsValues))]
        public void Initialization_WithInvalidSidesLengths_ThrowException(double firstSideLength, double secondSideLength,
            double thirdSideLength)
        {
            var initialization = new Action(() => new Triangle(firstSideLength, secondSideLength, thirdSideLength));

            Assert.Throws<SideLengthTriangleValidationException>(initialization);
        }

        [Theory]
        [ClassData(typeof(TriangleTestsData.ImpossibleCombineSidesLengthsValues))]
        public void Initialization_WithImpossibleCombineSidesLengths_ThrowException(double firstSideLength, 
            double secondSideLength, double thirdSideLength)
        {
            var initialization = new Action(() => new Triangle(firstSideLength, secondSideLength, thirdSideLength));

            Assert.Throws<NotExistTriangleValidationException>(initialization);
        }

        [Theory]
        [ClassData(typeof(TriangleTestsData.ValidSidesLengthsValues))]
        public void Initialization_WithValidSidesLengths_CreateInstance(double firstSideLength, double secondSideLength,
            double thirdSideLength)
        {
            var instance = new Triangle(firstSideLength, secondSideLength, thirdSideLength);

            Assert.NotNull(instance);
        }

        [Theory]
        [ClassData(typeof(TriangleTestsData.SidesLengthsWithExpectedAreaValues))]
        public void CalculateArea_ReturnExpectedResult(double firstSideLength, double secondSideLength,
            double thirdSideLength, double expectedAreaValue)
        {
            var triangle = new Triangle(firstSideLength, secondSideLength, thirdSideLength);

            var actualArea = triangle.CalculateArea();

            Assert.Equal(expectedAreaValue, actualArea);
        }

        [Theory]
        [ClassData(typeof(TriangleTestsData.SidesLengthsWithExpectedIsRectangularFlagValues))]
        public void ValidateOnIsRectangular_ReturnExpectedResult(double firstSideLength, double secondSideLength,
            double thirdSideLength, bool expectedIsRectangularValue)
        {
            var triangle = new Triangle(firstSideLength, secondSideLength, thirdSideLength);

            var isRectangular = triangle.ValidateOnIsRectangular();

            Assert.Equal(expectedIsRectangularValue, isRectangular);
        }
    }
}
