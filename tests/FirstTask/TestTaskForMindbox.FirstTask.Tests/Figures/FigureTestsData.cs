using TestTaskForMindbox.FirstTask.Figures;

namespace TestTaskForMindbox.FirstTask.Tests.Figures
{
    public class FigureTestsData
    {
        public class FigureWithExceptedAreaValues : TheoryData<Figure, double>
        {
            public FigureWithExceptedAreaValues()
            {
                Add(new Circle(1.0d), Math.PI);
                Add(new Circle(2.0d), 12.566370614359172);
                Add(new Triangle(2.0d, 2.0d, 2.0d), Math.Sqrt(3));
                Add(new Triangle(10.0d, 10.0d, 10.0d), Math.Sqrt(1875));
            }
        }
    }
}
