using System;

namespace dddApp.useCase.Exceptions
{
    public class VehiculeNonTrouveException : Exception
    {
        public VehiculeNonTrouveException(string message) : base(message)
        {
        }
    }
}