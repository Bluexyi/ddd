namespace dddApp.useCase.Exceptions
{
    public class VehiculeNonTrouveException : System.Exception
    {
        public VehiculeNonTrouveException() { }
        public VehiculeNonTrouveException(string message) : base(message) { }
        public VehiculeNonTrouveException(string message, System.Exception inner) : base(message, inner) { }
        protected VehiculeNonTrouveException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}