using System;

namespace HW2
{
    class InputException : Exception
    {
        public InputException() { }
        public InputException(string message) : base(message) { }
    }
}
