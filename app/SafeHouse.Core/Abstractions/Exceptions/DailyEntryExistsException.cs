using System;

namespace SafeHouse.Core.Abstractions.Exceptions
{
    public class DailyEntryExistsException : Exception
    {
        public DailyEntryExistsException(string message) : base(message)
        {
        }
    }
}
