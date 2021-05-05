namespace dddApp.useCase {
    public class PermisClientInvalidException : System.Exception
    {
        public PermisClientInvalidException() { }
        public PermisClientInvalidException(string message) : base(message) { }
        public PermisClientInvalidException(string message, System.Exception inner) : base(message, inner) { }
        protected PermisClientInvalidException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}