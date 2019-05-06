using System;

namespace SafeHouse.Core.Exceptions
{
    public class EvaluationExistsException : Exception
    {
        public EvaluationExistsException(string message) 
            : base(message)
        {
        }
    }
}
