using System;

namespace SafeHouse.Data.Enums
{
    [Flags]
    public enum Meal
    {
        Breakfast = 1,
        Lunch = 2,
        Dinner = 4
    }
}
