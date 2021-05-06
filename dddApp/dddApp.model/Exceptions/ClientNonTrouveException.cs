using System;

namespace dddApp.model.Exceptions
{
    public class ClientNonTrouveException : Exception
    {
        public ClientNonTrouveException(string message) : base(message)
        {
        }
    }
}