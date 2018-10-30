using System;

namespace SafeHouse.Business.Contracts.Exceptions
{
    public class DailyEntryExistsException : Exception
    {
        public DailyEntryExistsException(string message) : base(message)
        {
        }
    }
}
