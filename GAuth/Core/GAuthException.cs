using System;

namespace GAuth_CSharp.Core
{
    public class GAuthException : Exception
    {
        public int StatusCode { get; private set; }

        public GAuthException(int statusCode)
        {
            StatusCode = statusCode;
        }
    }
}