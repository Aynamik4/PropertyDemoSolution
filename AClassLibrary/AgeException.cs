using System;

namespace AClassLibrary
{
    public class AgeException : Exception
    {
        public AgeException(string exceptionMessage) : base(exceptionMessage)
        {
        }
    }
}
