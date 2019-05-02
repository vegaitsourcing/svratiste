using System;

namespace SafeHouse.Business.Contracts.Exceptions
{
    public class EvaluationExistsException : Exception
    {
        public EvaluationExistsException(string message) 
            : base(message)
        {
        }
    }
}
