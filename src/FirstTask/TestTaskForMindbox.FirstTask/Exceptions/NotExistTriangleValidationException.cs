namespace TestTaskForMindbox.FirstTask.Exceptions
{
    public class NotExistTriangleValidationException : TriangleValidationException
    {
        public NotExistTriangleValidationException() : base("The triangle dosen`t exists. The length side of triangle " +
            "should be less than sum of other lengths sides")
        {
            
        }
    }
}
