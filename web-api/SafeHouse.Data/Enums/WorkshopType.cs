using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum WorkshopType
    {
        Creative = 1 << 0,
        Practical = 1 << 1
    }
}
