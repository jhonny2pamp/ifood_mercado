using System;

namespace IfoodMercado.Exceptions
{
    class RequestException : Exception
    {
        public int Code { get; private set; }

        public RequestException(string message, int code) : base(message)
        {
            Code = code;
        }

        public RequestException(string message, int code, Exception innerException) : base(message, innerException)
        {
            Code = code;
        }
    }
}