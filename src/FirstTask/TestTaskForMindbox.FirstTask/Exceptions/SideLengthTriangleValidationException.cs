namespace TestTaskForMindbox.FirstTask.Exceptions
{
    public class SideLengthTriangleValidationException : TriangleValidationException
    {
        public SideLengthTriangleValidationException() : base("The side length of triangle should be greater than zero.")
        {
            
        }
    }
}
