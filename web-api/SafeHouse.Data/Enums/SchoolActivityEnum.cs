using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum SchoolActivityEnum
    {
        Homework = 1,
        Practice = 2,
        Studing = 4,
        Specific = 8
    }
}
