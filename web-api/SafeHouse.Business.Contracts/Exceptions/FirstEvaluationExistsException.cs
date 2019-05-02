using System;

namespace SafeHouse.Business.Contracts.Exceptions
{
    public class FirstEvaluationExistsException : Exception
    {
        public FirstEvaluationExistsException(string message) 
            : base(message)
        {
        }
    }
}
