namespace dddApp.useCase.Exceptions
{
    public class VehiculeIndisponibleException : System.Exception
    {
        public VehiculeIndisponibleException() { }
        public VehiculeIndisponibleException(string message) : base(message) { }
        public VehiculeIndisponibleException(string message, System.Exception inner) : base(message, inner) { }
        protected VehiculeIndisponibleException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}