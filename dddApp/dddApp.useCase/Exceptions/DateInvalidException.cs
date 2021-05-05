namespace dddApp.useCase.Exceptions
{
    public class DateInvalidException : System.Exception
    {
        public DateInvalidException() { }
        public DateInvalidException(string message) : base(message) { }
        public DateInvalidException(string message, System.Exception inner) : base(message, inner) { }
        protected DateInvalidException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}