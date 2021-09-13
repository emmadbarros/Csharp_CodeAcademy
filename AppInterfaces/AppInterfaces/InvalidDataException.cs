using System;
namespace AppInterfaces
{
    public class InvalidDataException : Exception
    {
        public InvalidDataException(string msg) : base(msg) { }
        public InvalidDataException(string msg, Exception inner) : base(msg, inner) { }
    }
}
