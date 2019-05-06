using System;

namespace SafeHouse.Core.Entities.Enums
{
    [Flags]
    public enum WorkshopType
    {
        Creative = 1 << 0,
        Practical = 1 << 1
    }
}
