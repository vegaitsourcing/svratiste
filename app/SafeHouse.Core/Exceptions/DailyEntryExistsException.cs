using System;

namespace SafeHouse.Core.Exceptions
{
    public class DailyEntryExistsException : Exception
    {
        public DailyEntryExistsException(string message) : base(message)
        {
        }
    }
}
