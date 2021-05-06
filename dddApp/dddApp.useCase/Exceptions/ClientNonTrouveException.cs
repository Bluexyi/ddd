using System;

namespace dddApp.useCase.Exceptions
{
    public class ClientNonTrouveException : Exception
    {
        public ClientNonTrouveException(string message) : base(message)
        {
        }
    }
}