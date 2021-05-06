namespace dddApp.model.Exceptions
{
    public class LocationNonTrouveException : System.Exception
    {
        public LocationNonTrouveException() { }
        public LocationNonTrouveException(string message) : base(message) { }
        public LocationNonTrouveException(string message, System.Exception inner) : base(message, inner) { }
        protected LocationNonTrouveException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}