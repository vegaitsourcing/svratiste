using System;

namespace SafeHouse.Core.Abstractions.Exceptions
{
    public class FirstEvaluationExistsException : Exception
    {
        public FirstEvaluationExistsException(string message) : base(message)
        {
        }
    }
}