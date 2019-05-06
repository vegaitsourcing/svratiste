using System;

namespace SafeHouse.Core.Abstractions.Exceptions
{
    public class EvaluationExistsException : Exception
    {
        public EvaluationExistsException(string message) 
            : base(message)
        {
        }
    }
}
