using System;

namespace SafeHouse.Core.Entities.Enums
{
    [Flags]
    public enum SchoolActivity
    {
        None = 0,
        Homework = 1 << 0,
        Practice = 1 << 1,
        Studying = 1 << 2,
        Specific = 1 << 3
    }
}