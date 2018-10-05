using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum SchoolActivityEnum
    {
        None = 0,
        Homework = 1 << 0,
        Practice = 1 << 1,
        Studing = 1 << 2,
        Specific = 1 << 3
    }
}
