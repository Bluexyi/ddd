namespace dddApp.useCase.Exceptions
{
    public class ClientNonTrouveException : System.Exception
    {
        public ClientNonTrouveException() { }
        public ClientNonTrouveException(string message) : base(message) { }
        public ClientNonTrouveException(string message, System.Exception inner) : base(message, inner) { }
        protected ClientNonTrouveException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}