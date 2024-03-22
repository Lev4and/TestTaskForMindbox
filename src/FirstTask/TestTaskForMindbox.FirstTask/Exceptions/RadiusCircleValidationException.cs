namespace TestTaskForMindbox.FirstTask.Exceptions
{
    public class RadiusCircleValidationException : CircleValidationException
    {
        public RadiusCircleValidationException() : base("The radius of circle should be greater than zero.")
        {
            
        }
    }
}
