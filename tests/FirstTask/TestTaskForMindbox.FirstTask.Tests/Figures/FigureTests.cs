using TestTaskForMindbox.FirstTask.Figures;

namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class FigureTests
    {
        [Theory]
        [ClassData(typeof(FigureTestsData.FigureWithExceptedAreaValues))]
        public void CalculateArea_ReturnExpectedResult(Figure figure, double expectedAreaValue)
        {
            var actualArea = figure.CalculateArea();

            Assert.Equal(expectedAreaValue, actualArea);
        }
    }
}
