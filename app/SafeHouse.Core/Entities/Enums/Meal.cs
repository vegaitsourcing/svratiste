using System;

namespace SafeHouse.Core.Entities.Enums
{
    [Flags]
    public enum Meal
    {
        None = 0,
        Breakfast = 1 << 0,
        Lunch = 1 << 1,
        Dinner = 1 << 2
    }
}