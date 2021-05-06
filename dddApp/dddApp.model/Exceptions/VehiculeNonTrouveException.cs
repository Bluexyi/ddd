using System;

namespace dddApp.model.Exceptions
{
    public class VehiculeNonTrouveException : Exception
    {
        public VehiculeNonTrouveException(string message) : base(message)
        {
        }
    }
}